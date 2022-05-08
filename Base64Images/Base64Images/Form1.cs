using Azure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Base64Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ConvertBase64Image(textBox2.Text);     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Image ConvertBase64Image(string base64String) 
        {
            string base64String1 = base64String.Replace("0x", "");
            byte[] bytes = Convert.FromBase64String(base64String1);
            //string decodedString = Encoding.UTF8.GetString(bytes);
            string converted = base64String.Replace('-', '+');
            converted = converted.Replace('_', '/');
            Image image;
            
            using (MemoryStream ms = new MemoryStream(bytes))
            {

                ms.Write(bytes, 0, bytes.Length);
                image = Image.FromStream(ms);
            }
        
            return image;

        }
    }
}
