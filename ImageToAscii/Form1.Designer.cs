namespace ImageToAscii
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConvertButton = new System.Windows.Forms.Button();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.FontSlider = new System.Windows.Forms.TrackBar();
            this.FontSize = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TextLengthLabel = new System.Windows.Forms.Label();
            this.DarkThemeSelect = new System.Windows.Forms.CheckBox();
            this.BrightnessSlider = new System.Windows.Forms.TrackBar();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FontSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.Font = new System.Drawing.Font("Consolas", 9F);
            this.ConvertButton.Location = new System.Drawing.Point(124, 12);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(106, 60);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadImageButton.Font = new System.Drawing.Font("Consolas", 9F);
            this.LoadImageButton.Location = new System.Drawing.Point(12, 12);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(106, 60);
            this.LoadImageButton.TabIndex = 1;
            this.LoadImageButton.Text = "Load image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTextBox.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.ForeColor = System.Drawing.Color.Black;
            this.OutputTextBox.Location = new System.Drawing.Point(12, 116);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(1400, 605);
            this.OutputTextBox.TabIndex = 4;
            this.OutputTextBox.Text = "";
            this.OutputTextBox.WordWrap = false;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Consolas", 9F);
            this.SaveButton.Location = new System.Drawing.Point(236, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(106, 60);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save As";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusTextBox.Font = new System.Drawing.Font("Consolas", 9F);
            this.StatusTextBox.Location = new System.Drawing.Point(348, 12);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(1064, 60);
            this.StatusTextBox.TabIndex = 6;
            this.StatusTextBox.Text = "Ready";
            // 
            // FontSlider
            // 
            this.FontSlider.AutoSize = false;
            this.FontSlider.BackColor = System.Drawing.SystemColors.Control;
            this.FontSlider.Location = new System.Drawing.Point(96, 78);
            this.FontSlider.Maximum = 17;
            this.FontSlider.Minimum = 1;
            this.FontSlider.Name = "FontSlider";
            this.FontSlider.Size = new System.Drawing.Size(246, 32);
            this.FontSlider.TabIndex = 7;
            this.FontSlider.Value = 9;
            this.FontSlider.Scroll += new System.EventHandler(this.FontSlider_Scroll);
            // 
            // FontSize
            // 
            this.FontSize.AutoSize = true;
            this.FontSize.BackColor = System.Drawing.Color.Transparent;
            this.FontSize.Font = new System.Drawing.Font("Consolas", 9F);
            this.FontSize.Location = new System.Drawing.Point(12, 83);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(80, 18);
            this.FontSize.TabIndex = 8;
            this.FontSize.Text = "Font size";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files|*.jpg;*.png;*.bmp";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // TextLengthLabel
            // 
            this.TextLengthLabel.AutoSize = true;
            this.TextLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.TextLengthLabel.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextLengthLabel.Location = new System.Drawing.Point(348, 83);
            this.TextLengthLabel.Name = "TextLengthLabel";
            this.TextLengthLabel.Size = new System.Drawing.Size(120, 18);
            this.TextLengthLabel.TabIndex = 9;
            this.TextLengthLabel.Text = "Text length: -";
            this.TextLengthLabel.Click += new System.EventHandler(this.TextLengthLabel_Click);
            // 
            // DarkThemeSelect
            // 
            this.DarkThemeSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkThemeSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.DarkThemeSelect.AutoSize = true;
            this.DarkThemeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DarkThemeSelect.Font = new System.Drawing.Font("Consolas", 9F);
            this.DarkThemeSelect.Location = new System.Drawing.Point(1298, 78);
            this.DarkThemeSelect.Name = "DarkThemeSelect";
            this.DarkThemeSelect.Size = new System.Drawing.Size(114, 28);
            this.DarkThemeSelect.TabIndex = 10;
            this.DarkThemeSelect.Text = "Toggle theme";
            this.DarkThemeSelect.UseVisualStyleBackColor = true;
            this.DarkThemeSelect.CheckedChanged += new System.EventHandler(this.DarkThemeSelect_CheckedChanged);
            // 
            // BrightnessSlider
            // 
            this.BrightnessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessSlider.AutoSize = false;
            this.BrightnessSlider.BackColor = System.Drawing.SystemColors.Control;
            this.BrightnessSlider.Cursor = System.Windows.Forms.Cursors.Default;
            this.BrightnessSlider.Location = new System.Drawing.Point(1035, 78);
            this.BrightnessSlider.Minimum = -10;
            this.BrightnessSlider.Name = "BrightnessSlider";
            this.BrightnessSlider.Size = new System.Drawing.Size(246, 32);
            this.BrightnessSlider.TabIndex = 13;
            this.BrightnessSlider.Scroll += new System.EventHandler(this.BrightnessSlider_Scroll);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrightnessLabel.Location = new System.Drawing.Point(877, 83);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(152, 18);
            this.BrightnessLabel.TabIndex = 14;
            this.BrightnessLabel.Text = "Adjust brightness:";
            this.BrightnessLabel.Click += new System.EventHandler(this.BrightnessLabel_Click);
            //
            // set light theme
            //
            OutputTextBox.ForeColor = lightText;
            OutputTextBox.BackColor = lightTextBox;
            StatusTextBox.ForeColor = lightText;
            StatusTextBox.BackColor = lightTextBox;
            this.ForeColor = lightText;
            this.BackColor = lightBg;
            LoadImageButton.BackColor = lightButtons;
            ConvertButton.BackColor = lightButtons;
            SaveButton.BackColor = lightButtons;
            DarkThemeSelect.BackColor = lightButtons;
            FontSlider.BackColor = lightBg;
            BrightnessSlider.BackColor = lightBg;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 733);
            this.Controls.Add(this.BrightnessLabel);
            this.Controls.Add(this.BrightnessSlider);
            this.Controls.Add(this.DarkThemeSelect);
            this.Controls.Add(this.TextLengthLabel);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.FontSlider);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.ConvertButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Image to ASCII converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FontSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Button SaveButton;
        protected System.Windows.Forms.TrackBar FontSlider;
        private System.Windows.Forms.Label FontSize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label TextLengthLabel;
        private System.Windows.Forms.CheckBox DarkThemeSelect;
        private System.Windows.Forms.TextBox StatusTextBox;
        protected System.Windows.Forms.TrackBar BrightnessSlider;
        private System.Windows.Forms.Label BrightnessLabel;
    }
}

