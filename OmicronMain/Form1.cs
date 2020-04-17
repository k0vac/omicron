using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace OmicronMain
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            
            
        }

        string modeFor914Var = "DroppedAndPlayerTeleport";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/k0vac/omicron");
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
            pisac.WriteLine("player_list_rate: default");

            pisac.Write("serverinfo_pastebin_id: ");
            pisac.WriteLine(textBox5.Text != "" ? textBox5.Text : "7wV681fT");

            pisac.Write("server_ip: ");
            pisac.WriteLine(textBox3.Text != "" ? textBox3.Text : "auto");

            pisac.Write("max_players: ");
            pisac.WriteLine(numericUpDown1.Value);

            pisac.WriteLine("use_reserved_slots: {0}", checkBox3.Checked);

            pisac.WriteLine("lobby_waiting_time: default");

            pisac.Write("ipv4_bind_ip: ");
            pisac.WriteLine(textBox6.Text != "" ? textBox6.Text : "0.0.0.0");

            pisac.WriteLine("ipv6_bind_ip: ::"); //Planned for Implementation

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
            pisac.WriteLine("afk_time: {0}", numericUpDown8.Value);
            pisac.WriteLine("intercom_cooldown: {0}", numericUpDown9.Value);
            pisac.WriteLine("intercom_max_speech_time: {0}", numericUpDown10.Value);
            pisac.WriteLine("auto_round_restart_time: 10");
            pisac.WriteLine("friendly_fire: {0}", checkBox5.Checked);
            pisac.WriteLine("warhead_tminus_start_duration: {0}", numericUpDown10.Value);
            pisac.WriteLine("human_grenade_multiplier: {0}", trackBar1.Value / 10.00);
            pisac.WriteLine("scp_grenade_multiplier: {0}", trackBar2.Value / 10.00);
            pisac.WriteLine("lock_gates_on_countdown: true");
            pisac.WriteLine("isolate_zones_on_countdown: false");
            pisac.WriteLine("open_doors_on_countdown: true");
            pisac.WriteLine("keep_items_after_escaping: {0}", checkBox10.Checked);
            pisac.WriteLine("allow_playing_as_tutorial: true"); //Planned for implementation
            pisac.WriteLine("disable_decontamination: {0}", checkBox9.Checked);
            pisac.WriteLine("096_destroy_locked_doors: true"); //Planned for implementation
            pisac.WriteLine("no_holidays: false");
            pisac.WriteLine("allow_disarmed_interaction: false");
            pisac.WriteLine("914_mode: {0}", modeFor914Var); //DO NOW
            pisac.WriteLine("sinkhole_slow_amount: 30"); //Planned for implementation
            pisac.WriteLine("sinkhole_spawn_chance: 0"); //Planned for implementation
            pisac.WriteLine("pd_exit_count: ", trackBar3.Value);
            pisac.WriteLine("pd_random_exit_rids:");
            pisac.WriteLine("pd_random_exit_rids_after_decontamination:");
            pisac.WriteLine("pd_refresh_exit: false");
            progressBar1.Value = 60;

            pisac.WriteLine("mtf_can_cuff_researchers: true"); //Planned for implementation
            pisac.WriteLine("ci_can_cuff_class_d: true"); //Planned for implementation
            pisac.WriteLine("cuffed_escapee_change_team: true"); //Planned for implementation

            pisac.WriteLine("spawn_protect_disable: {0}", !checkBox11.Checked);
            pisac.WriteLine("spawn_protect_time: {0}", numericUpDown13.Value);
            pisac.WriteLine("spawn_protect_team: [1, 2]");
            pisac.WriteLine("spawn_protect_allow_dmg: {0}", checkBox12.Checked);

            pisac.WriteLine("grenade_chain_limit: 10");
            pisac.WriteLine("grenade_chain_length_limit: 4");

            pisac.WriteLine("online_mode: {0}", checkBox1.Checked);
            pisac.WriteLine("ip_banning: true");
            pisac.WriteLine("enable_whitelist: {0}", checkBox2.Checked);
            pisac.WriteLine("hide_from_public_list: {0}", checkBox8.Checked);
            pisac.WriteLine("forward_ports: {0}", checkBox6.Checked);
            pisac.WriteLine("enable_query: {0}", checkBox13.Checked);
            pisac.WriteLine("query_port_shift: {0}", numericUpDown14.Value);
            pisac.WriteLine("query_use_IPv6: {0}", checkBox14.Checked);
            pisac.WriteLine(textBox8.Text != "" ? "administator_query_password : " + textBox8.Text : "administator_query_password : none");
            pisac.WriteLine("enable_sync_command_binding: false");
            pisac.WriteLine("anti_player_wallhack: default"); //DEPRECATED
            pisac.WriteLine("ratelimit_kick: {0}", checkBox15.Checked);
            pisac.WriteLine("enforce_same_ip: {0}", checkBox16.Checked);
            pisac.WriteLine("no_enforcement_for_local_ip_addresses: true");
            pisac.WriteLine("enforce_same_asn: {0}", checkBox16.Checked);
            pisac.WriteLine("enable_ip_ratelimit: {0}", checkBox7.Checked);
            pisac.WriteLine("enable_userid_ratelimit: {0}", checkBox7.Checked);
            pisac.WriteLine("ip_ratelimit_window: {0}", numericUpDown12.Value);
            pisac.WriteLine("userid_ratelimit_window: {0}", numericUpDown12.Value);

            pisac.WriteLine("class_d_personnel_defaultammo: [0, 0, 0]");
            pisac.WriteLine("nine_tailed_fox_scientist_defaultammo: [120, 20, 20]");
            pisac.WriteLine("scientist_defaultammo: [0, 0, 0]");
            pisac.WriteLine("chaos_insurgency_defaultammo: [0, 100, 0]");
            pisac.WriteLine("nine_tailed_fox_lieutenant_defaultammo: [120, 0, 100]");
            pisac.WriteLine("nine_tailed_fox_commander_defaultammo: [120, 0, 100]");
            pisac.WriteLine("nine_tailed_fox_cadet_defaultammo: [40, 0, 100]");
            pisac.WriteLine("tutorial_defaultammo: [0, 0, 0]");
            pisac.WriteLine("facility_guard_defaultammo: [0, 35, 0]");

            pisac.WriteLine("custom_whitelist: false"); //Planned "Others" Tab
            pisac.WriteLine("server_access_restrictions: false"); //Planned "Others" Tab

            string[] portsList = textBox4.Text.Split(',');
            progressBar1.Value = 75;

            pisac.WriteLine("port_queue:");

            for(int i = 0; i < portsList.Length; i++)
            {
                pisac.WriteLine(" - " + portsList[i]);
            }

            pisac.WriteLine("gban_ban_ip: default");
            pisac.WriteLine("noclip_protection_output: false");
            pisac.WriteLine("speedhack_protection_output: false");
            pisac.WriteLine("broadcast_kicks: false"); //Planned "Others" Tab
            pisac.WriteLine("broadcast_kick_text: %nick% has been kicked."); //Planned "Others" Tab
            pisac.WriteLine("broadcast_kick_duration: 5"); //Planned "Others" Tab
            pisac.WriteLine("broadcast_bans: true"); //Planned "Others" Tab
            pisac.WriteLine("broadcast_ban_text: %nick% has been banned."); //Planned "Others" Tab
            pisac.WriteLine("broadcast_ban_duration: 5"); //Planned "Others" Tab

            pisac.WriteLine("geoblocking_whitelist:"); //Planned "Others" Tab
            pisac.WriteLine(" - AA");
            pisac.WriteLine(" - AB");
            pisac.WriteLine(" - AC");

            pisac.WriteLine("geoblocking_blacklist:"); //Planned "Others" Tab
            pisac.WriteLine(" - AA");
            pisac.WriteLine(" - AB");
            pisac.WriteLine(" - AC");


            pisac.Flush();
            pisac.Close();

            progressBar1.Value = 100;
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

        Form2 frm2 = new Form2();
        int ticks = 0;
        public void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Dropped + Player Teleport";
            timer1.Start();
            frm2.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticks == 0)
            {
                frm2.Close();
                ticks++;
            } else
            {
                timer1.Stop();
                if (Properties.Settings.Default.HasSeenWelcome == false)
                {
                    MessageBox.Show("This is intended for modifying the config_remoteadmin.txt file for SCP:SL. For config_remoteadmin.txt please check out Omicron Pi.\n\nhttps://github.com/Takail/Omicron-Pi");
                    Properties.Settings.Default.HasSeenWelcome = true;
                    Properties.Settings.Default.Save();
                }
                
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
            {
                numericUpDown8.Enabled = false;
                numericUpDown8.Value = 0;
            } else
            {
                numericUpDown8.Enabled = true;
                numericUpDown8.Value = 90;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox15.Checked)
            {
                label47.Visible = true;
            }
            else
            {
                label47.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                label45.Visible = true;
            }
            else
            {
                label45.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem)
            {
                case "Dropped(No Player Teleport)":
                    modeFor914Var = "Dropped";
                    break;
                case "Dropped + Held":
                    modeFor914Var = "DroppedAndHeld";
                    break;
                case "Dropped + Inventory":
                    modeFor914Var = "DroppedAndInventory";
                    break;
                case "Dropped + Player Teleport":
                    modeFor914Var = "DroppedAndPlayerTeleport";
                    break;
                case "Held":
                    modeFor914Var = "Held";
                    break;
                case "Inventory":
                    modeFor914Var = "Inventory";
                    break;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox13.Checked)
            {
                numericUpDown14.Enabled = false;
                textBox8.Enabled = false;
                checkBox14.Enabled = false;
            } else
            {
                numericUpDown14.Enabled = true;
                textBox8.Enabled = true;
                checkBox14.Enabled = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/Veljko61");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/takail/omicron-pi");
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox11.Checked)
            {
                numericUpDown13.Enabled = false;
                numericUpDown13.Value = 0;
            }
            else
            {
                numericUpDown13.Enabled = true;
                numericUpDown13.Value = 30;
            }
        }
    }
}
