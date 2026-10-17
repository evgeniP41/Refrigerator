using RefrigeratorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace RefrigeratorProject
{
    public partial class main : Form
    {
        private List<BaseRefrigerator> fridgesList = new List<BaseRefrigerator>();
        private readonly string saveFilePath = "fridges_data.json";

        public main()
        {
            InitializeComponent();
        }

        private void SaveData()
        {
            try
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                string json = JsonConvert.SerializeObject(fridgesList, Formatting.Indented, settings);
                File.WriteAllText(saveFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження: " + ex.Message);
            }
        }

        private void LoadData()
        {
            if (File.Exists(saveFilePath))
            {
                try
                {
                    string json = File.ReadAllText(saveFilePath);
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                    var loadedFridges = JsonConvert.DeserializeObject<List<BaseRefrigerator>>(json, settings);

                    if (loadedFridges != null)
                    {
                        fridgesList = loadedFridges;
                        UpdateFridgeList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження даних: " + ex.Message);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveData();
            base.OnFormClosing(e);
        }

        private void main_Load(object sender, EventArgs e)
        {
            numericUpDown2FreezerTemperature.Minimum = -30;
            numericUpDown2FreezerTemperature.Maximum = 0;

            buttonSetFreezerTemperature.Enabled = false;
            buttonSnoozeActivate.Enabled = false;
            buttonQuickCool.Enabled = false;
            buttonConnectToWiFi.Enabled = false;
            buttonSuggestRecipe.Enabled = false;

            LoadData();
        }

        private void UpdateFridgeList()
        {
            int currentIndex = listBoxFridges.SelectedIndex;

            listBoxFridges.Items.Clear();
            foreach (var fridge in fridgesList)
            {
                string displayInfo = $"{fridge.Brand} {fridge.Model}";
                listBoxFridges.Items.Add(displayInfo);
            }

            if (currentIndex >= 0 && currentIndex < listBoxFridges.Items.Count)
            {
                listBoxFridges.SelectedIndex = currentIndex;
            }
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();

            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                if (formAdd.CreatedFridge != null)
                {
                    fridgesList.Add(formAdd.CreatedFridge);
                    UpdateFridgeList();
                    listBoxFridges.SelectedIndex = fridgesList.Count - 1;

                    SaveData();
                }
            }
        }

        private void listBoxFridges_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFridges.SelectedIndex >= 0 && listBoxFridges.SelectedIndex < fridgesList.Count)
            {
                BaseRefrigerator selectedFridge = fridgesList[listBoxFridges.SelectedIndex];

                string detailedInfo = "=== ДЕТАЛЬНА ІНФОРМАЦІЯ ===\n\n";
                detailedInfo += $"Бренд: {selectedFridge.Brand}\n";
                detailedInfo += $"Модель: {selectedFridge.Model}\n";
                detailedInfo += $"Тип системи: {selectedFridge.GetType().Name}\n\n";

                string specs = selectedFridge.GetDeviceInfo();

                bool isQuickCoolActive = specs.Contains("Поточна темп.: 1°C") || specs.Contains("Поточна темп.: 1 °C");

                specs = specs.Replace(" | ", "\n");
                detailedInfo += specs;

                if (selectedFridge is HotelMinibar minibar)
                {
                    string snoozeStatus = minibar.IsSnoozeActive ? "Активовано" : "Вимкнено";
                    string quickCoolStatus = isQuickCoolActive ? "Активовано" : "Вимкнено/Не використовується";

                    detailedInfo += $"\n\nРежим сну (Snooze): {snoozeStatus}";
                    detailedInfo += $"\nШвидке охолодження (Quick Cool): {quickCoolStatus}";
                }

                richTextBox1.Text = detailedInfo;

                bool isOn = selectedFridge.IsTurnedOn;
                bool hasFreezer = selectedFridge is RefrigeratorWithFreezer;
                bool isMinibar = selectedFridge is HotelMinibar;
                bool isSmart = selectedFridge is SmartFridge;

                buttonSetFreezerTemperature.Enabled = isOn && hasFreezer;
                numericUpDown2FreezerTemperature.Enabled = isOn && hasFreezer;

                buttonSnoozeActivate.Enabled = isOn && isMinibar;
                buttonQuickCool.Enabled = isOn && isMinibar;
                buttonConnectToWiFi.Enabled = isOn && isSmart;

                buttonSuggestRecipe.Enabled = isOn && isSmart && ((SmartFridge)selectedFridge).IsConnectedToWiFi;
            }
            else
            {
                richTextBox1.Clear();
                buttonSetFreezerTemperature.Enabled = false;
                numericUpDown2FreezerTemperature.Enabled = false;
                buttonSnoozeActivate.Enabled = false;
                buttonQuickCool.Enabled = false;
                buttonConnectToWiFi.Enabled = false;
                buttonSuggestRecipe.Enabled = false;
            }
        }

        private BaseRefrigerator GetSelectedFridge()
        {
            if (listBoxFridges.SelectedIndex >= 0 && listBoxFridges.SelectedIndex < fridgesList.Count)
            {
                return fridgesList[listBoxFridges.SelectedIndex];
            }
            return null;
        }

        private void buttonOn_Click_1(object sender, EventArgs e)
        {
            var fridge = GetSelectedFridge();
            if (fridge != null)
            {
                fridge.TurnOn();
                UpdateFridgeList();
                SaveData();
            }
        }

        private void buttonOff_Click_1(object sender, EventArgs e)
        {
            var fridge = GetSelectedFridge();
            if (fridge != null)
            {
                fridge.TurnOff();
                UpdateFridgeList();
                SaveData();
            }
        }

        private void buttonSetFridgeTemperature_Click(object sender, EventArgs e)
        {
            var fridge = GetSelectedFridge();
            if (fridge != null)
            {
                try
                {
                    double targetTemp = (double)numericUpDownFridgeTemperature.Value;
                    fridge.SetTemperature(targetTemp);
                    UpdateFridgeList();
                    SaveData();
                }
                catch (InvalidTemperatureException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка температури", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonSetFreezerTemperature_Click_1(object sender, EventArgs e)
        {
            var fridge = GetSelectedFridge();
            if (fridge is RefrigeratorWithFreezer freezerFridge)
            {
                try
                {
                    double targetTemp = (double)numericUpDown2FreezerTemperature.Value;
                    freezerFridge.SetFreezerTemp(targetTemp);
                    UpdateFridgeList();
                    SaveData();
                }
                catch (InvalidTemperatureException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка температури", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonSnoozeActivate_Click_1(object sender, EventArgs e)
        {
            var fridge = GetSelectedFridge();
            if (fridge is HotelMinibar minibar)
            {
                if (minibar.IsSnoozeActive)
                {
                    minibar.IsSnoozeActive = false;
                    MessageBox.Show("Режим сну для мінібару вимкнено.", "Snooze", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    minibar.ActivateSnooze(4);
                    MessageBox.Show("Режим сну для мінібару активовано на 4 години. Знижено рівень шуму.", "Snooze", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                UpdateFridgeList();
                SaveData();
            }
        }

        private void buttonQuickCool_Click_1(object sender, EventArgs e)
        {
            var fridge = GetSelectedFridge();
            if (fridge is HotelMinibar minibar)
            {
                string specs = minibar.GetDeviceInfo();
                bool isQuickCoolActive = specs.Contains("Поточна темп.: 1°C") || specs.Contains("Поточна темп.: 1 °C");

                if (isQuickCoolActive)
                {
                    minibar.SetTemperature(4.0);
                    MessageBox.Show("Швидке охолодження вимкнено. Повернено стандартну температуру.", "Quick Cool", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    minibar.QuickCool();
                    MessageBox.Show("Режим швидкого охолодження активовано (температуру знижено до 1°C).", "Quick Cool", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                UpdateFridgeList();
                SaveData();
            }
        }

        private void buttonConnectToWiFi_Click_1(object sender, EventArgs e)
        {
            var fridge = GetSelectedFridge();
            if (fridge is SmartFridge smartFridge)
            {
                if (!smartFridge.IsTurnedOn)
                {
                    MessageBox.Show("Неможливо підключитися до мережі: холодильник вимкнено! Спочатку натисніть 'Turn On'.", "Помилка мережі", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                smartFridge.ConnectToNetwork("Home_Smart_Network");
                MessageBox.Show("Розумний холодильник успішно підключено до Wi-Fi мережі!", "З'єднання встановлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateFridgeList();
                SaveData();
            }
        }

        private void buttonSuggestRecipe_Click_1(object sender, EventArgs e)
        {
            var fridge = GetSelectedFridge();
            if (fridge is SmartFridge smartFridge)
            {
                smartFridge.SuggestRecipes();

                string recipes = "1. Сніданок: Омлет з томатами та сиром\n\n" +
                                 "2. Обід: Крем-суп із брокколі\n\n" +
                                 "3. Десерт: Домашній йогурт з ягодами";

                MessageBox.Show(recipes, "Рекомендовані рецепти", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            int selectedIndex = listBoxFridges.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < fridgesList.Count)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Ви дійсно хочете видалити обраний холодильник?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    fridgesList.RemoveAt(selectedIndex);
                    UpdateFridgeList();
                    SaveData();

                    if (fridgesList.Count == 0)
                    {
                        richTextBox1.Clear();
                        buttonSetFreezerTemperature.Enabled = false;
                        numericUpDown2FreezerTemperature.Enabled = false;
                        buttonSnoozeActivate.Enabled = false;
                        buttonQuickCool.Enabled = false;
                        buttonConnectToWiFi.Enabled = false;
                        buttonSuggestRecipe.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть холодильник зі списку для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonGetInfo_Click(object sender, EventArgs e) { }
        private void numericUpDown2FreezerTemperature_ValueChanged(object sender, EventArgs e) { }
        private void numericUpDownFridgeTemperature_ValueChanged(object sender, EventArgs e) { }
    }
}