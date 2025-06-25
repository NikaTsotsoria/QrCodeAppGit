using QrCodeApp.Models;
using QrCodeApp.Services;
using QrCodeApp.Interfaces;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;

namespace QrCodeApp
{
    public partial class Form1 : Form
    {
        private readonly IQrCodeService qrCodeService = new QrCodeService();
        private readonly IUrlShortenerService urlShortenerService = new UrlShortenerService();
        private readonly IWatermarkService watermarkService = new WatermarkService();
        private QrCodeSettings qrSettings = new QrCodeSettings();
        private int qrCodeCounter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void GenerateQrCodeButton_Click(object sender, EventArgs e)
        {
            string data = txtEnterQrCodeLinkTextBox.Text.Trim();
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("Please enter a link to generate QR code", "Error");
                return;
            }
            Bitmap qrCodeImage = qrCodeService.GenerateQrCode(data, qrSettings);
            picQrCode.Image = qrCodeImage;
            picQrCode.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (picQrCode.Image == null)
            {
                MessageBox.Show("Please generate a QR code before saving.", "Error");
                return;
            }
            string folderPath = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "QrCodeImages");
            System.IO.Directory.CreateDirectory(folderPath);

            string savepath;
            do
            {
                savepath = System.IO.Path.Combine(folderPath, $"QrCode_{qrCodeCounter}.png");
                qrCodeCounter++;
            }
            while (System.IO.File.Exists(savepath));

            using (Bitmap bmp = new Bitmap(picQrCode.Image))
            {
                bmp.Save(savepath, System.Drawing.Imaging.ImageFormat.Png);
            }
            MessageBox.Show($"QR Code saved successfully at {savepath}", "Success");
        }

        private void CustomizeButton_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter pixel size (recommended 5-30):", "Pixel Size", qrSettings.PixelSize.ToString());
            if (int.TryParse(input, out int pixelSize) && pixelSize > 0 && pixelSize <= 100)
                qrSettings.PixelSize = pixelSize;

            using (ColorDialog fgDialog = new ColorDialog())
            {
                if (fgDialog.ShowDialog() == DialogResult.OK)
                    qrSettings.ForegroundColor = fgDialog.Color;
            }
            using (ColorDialog bgDialog = new ColorDialog())
            {
                if (bgDialog.ShowDialog() == DialogResult.OK)
                    qrSettings.BackgroundColor = bgDialog.Color;
            }
        }

        private void LoadQrCodeButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select QR Code Image";
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp|All Files|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load image from file
                        Bitmap loadedBitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                        picQrCode.Image = loadedBitmap;
                        picQrCode.SizeMode = PictureBoxSizeMode.CenterImage;

                        // Decode QR code
                        string decodedText = qrCodeService.DecodeQrCode(loadedBitmap);

                        if (!string.IsNullOrEmpty(decodedText))
                        {
                            txtEnterQrCodeLinkTextBox.Text = decodedText;
                        }
                        else
                        {
                            MessageBox.Show("Failed to decode the QR code from the selected image.", "Decoding Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEnterQrCodeLinkTextBox.Text = string.Empty;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading or decoding QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private async void ShortenerUrlButton_Click(object sender, EventArgs e)
        {
            string originalUrl = txtEnterQrCodeLinkTextBox.Text.Trim();
            if (string.IsNullOrEmpty(originalUrl) || !Uri.IsWellFormedUriString(originalUrl, UriKind.Absolute))
            {
                MessageBox.Show("Please enter a valid URL.", "Error");
                return;
            }
            try
            {
                string shortenedUrl = await urlShortenerService.ShortenUrlAsync(originalUrl);
                txtEnterQrCodeLinkTextBox.Text = shortenedUrl;
                MessageBox.Show("URL shortened successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to shorten URL: {ex.Message}", "Error");
            }
        }

        private void WaterMarkButton_Click(object sender, EventArgs e)
        {
            if (picQrCode.Image == null)
            {
                MessageBox.Show("No image loaded.", "Error");
                return;
            }
            string watermarkText = Interaction.InputBox("Enter watermark text:", "Watermark Text", "My Watermark");
            if (string.IsNullOrWhiteSpace(watermarkText))
                return;

            Bitmap watermarked = watermarkService.AddTextWatermark(new Bitmap(picQrCode.Image), watermarkText);
            picQrCode.Image = watermarked;
            picQrCode.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
           
            txtEnterQrCodeLinkTextBox.Text = string.Empty;
            picQrCode.Image = null;

            
            qrSettings = new QrCodeSettings();


            string currentData = txtEnterQrCodeLinkTextBox.Text.Trim(); 
            if (!string.IsNullOrEmpty(currentData))
            {
                Bitmap qrCodeImage = qrCodeService.GenerateQrCode(currentData, qrSettings);
                picQrCode.Image = qrCodeImage;
                picQrCode.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picQrCode_Click(object sender, EventArgs e)
        {
           
        }

    }
}
