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

            SetTheme(isDarkTheme);
        }

        Color darkTextBox = Color.FromArgb(28, 32, 47);
        Color darkBg = Color.FromArgb(41, 48, 71);
        Color darkButtons = Color.FromArgb(56, 66, 99);
        Color darkText = Color.FromArgb(220, 220, 220);

        Color lightBg = Color.FromArgb(220, 220, 220);
        Color lightTextBox = Color.FromArgb(240, 240, 240);
        Color lightButtons = Color.FromArgb(200, 200, 200);
        Color lightText = Color.FromArgb(0, 0, 0);

        ASCIIGenerator asciiGenerator = new ASCIIGenerator(Constants.constBrightnessLevels);
        StringBuilder sb = new StringBuilder();

        bool imageLoaded = false;
        bool isDarkTheme = false;
        double brightnessCounter = 0;
        Bitmap loadedImage;
        Bitmap resizedImage;

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (!imageLoaded)
            {
                StatusTextBox.AppendText(Environment.NewLine + $"Load an image first!" + Environment.NewLine);
                return;
            }

            resizeSlider.Value = 0;
            sb = asciiGenerator.ConvertImage(loadedImage, isDarkTheme);
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
            OutputTextBox.Font = new Font(
                OutputTextBox.Font.FontFamily,
                FontSlider.Value,
                OutputTextBox.Font.Style);
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imageLoaded = true;
            loadedImage = (Bitmap)Image.FromFile(openFileDialog1.FileName);
            resizedImage = (Bitmap)Image.FromFile(openFileDialog1.FileName);
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
            }
            else
            {
                isDarkTheme = false;
            }

            SetTheme(isDarkTheme);

            if (!imageLoaded)
            {
                return;
            }

            sb = asciiGenerator.ConvertImage(resizedImage, isDarkTheme);
            OutputTextBox.Text = sb.ToString();
        }

        private void BrightnessSlider_Scroll(object sender, EventArgs e)
        {
            brightnessCounter = BrightnessSlider.Value * 0.07;
            if (!imageLoaded)
            {
                return;
            }
            asciiGenerator.BrightnessLevels = BrightnessController.ChangeBrightness(asciiGenerator.BrightnessLevels, brightnessCounter);
            sb = asciiGenerator.ConvertImage(resizedImage, isDarkTheme);
            OutputTextBox.Text = sb.ToString();
        }

        private void SetTheme(bool isDark)
        {
            if (isDark)
            {
                OutputTextBox.BackColor = darkTextBox;
                OutputTextBox.ForeColor = darkText;
                StatusTextBox.BackColor = darkTextBox;
                StatusTextBox.ForeColor = darkText;
                this.ForeColor = darkText;
                this.BackColor = darkBg;
                LoadImageButton.BackColor = darkButtons;
                ConvertButton.BackColor = darkButtons;
                SaveButton.BackColor = darkButtons;
                DarkThemeSelect.BackColor = darkButtons;
                FontSlider.BackColor = darkBg;
                BrightnessSlider.BackColor = darkBg;
                resizeSlider.BackColor = darkBg;
            }
            else
            {
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
                resizeSlider.BackColor = lightBg;
            }
        }

        private void resizeSlider_Scroll(object sender, EventArgs e)
        {
            if (!imageLoaded)
            {
                return;
            }
            resizedImage = ImageResizer.ResizeImage(loadedImage, resizeSlider.Value);
            sb = asciiGenerator.ConvertImage(resizedImage, isDarkTheme);
            OutputTextBox.Text = sb.ToString();
        }
    }
}
