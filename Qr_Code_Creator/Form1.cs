using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using System.Drawing.Imaging;

namespace Qr_Code_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image QrCodeImage;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeEncoder enc = new QRCodeEncoder();
                QrCodeImage = enc.Encode(richTextBox1.Text);
                pictureBox1.Image = QrCodeImage;
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeEncoder enc = new QRCodeEncoder();
                QrCodeImage = enc.Encode(richTextBox1.Text);
                pictureBox1.Image = QrCodeImage;
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.ShowDialog();
                if (fileDialog.FileName != "")
                {
                    QrCodeImage.Save(fileDialog.FileName+".png", ImageFormat.Png);
                }
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            richTextBox1.Clear();
        }
    }
}
