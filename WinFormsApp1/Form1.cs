using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //鼠标
        public int xPos;
        public int yPos;
        public bool bFlag;
        public bool aFlag;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aFlag = false;
            bFlag = false;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            if (aFlag)
            {
                pictureBox1.ImageLocation = textBox5.Text;
                //pictureBox1.Image = Image.FromFile(textBox5.Text);
                
            }
            else
            {
                openFileDialog1.ShowDialog();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = (int)(pictureBox1.Width * 1.2f);
            pictureBox1.Height = (int)(pictureBox1.Height * 1.2f);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Width >= 15 && pictureBox1.Height >=20)
            {
                pictureBox1.Width = (int)(pictureBox1.Width * 0.8f);
                pictureBox1.Height = (int)(pictureBox1.Height * 0.8f);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            aFlag = true;
        }

        private void picImage_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void picImage_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            bFlag = true;
            xPos = e.X;
            yPos = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bFlag == true)
            {
                pictureBox1.Left += e.X - xPos;
                pictureBox1.Top += e.Y - yPos;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            bFlag = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "（*.jpg）|*.jpg|（*.png）|*.png|（*.DNG）|*.DNG";
            saveFileDialog1.ShowDialog();
            pictureBox1.Image.Save(saveFileDialog1.FileName);
            MessageBox.Show("OK");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteImage();
        }

        void DeleteImage()
        {
            pictureBox1.Image = null;
            if (textBox5.Text == null)
            {
                aFlag = false;
            }
            else
            {
                aFlag = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string str1 = textBox5.Text;
            //string[] strUrls = new string[14];
            //for (int i=0; i<15; i++)
            //{
            //    strUrls[i] = @textBox5.Text;
            //    pictureBox1.ImageLocation = strUrls[i];
            //}
            
        }
    }
}
