using RefrigeratorLibrary;
using RefrigeratorProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace RefrigeratorProject
{
    public partial class FormAdd : Form
    {
        public BaseRefrigerator CreatedFridge { get; private set; }

        public FormAdd()
        {
            InitializeComponent();

            buttonOK.Click += buttonOK_Click;
            buttonCANCEL.Click += buttonCANCEL_Click;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            if (comboBoxBrand.Items.Count > 0) comboBoxBrand.SelectedIndex = 0;
            if (comboBoxEnergyEfficiency.Items.Count > 0) comboBoxEnergyEfficiency.SelectedIndex = 0;
            if (comboBoxFreezerPosition.Items.Count > 0) comboBoxFreezerPosition.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox1.Text;

            bool hasFreezer = type == "Холодильник з морозильною камерою" || type == "Розумний холодильник";
            bool isSmart = type == "Розумний холодильник";

            label8.Visible = hasFreezer;
            comboBoxFreezerPosition.Visible = hasFreezer;
            label10.Visible = hasFreezer;
            numericUpDownFreezerVolume.Visible = hasFreezer;

            label4.Visible = isSmart;
            numericUpDownScreemX.Visible = isSmart;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxBrand.Text) ||
                    string.IsNullOrWhiteSpace(textBoxModel.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxEnergyEfficiency.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть всі базові поля (Вид, Бренд, Модель, Клас енергоефективності).", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.DialogResult = DialogResult.None;
                    return;
                }

                string type = comboBox1.Text;
                string brand = comboBoxBrand.Text;
                string model = textBoxModel.Text;

                int totalVol = (int)numericUpDownTotalVolume.Value;
                int fridgeVol = (int)numericUpDownFridgeVolume.Value;
                int power = (int)numericUpDownPowerConsumption.Value;

                int freezerVol = 0;
                string pos = "";

                if (type == "Холодильник з морозильною камерою" || type == "Розумний холодильник")
                {
                    if (string.IsNullOrWhiteSpace(comboBoxFreezerPosition.Text))
                    {
                        MessageBox.Show("Будь ласка, оберіть розташування морозильної камери.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.DialogResult = DialogResult.None;
                        return;
                    }
                    pos = comboBoxFreezerPosition.Text;
                    freezerVol = (int)numericUpDownFreezerVolume.Value;
                }

                if (type != "Готельний мінібар")
                {
                    if (totalVol < (fridgeVol + freezerVol))
                    {
                        MessageBox.Show("Помилка: Загальний об'єм не може бути меншим за суму об'ємів холодильної та морозильної камер!", "Некоректний об'єм", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.DialogResult = DialogResult.None;
                        return;
                    }
                }

                string color = "Білий";

                EnergyEfficiencyClass efficiency;
                string enumString = comboBoxEnergyEfficiency.Text.Replace("+", "Plus");
                if (!Enum.TryParse(enumString, out efficiency))
                {
                    efficiency = EnergyEfficiencyClass.A;
                }

                switch (type)
                {
                    case "Холодильник":
                        CreatedFridge = new Refrigerator(brand, model, efficiency, power, totalVol, fridgeVol);
                        break;

                    case "Холодильник з морозильною камерою":
                        CreatedFridge = new RefrigeratorWithFreezer(brand, model, efficiency, power, totalVol, fridgeVol, pos, freezerVol);
                        break;

                    case "Готельний мінібар":
                        CreatedFridge = new HotelMinibar(brand, model, efficiency, power, totalVol);
                        break;

                    case "Розумний холодильник":
                        double screenSize = (double)numericUpDownScreemX.Value;
                        if (screenSize <= 0)
                        {
                            MessageBox.Show("Будь ласка, вкажіть коректний розмір екрану.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.DialogResult = DialogResult.None;
                            return;
                        }
                        CreatedFridge = new SmartFridge(brand, model, efficiency, power, totalVol, fridgeVol, pos, freezerVol, screenSize);
                        break;

                    default:
                        MessageBox.Show("Оберіть коректний вид холодильника.");
                        this.DialogResult = DialogResult.None;
                        return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при створенні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}