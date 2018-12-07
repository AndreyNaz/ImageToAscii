using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageToAscii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color dark = Color.FromArgb(32, 40, 48);
        Color dark2 = Color.FromArgb(50, 58, 66);
        Color medium = Color.FromArgb(70, 78, 86);
        Color light = Color.FromArgb(240, 240, 240);
        Color light2 = Color.FromArgb(220, 220, 220);
        StringBuilder sb = new StringBuilder();
        bool imageLoaded = false;
        bool isDarkTheme = false;

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (!imageLoaded)
            {
                StatusTextBox.AppendText(Environment.NewLine + $"Load an image first!" + Environment.NewLine);
                return;
            }

            sb = ASCIIGenerator.ConvertImage(openFileDialog1.FileName, isDarkTheme);
            OutputTextBox.Text = sb.ToString();
            StatusTextBox.AppendText(Environment.NewLine + $"Successfully converted \"{openFileDialog1.SafeFileName}\"");
            TextLengthLabel.Text = $"Text length: { OutputTextBox.Text.Length} characters";
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {            
            string fileName = saveFileDialog1.FileName;
            File.WriteAllText(fileName, sb.ToString());
            StatusTextBox.AppendText(Environment.NewLine + $"Saved \"{openFileDialog1.SafeFileName}\" as \"{fileName}\"");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void FontSlider_Scroll(object sender, EventArgs e)
        {            
            OutputTextBox.ZoomFactor = (float)FontSlider.Value / 8 + 0.2f;
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imageLoaded = true;
            StatusTextBox.AppendText(Environment.NewLine + $"Loaded \"{openFileDialog1.SafeFileName}\"");
        }

        private void TextLengthLabel_Click(object sender, EventArgs e)
        {

        }

        private void DarkThemeSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkThemeSelect.Checked == true)
            {
                isDarkTheme = true;
                OutputTextBox.BackColor = dark;
                OutputTextBox.ForeColor = light;
                StatusTextBox.BackColor = dark;
                StatusTextBox.ForeColor = light;
                this.ForeColor = light;
                this.BackColor = dark2;
                LoadImageButton.BackColor = medium;
                ConvertButton.BackColor = medium;
                SaveButton.BackColor = medium;
                DarkThemeSelect.BackColor = medium;
                FontSlider.BackColor = dark2;

                if (!imageLoaded)
                {
                    return;
                }

                sb = ASCIIGenerator.ConvertImage(openFileDialog1.FileName, isDarkTheme);
                OutputTextBox.Text = sb.ToString();
            }
            else
            {
                isDarkTheme = false;
                OutputTextBox.ForeColor = dark;
                OutputTextBox.BackColor = light2;
                StatusTextBox.ForeColor = dark;
                StatusTextBox.BackColor = light2;
                this.ForeColor = dark;
                this.BackColor = light;
                LoadImageButton.BackColor = light;
                ConvertButton.BackColor = light;
                SaveButton.BackColor = light;
                DarkThemeSelect.BackColor = light;
                FontSlider.BackColor = light;

                if (!imageLoaded)
                {
                    return;
                }

                sb = ASCIIGenerator.ConvertImage(openFileDialog1.FileName, isDarkTheme);
                OutputTextBox.Text = sb.ToString();
            }
        }
    }
}
