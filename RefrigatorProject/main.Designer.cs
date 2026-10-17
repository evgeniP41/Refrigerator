namespace RefrigeratorProject
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            richTextBox1 = new RichTextBox();
            listBoxFridges = new ListBox();
            buttonOn = new Button();
            buttonOff = new Button();
            numericUpDownFridgeTemperature = new NumericUpDown();
            buttonSetFridgeTemperature = new Button();
            buttonCreateNew = new Button();
            buttonSetFreezerTemperature = new Button();
            numericUpDown2FreezerTemperature = new NumericUpDown();
            buttonSnoozeActivate = new Button();
            buttonQuickCool = new Button();
            buttonConnectToWiFi = new Button();
            buttonSuggestRecipe = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFridgeTemperature).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2FreezerTemperature).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(162, 196);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(712, 469);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // listBoxFridges
            // 
            listBoxFridges.FormattingEnabled = true;
            listBoxFridges.Location = new Point(12, 196);
            listBoxFridges.Name = "listBoxFridges";
            listBoxFridges.Size = new Size(144, 469);
            listBoxFridges.TabIndex = 1;
            listBoxFridges.SelectedIndexChanged += listBoxFridges_SelectedIndexChanged;
            // 
            // buttonOn
            // 
            buttonOn.Location = new Point(162, 12);
            buttonOn.Name = "buttonOn";
            buttonOn.Size = new Size(144, 85);
            buttonOn.TabIndex = 2;
            buttonOn.Text = "Turn On";
            buttonOn.UseVisualStyleBackColor = true;
            buttonOn.Click += buttonOn_Click_1;
            // 
            // buttonOff
            // 
            buttonOff.Location = new Point(162, 105);
            buttonOff.Name = "buttonOff";
            buttonOff.Size = new Size(144, 85);
            buttonOff.TabIndex = 3;
            buttonOff.Text = "Turn Off";
            buttonOff.UseVisualStyleBackColor = true;
            buttonOff.Click += buttonOff_Click_1;
            // 
            // numericUpDownFridgeTemperature
            // 
            numericUpDownFridgeTemperature.Location = new Point(312, 167);
            numericUpDownFridgeTemperature.Name = "numericUpDownFridgeTemperature";
            numericUpDownFridgeTemperature.Size = new Size(136, 23);
            numericUpDownFridgeTemperature.TabIndex = 5;
            numericUpDownFridgeTemperature.ValueChanged += numericUpDownFridgeTemperature_ValueChanged;
            // 
            // buttonSetFridgeTemperature
            // 
            buttonSetFridgeTemperature.Location = new Point(312, 12);
            buttonSetFridgeTemperature.Name = "buttonSetFridgeTemperature";
            buttonSetFridgeTemperature.Size = new Size(136, 149);
            buttonSetFridgeTemperature.TabIndex = 6;
            buttonSetFridgeTemperature.Text = "Set Fridge Temperature";
            buttonSetFridgeTemperature.UseVisualStyleBackColor = true;
            buttonSetFridgeTemperature.Click += buttonSetFridgeTemperature_Click;
            // 
            // buttonCreateNew
            // 
            buttonCreateNew.Location = new Point(12, 12);
            buttonCreateNew.Name = "buttonCreateNew";
            buttonCreateNew.Size = new Size(144, 85);
            buttonCreateNew.TabIndex = 7;
            buttonCreateNew.Text = "Create New Fridge";
            buttonCreateNew.UseVisualStyleBackColor = true;
            buttonCreateNew.Click += buttonCreateNew_Click;
            // 
            // buttonSetFreezerTemperature
            // 
            buttonSetFreezerTemperature.Enabled = false;
            buttonSetFreezerTemperature.Location = new Point(454, 12);
            buttonSetFreezerTemperature.Name = "buttonSetFreezerTemperature";
            buttonSetFreezerTemperature.Size = new Size(136, 149);
            buttonSetFreezerTemperature.TabIndex = 8;
            buttonSetFreezerTemperature.Text = "Set Freezer Temperature";
            buttonSetFreezerTemperature.UseVisualStyleBackColor = true;
            buttonSetFreezerTemperature.Click += buttonSetFreezerTemperature_Click_1;
            // 
            // numericUpDown2FreezerTemperature
            // 
            numericUpDown2FreezerTemperature.Enabled = false;
            numericUpDown2FreezerTemperature.Location = new Point(454, 167);
            numericUpDown2FreezerTemperature.Name = "numericUpDown2FreezerTemperature";
            numericUpDown2FreezerTemperature.Size = new Size(136, 23);
            numericUpDown2FreezerTemperature.TabIndex = 9;
            numericUpDown2FreezerTemperature.ValueChanged += numericUpDown2FreezerTemperature_ValueChanged;
            // 
            // buttonSnoozeActivate
            // 
            buttonSnoozeActivate.Enabled = false;
            buttonSnoozeActivate.Location = new Point(596, 12);
            buttonSnoozeActivate.Name = "buttonSnoozeActivate";
            buttonSnoozeActivate.Size = new Size(136, 85);
            buttonSnoozeActivate.TabIndex = 10;
            buttonSnoozeActivate.Text = "Activate Snooze";
            buttonSnoozeActivate.UseVisualStyleBackColor = true;
            buttonSnoozeActivate.Click += buttonSnoozeActivate_Click_1;
            // 
            // buttonQuickCool
            // 
            buttonQuickCool.Enabled = false;
            buttonQuickCool.Location = new Point(596, 105);
            buttonQuickCool.Name = "buttonQuickCool";
            buttonQuickCool.Size = new Size(136, 85);
            buttonQuickCool.TabIndex = 11;
            buttonQuickCool.Text = "Quick Cool";
            buttonQuickCool.UseVisualStyleBackColor = true;
            buttonQuickCool.Click += buttonQuickCool_Click_1;
            // 
            // buttonConnectToWiFi
            // 
            buttonConnectToWiFi.Enabled = false;
            buttonConnectToWiFi.Location = new Point(738, 12);
            buttonConnectToWiFi.Name = "buttonConnectToWiFi";
            buttonConnectToWiFi.Size = new Size(136, 85);
            buttonConnectToWiFi.TabIndex = 12;
            buttonConnectToWiFi.Text = "Connect to WiFi";
            buttonConnectToWiFi.UseVisualStyleBackColor = true;
            buttonConnectToWiFi.Click += buttonConnectToWiFi_Click_1;
            // 
            // buttonSuggestRecipe
            // 
            buttonSuggestRecipe.Enabled = false;
            buttonSuggestRecipe.Location = new Point(738, 103);
            buttonSuggestRecipe.Name = "buttonSuggestRecipe";
            buttonSuggestRecipe.Size = new Size(136, 87);
            buttonSuggestRecipe.TabIndex = 13;
            buttonSuggestRecipe.Text = "Suggest Recipe\r\n(needs WiFi)";
            buttonSuggestRecipe.UseVisualStyleBackColor = true;
            buttonSuggestRecipe.Click += buttonSuggestRecipe_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(12, 105);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(144, 85);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Delete Fridge";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click_1;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 676);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSuggestRecipe);
            Controls.Add(buttonConnectToWiFi);
            Controls.Add(buttonQuickCool);
            Controls.Add(buttonSnoozeActivate);
            Controls.Add(numericUpDown2FreezerTemperature);
            Controls.Add(buttonSetFreezerTemperature);
            Controls.Add(buttonCreateNew);
            Controls.Add(buttonSetFridgeTemperature);
            Controls.Add(numericUpDownFridgeTemperature);
            Controls.Add(buttonOff);
            Controls.Add(buttonOn);
            Controls.Add(listBoxFridges);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "main";
            Text = "Холодильники";
            Load += main_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownFridgeTemperature).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2FreezerTemperature).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private ListBox listBoxFridges;
        private Button buttonOn;
        private Button buttonOff;
        private NumericUpDown numericUpDownFridgeTemperature;
        private Button buttonSetFridgeTemperature;
        private Button buttonCreateNew;
        private Button buttonSetFreezerTemperature;
        private NumericUpDown numericUpDown2FreezerTemperature;
        private Button buttonSnoozeActivate;
        private Button buttonQuickCool;
        private Button buttonConnectToWiFi;
        private Button buttonSuggestRecipe;
        private Button buttonDelete;
    }
}