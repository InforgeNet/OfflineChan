using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_OfflineChat
{
    public partial class Form1 : Form
    {
        bool stoppingChat = false;
        string hostsFilePath;
        List<string> blockedIps;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hostsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\drivers\etc\hosts";
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            resetHosts();
        }
        /*
         * Blocco Avanzato
         */
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = browseFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxDirectory.Text = browseFolder.SelectedPath;
            }
        }

        private void checkBoxAvanzateEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAvanzateEnabled.Checked)
            {
                textBoxDirectory.Enabled = true;
                buttonBrowse.Enabled = true;
            }
            else
            {
                textBoxDirectory.Enabled = false;
                buttonBrowse.Enabled = false;
            }
        }

        /*
         * Bottone Blocca Chat
         */
        private void buttonChat_Click(object sender, EventArgs e)
        {
            string statusText = "Status: ";
            if (stoppingChat)
            {
                stoppingChat = false;
                labelStatus.ForeColor = Color.DarkGreen;
                labelStatus.Text = statusText + "Online";
                buttonChat.Text = "Blocca Chat";
                resetHosts();
            }
            else
            {
                if (checkBoxAvanzateEnabled.Checked)
                {
                    if (textBoxDirectory.Text.Equals(""))
                    {
                        MessageBox.Show("Directory vuota");
                        return;
                    }
                    else if (!textBoxDirectory.Text.Contains(":"))
                    {
                        MessageBox.Show("Directory errata");
                        return;
                    }
                    blockedIps = new List<string>();
                    try
                    {
                        foreach (string ip in Directory.GetFiles(textBoxDirectory.Text, "lol.properties", SearchOption.AllDirectories))
                        {
                            using (StreamReader reader = new StreamReader(ip))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    if (line.StartsWith("xmpp_server_url"))
                                    {
                                        blockedIps.Add(line.Substring(16));
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Directory errata");
                        return;
                    }
                }
                else
                {
                    blockedIps = new List<string>(new string[] { "chat.euw1.lol.riotgames.com", "chat.na2.lol.riotgames.com" });
                }
                writeNewHosts();
                stoppingChat = true;
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = statusText + "Offline";
                buttonChat.Text = "Sblocca Chat";
            }
        }

        /*
         * Readers/Writers Hosts file
         */
        private void writeNewHosts()
        {
            using (StreamWriter writer = File.AppendText(hostsFilePath))
            {
                foreach (string newline in blockedIps)
                {
                    writer.WriteLine("127.0.0.1 " + newline);
                }
            }
        }
        private void resetHosts()
        {
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader(hostsFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (new Regex(".*chat.*.riotgames.com").IsMatch(line) == false)
                    {
                        list.Add(line);
                    }
                }
            }
            File.Delete(hostsFilePath);
            using (StreamWriter writer = new StreamWriter(hostsFilePath, true))
            {
                foreach (string newline in list)
                {
                    writer.WriteLine(newline);
                }
            }
        }

        private void creditsADP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.inforge.net/xi/members/alessiodp.164069/");
        }

        private void creditsInforge_Click(object sender, EventArgs e)
        {
            Process.Start("http://inforge.net/");
        }
    }
}
