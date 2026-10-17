namespace RefrigeratorProject
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            buttonOK = new Button();
            buttonCANCEL = new Button();
            comboBoxBrand = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            numericUpDownFridgeVolume = new NumericUpDown();
            label8 = new Label();
            comboBoxFreezerPosition = new ComboBox();
            label10 = new Label();
            numericUpDownFreezerVolume = new NumericUpDown();
            label9 = new Label();
            textBoxModel = new TextBox();
            label11 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            numericUpDownScreemX = new NumericUpDown();
            comboBoxEnergyEfficiency = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            numericUpDownPowerConsumption = new NumericUpDown();
            label2 = new Label();
            numericUpDownTotalVolume = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFridgeVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFreezerVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreemX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPowerConsumption).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalVolume).BeginInit();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(319, 508);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "Зберегти";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCANCEL
            // 
            buttonCANCEL.DialogResult = DialogResult.Cancel;
            buttonCANCEL.Location = new Point(400, 508);
            buttonCANCEL.Name = "buttonCANCEL";
            buttonCANCEL.Size = new Size(75, 23);
            buttonCANCEL.TabIndex = 3;
            buttonCANCEL.Text = "Скасувати";
            buttonCANCEL.UseVisualStyleBackColor = true;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Items.AddRange(new object[] { "SAMSUNG", "BOSCH", "LG", "SATURN", "WHIRLPOOL", "BEKO" });
            comboBoxBrand.Location = new Point(12, 79);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(121, 23);
            comboBoxBrand.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 5;
            label1.Text = "Бренд";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(11, 201);
            label3.Name = "label3";
            label3.Size = new Size(180, 19);
            label3.TabIndex = 7;
            label3.Text = "Об'єм холодильної камери";
            // 
            // numericUpDownFridgeVolume
            // 
            numericUpDownFridgeVolume.Location = new Point(11, 223);
            numericUpDownFridgeVolume.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownFridgeVolume.Name = "numericUpDownFridgeVolume";
            numericUpDownFridgeVolume.Size = new Size(120, 23);
            numericUpDownFridgeVolume.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(247, 9);
            label8.Name = "label8";
            label8.Size = new Size(235, 19);
            label8.TabIndex = 17;
            label8.Text = "Розташування морозильної камери";
            // 
            // comboBoxFreezerPosition
            // 
            comboBoxFreezerPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFreezerPosition.FormattingEnabled = true;
            comboBoxFreezerPosition.Items.AddRange(new object[] { "Зверху", "Знизу" });
            comboBoxFreezerPosition.Location = new Point(354, 31);
            comboBoxFreezerPosition.Name = "comboBoxFreezerPosition";
            comboBoxFreezerPosition.Size = new Size(121, 23);
            comboBoxFreezerPosition.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(299, 57);
            label10.Name = "label10";
            label10.Size = new Size(183, 19);
            label10.TabIndex = 21;
            label10.Text = "Об'єм морозильної камери";
            // 
            // numericUpDownFreezerVolume
            // 
            numericUpDownFreezerVolume.Location = new Point(355, 80);
            numericUpDownFreezerVolume.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownFreezerVolume.Name = "numericUpDownFreezerVolume";
            numericUpDownFreezerVolume.Size = new Size(120, 23);
            numericUpDownFreezerVolume.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(12, 105);
            label9.Name = "label9";
            label9.Size = new Size(152, 19);
            label9.TabIndex = 23;
            label9.Text = "Модель холодильника";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(12, 127);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(100, 23);
            textBoxModel.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(126, 19);
            label11.TabIndex = 25;
            label11.Text = "Вид холодильника";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Холодильник", "Холодильник з морозильною камерою", "Готельний мінібар", "Розумний холодильник" });
            comboBox1.Location = new Point(12, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(375, 153);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 27;
            label4.Text = "Розмір екрану";
            // 
            // numericUpDownScreemX
            // 
            numericUpDownScreemX.Location = new Point(355, 175);
            numericUpDownScreemX.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownScreemX.Name = "numericUpDownScreemX";
            numericUpDownScreemX.Size = new Size(120, 23);
            numericUpDownScreemX.TabIndex = 29;
            // 
            // comboBoxEnergyEfficiency
            // 
            comboBoxEnergyEfficiency.FormattingEnabled = true;
            comboBoxEnergyEfficiency.Items.AddRange(new object[] { "A+++", "A++", "A+", "A", "B", "C", "D", "E", "F", "G" });
            comboBoxEnergyEfficiency.Location = new Point(11, 271);
            comboBoxEnergyEfficiency.Name = "comboBoxEnergyEfficiency";
            comboBoxEnergyEfficiency.Size = new Size(121, 23);
            comboBoxEnergyEfficiency.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(12, 249);
            label13.Name = "label13";
            label13.Size = new Size(167, 19);
            label13.TabIndex = 32;
            label13.Text = "Клас енергоефективності";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(12, 297);
            label12.Name = "label12";
            label12.Size = new Size(134, 19);
            label12.TabIndex = 33;
            label12.Text = "Споживання енергії";
            // 
            // numericUpDownPowerConsumption
            // 
            numericUpDownPowerConsumption.Location = new Point(12, 319);
            numericUpDownPowerConsumption.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownPowerConsumption.Name = "numericUpDownPowerConsumption";
            numericUpDownPowerConsumption.Size = new Size(120, 23);
            numericUpDownPowerConsumption.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 6;
            label2.Text = "Об'єм";
            // 
            // numericUpDownTotalVolume
            // 
            numericUpDownTotalVolume.Location = new Point(12, 175);
            numericUpDownTotalVolume.Maximum = new decimal(new int[] { 800, 0, 0, 0 });
            numericUpDownTotalVolume.Name = "numericUpDownTotalVolume";
            numericUpDownTotalVolume.Size = new Size(120, 23);
            numericUpDownTotalVolume.TabIndex = 1;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 543);
            Controls.Add(numericUpDownPowerConsumption);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(comboBoxEnergyEfficiency);
            Controls.Add(numericUpDownScreemX);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label11);
            Controls.Add(textBoxModel);
            Controls.Add(label9);
            Controls.Add(numericUpDownFreezerVolume);
            Controls.Add(label10);
            Controls.Add(comboBoxFreezerPosition);
            Controls.Add(label8);
            Controls.Add(numericUpDownFridgeVolume);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxBrand);
            Controls.Add(buttonCANCEL);
            Controls.Add(buttonOK);
            Controls.Add(numericUpDownTotalVolume);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormAdd";
            Text = "Створення холодильника";
            Load += FormAdd_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownFridgeVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFreezerVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreemX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPowerConsumption).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonOK;
        private Button buttonCANCEL;
        private ComboBox comboBoxBrand;
        private Label label1;
        private Label label3;
        private NumericUpDown numericUpDownFridgeVolume;
        private Label label8;
        private ComboBox comboBoxFreezerPosition;
        private Label label10;
        private NumericUpDown numericUpDownFreezerVolume;
        private Label label9;
        private TextBox textBoxModel;
        private Label label11;
        private ComboBox comboBox1;
        private Label label4;
        private NumericUpDown numericUpDownScreemX;
        private ComboBox comboBoxEnergyEfficiency;
        private Label label13;
        private Label label12;
        private NumericUpDown numericUpDownPowerConsumption;
        private Label label2;
        private NumericUpDown numericUpDownTotalVolume;
    }
}