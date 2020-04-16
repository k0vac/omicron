using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OmicronMain
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 25)
            {
                MaxPlayersLabel.Text = "TOO HIGH!";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string[] pBinID;
            if (textBox5.Text.Contains("pastebin.com"))
            {
                pBinID = textBox5.Text.Split('/');
                textBox5.Text = pBinID[pBinID.Length - 1];
                label6.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter pisac = new StreamWriter("config_gameplay.txt");
            pisac.Write("server_name: ");
            pisac.WriteLine(textBox1.Text);
            pisac.Write("player_list_title: ");
            if (textBox2.Text != "")
            {
                pisac.WriteLine(textBox2.Text);
            } else
            {
                pisac.WriteLine("default");
            }
            pisac.Flush();
            pisac.Close();
            progressBar1.Value = 50;
            label10.Visible = true;
            label10.Text = "File's have been generated.";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
