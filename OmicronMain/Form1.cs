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
            pisac.WriteLine(textBox2.Text != "" ? textBox2.Text : "default");
            pisac.WriteLine("player_list_title: default");

            pisac.Write("serverinfo_pastebin_id: ");
            pisac.WriteLine(textBox5.Text != "" ? textBox5.Text : "7wV681fT");

            pisac.Write("server_ip: ");
            pisac.WriteLine(textBox3.Text != "" ? textBox3.Text : "auto");

            pisac.Write("max_players: ");
            pisac.WriteLine(numericUpDown1.Value);

            pisac.Write("use_reserved_slots: ");
            pisac.WriteLine(checkBox3.Checked ? "true" : "false");

            pisac.WriteLine("lobby_waiting_time: default");

            pisac.Write("ipv4_bind_ip: ");
            pisac.WriteLine(textBox6.Text != "" ? textBox6.Text : "0.0.0.0");

            pisac.WriteLine("ipv6_bind_ip: ::");

            pisac.Write("contact_email: ");
            pisac.WriteLine(textBox7.Text != "" ? textBox7.Text : "default");



            pisac.Flush();
            pisac.Close();
            progressBar1.Value = 50;
            label10.Visible = true;
            label10.Text = "File's have been generated.";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 25)
            {
                label18.Visible = true;
            }
            else
            {
                label18.Visible = false;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e) => label27.Text = (trackBar2.Value / 10.00) + "x";

        private void trackBar1_Scroll(object sender, EventArgs e) => label28.Text = (trackBar1.Value / 10.00) + "x";

        private void trackBar3_Scroll(object sender, EventArgs e) => label29.Text = (trackBar3.Value + "");
    }
}
