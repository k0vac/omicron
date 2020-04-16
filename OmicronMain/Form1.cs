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
            if (Properties.Settings.Default.HasSeenWelcome == false) {
                MessageBox.Show("This is intended for modifying the config_remoteadmin.txt file for SCP:SL. For config_remoteadmin.txt please check out Omicron Pi.\n\nhttps://github.com/Takail/Omicron-Pi");
                Properties.Settings.Default.HasSeenWelcome = true;
                Properties.Settings.Default.Save();
            }
        }

        private string YAMLizeList(string yInput)
        {
            yInput = " - " + yInput;
            return yInput;
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
            progressBar1.Value = 20;

            pisac.Write("minimum_MTF_time_to_spawn: ");
            pisac.WriteLine(numericUpDown2.Value);
            pisac.Write("maximum_MTF_time_to_spawn: ");
            pisac.WriteLine(numericUpDown3.Value);
            pisac.Write("maximum_MTF_respawn_amount: ");
            pisac.WriteLine(numericUpDown5.Value);
            pisac.Write("maximum_CI_respawn_amount: ");
            pisac.WriteLine(numericUpDown4.Value);

            pisac.WriteLine("priority_mtf_respawn: true");
            pisac.WriteLine("use_crypto_rng: false"); 

            pisac.Write("ci_respawn_percent: ");
            pisac.WriteLine(numericUpDown7.Value);
            pisac.Write("ci_on_start_percent: ");
            pisac.WriteLine(numericUpDown6.Value);

            pisac.WriteLine("team_respawn_queue: 40143140314414041340");
            progressBar1.Value = 50;

            pisac.WriteLine("server_forced_class: -1");
            pisac.WriteLine("map_seed: -1");

            pisac.Write("afk_time: ");
            pisac.WriteLine(numericUpDown8.Value);
            pisac.Write("intercom_cooldown: ");
            pisac.WriteLine(numericUpDown9.Value);
            pisac.Write("intercom_max_speech_time: ");
            pisac.WriteLine(numericUpDown10.Value);

            pisac.WriteLine("auto_round_restart_time: 10");
            

            pisac.Write("friendly_fire: ");
            pisac.WriteLine(checkBox5.Checked);

            pisac.Write("warhead_tminus_start_duration: ");
            pisac.WriteLine(numericUpDown10.Value);
            pisac.Write("human_grenade_multiplier: ");
            pisac.WriteLine(trackBar1.Value / 10.00);
            pisac.Write("scp_grenade_multiplier: ");
            pisac.WriteLine(trackBar2.Value / 10.00);


            pisac.WriteLine("lock_gates_on_countdown: true");
            pisac.WriteLine("isolate_zones_on_countdown: false");
            pisac.WriteLine("open_doors_on_countdown: true");

            pisac.Write("keep_items_after_escaping: ");
            pisac.WriteLine(checkBox10.Checked);

            pisac.WriteLine("allow_playing_as_tutorial: true"); //Planned for implementation

            pisac.Write("disable_decontamination: ");
            pisac.WriteLine(checkBox9.Checked);

            pisac.WriteLine("096_destroy_locked_doors: true"); //Planned for implementation
            pisac.WriteLine("no_holidays: false");
            pisac.WriteLine("allow_disarmed_interaction: false");
            pisac.WriteLine("914_mode: default");
            pisac.WriteLine("sinkhole_slow_amount: 30"); //Planned for implementation
            pisac.WriteLine("sinkhole_spawn_chance: 0"); //Planned for implementation



            pisac.Flush();
            pisac.Close();
            
            label10.Visible = true;
            label10.Text = "Files have been generated.";
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
