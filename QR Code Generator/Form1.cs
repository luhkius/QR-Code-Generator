using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace QR_Code_Generator
{
    public partial class Form1 : Form
    {

        enum QRType
        {
            Website,
            Email,
            Text
        }

        QRType QR_Type = new QRType();

        String QText = "";
        public Form1()
        {
            InitializeComponent();
            
            QR_Type = QRType.Website;
            btn_web.Text.Click += Text_Click;
            btn_text.Text.Click += Text_Click1;
            btn_email.Text.Click += Text_Click2;

            btn_save.Text.Click += Text_Click3;
        }

        private void Text_Click3(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                // Displays a SaveFileDialog so the user can save the Image
                // assigned to Button2.
                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
                    saveFileDialog1.Title = "Save an Image File";
                    saveFileDialog1.ShowDialog();

                    // If the file name is not an empty string open it for saving.
                    if (saveFileDialog1.FileName != "")
                    {
                        // Saves the Image via a FileStream created by the OpenFile method.
                        Stream fs = saveFileDialog1.OpenFile();
                        // Saves the Image in the appropriate ImageFormat based upon the
                        // File type selected in the dialog box.
                        // NOTE that the FilterIndex property is one-based.
                        switch (saveFileDialog1.FilterIndex)
                        {
                            case 1:
                                pictureBox1.Image.Save(fs, ImageFormat.Jpeg);
                                break;

                            case 2:
                                pictureBox1.Image.Save(fs, ImageFormat.Bmp);
                                break;

                            case 3:
                                pictureBox1.Image.Save(fs, ImageFormat.Gif);
                                break;

                            case 4:
                                pictureBox1.Image.Save(fs, ImageFormat.Png);
                                break;
                        }

                        fs.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("No QR Code to Save", "Empty QR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        

        private void Text_Click2(object sender, EventArgs e)
        {
            TextBox1.BackColor = Color.FromArgb(11, 46, 25);
            QR_Type = QRType.Email;
            this.ActiveControl = TextBox1;
        }

        private void Text_Click1(object sender, EventArgs e)
        {
            TextBox1.BackColor = Color.FromArgb(18, 53, 77);
            QR_Type = QRType.Text;
            this.ActiveControl = TextBox1;
        }

        private void Text_Click(object sender, EventArgs e)
        {
            TextBox1.BackColor = Color.FromArgb(66, 41, 0);
            QR_Type = QRType.Website;
            this.ActiveControl = TextBox1;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            if(QR_Type == QRType.Website)
            {
                if(!TextBox1.Text.Contains("https://") || !TextBox1.Text.Contains("http://"))
                QText = "https://" + TextBox1.Text;
            }

            if (QR_Type == QRType.Email)
            {
                if (!TextBox1.Text.Contains("mailto:"))
                    QText = "mailto:" + TextBox1.Text;
            }

            if(QR_Type == QRType.Text)
            {
                QText = TextBox1.Text;
            }

            try
            {
                QRCoder.QRCodeGenerator qR = new QRCoder.QRCodeGenerator();
                var Data = qR.CreateQrCode(QText, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(Data);
                pictureBox1.Image = code.GetGraphic(50);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
