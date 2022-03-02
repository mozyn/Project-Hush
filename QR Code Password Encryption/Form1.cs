using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace QR_Code_Password_Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool encryptButtonClicked = false;

        //randomized custom ASCII
        char[] charTable = { '~', '@', 'X', '#', '3', 'Y', 'a', '+', 'K', 'E', 'I', 'x', '{', '/', '+', 'f', ';', 'b', 'L', 'P', '|', '7', '-', '`', 'v', 'S', '[', 'n', 'H', 'r', '9', 'u', 'J', 'G', ']', 'U', '\\', ',', 'j', '0', '6', 'e', '^', 'p', 'd', '4', 'O', 'z', 't', 'h', '8', 'q', 'M', 'T', 'C', 'k', 'N', '5', ')', 'F', '>', '\"', 'Q', 'A', 'l', 's', 'D', ':', '<', '(', '_', '$', '&', 'g', 'i', '2', '!', 'B', 'R', 'W', '?', '.', ';', 'm', '}', 'y', 'V', 'Z', 'c', '1', '*', '\'', '%', 'w', 'o' };



        string encryptPass()
        {
            string encrypted = "";
            int currentASCII = 0;
            string temp = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                for (int j = 0; j < charTable.Length; j++)
                {
                    if (textBox1.Text[i] > 33 || textBox1.Text[i] < 127)
                    {
                        if (textBox1.Text[i] == charTable[j])
                        {
                            currentASCII = (int)(j + BirthMonthSelect.Value * 100 + BirthDaySelect.Value);
                            currentASCII %= 94;
                            temp += Convert.ToChar(currentASCII);
                            encrypted += Convert.ToChar(temp[i] + 32); //algorithm
                        }
                    }
                    else
                    {
                        encrypted = "ERROR";
                        textBox1.Text = encrypted;
                        return encrypted;
                    }
                }
            }
            textBox1.Text = encrypted;
            //pass in data and store in variable
            return encrypted;
        }

        string decryptPass()
        {
            int currentASCII = 0;
            int temp = 0;
            string decrypted = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                currentASCII = (textBox1.Text[i]-32);
                currentASCII -= (int)(BirthMonthSelect.Value * 100 + BirthDaySelect.Value);
                currentASCII %= 94;
                currentASCII *= -1;
                temp = 94 - currentASCII;
                decrypted += charTable[temp];
            }
            textBox1.Text = decrypted;
            return decrypted;
        }






        //encrypt button
        private void button1_Click(object sender, EventArgs e)
        {
            encryptButtonClicked = true;
            button2.Enabled = true;
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox.");
                encryptButtonClicked=false;
                return; // return because we don't want to run normal code of buton click
            }

            var options = new QrCodeEncodingOptions
            {
                Height = pictureBox1.Height,
                Width = pictureBox1.Width
            };
            //create an instance of BarcodeWriter
            var writer = new BarcodeWriter();
            //set format
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;

            //pass in data and store in variable
            string encryptedPass = encryptPass();
            if (encryptedPass == string.Empty)
            {
                MessageBox.Show("ERROR!");
            }
            else
            {
                var result = writer.Write(encryptedPass);
                pictureBox1.Image = result;
            }
            
        }

        

        //decrypt button
        private void button2_Click(object sender, EventArgs e)
        {
            if (encryptButtonClicked == false)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                var options = new QrCodeEncodingOptions
                {
                    Height = pictureBox1.Height,
                    Width = pictureBox1.Width
                };
                //create an instance of BarcodeWriter
                var writer = new BarcodeWriter();
                //set format
                writer.Format = BarcodeFormat.QR_CODE;
                writer.Options = options;

                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("No valid character in the textbox!");
                }
                else
                {
                    var result = writer.Write(decryptPass());
                    pictureBox1.Image = result;
                }

            }
        }
        
       //save QR
        private void button3_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = path;
            dialog.Filter = "PNG| *.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif"; //default file types
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(dialog.FileName);
            }
        }

        //decrypt QR
        private void button4_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var reader = new BarcodeReader();
                var imgFile = Image.FromFile(dialog.FileName) as Bitmap;
                pictureBox1.Image = imgFile;
                var result = reader.Decode(imgFile);
                textBox1.Text = result.Text;


                string decrypted = "";
                
                    decrypted = decryptPass();
             
                textBox1.Text = decrypted;

            }
        }

       

    }
}
