using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public bool startMinimized = false;

        String AppName = "ShowMyIPInTray";

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(startMinimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                WindowState = FormWindowState.Minimized;
            }

            fillList();

            notifyIcon1.BalloonTipText = "ShowMyIP Minimized.";
            notifyIcon1.BalloonTipTitle = "ShowMyIP";

            RegistryKey rk = Registry.CurrentUser.OpenSubKey
    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            
            if(rk.GetValue(AppName,null)!=null)
            {
                chkStartUp.Tag = "changing";
                chkStartUp.Checked = true;
            }

        }

        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (chkStartUp.Checked)
                rk.SetValue(AppName, Application.ExecutablePath.ToString() + " -min");
            else
                rk.DeleteValue(AppName, false);

        }

        private void buttonCopytoClipboard_Click(object sender, EventArgs e)
        {
            listIP lp = (listIP) listboxIPs.SelectedItem;
            if (lp == null) return;
            Clipboard.SetText(lp.ip);
        }

        private class listIP
        {
            public String ip { get; set; }
            public String NicName { get; set; }

            public override string ToString()
            {
                return this.NicName + " : " + ip;
            }
        }

        private void fillList()
        {
            listboxIPs.Items.Clear();

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            if(ni.OperationalStatus != OperationalStatus.Up && !checkboxShowInActive.Checked)
                            {
                                continue;
                            }

                            listIP lp = new listIP();
                            lp.ip = ip.Address.ToString();
                            lp.NicName = ni.Name;

                            listboxIPs.Items.Add(lp);
                            
                        }
                    }
                }
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            fillList();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void chkStartUp_CheckedChanged(object sender, EventArgs e)
        {
            if(chkStartUp.Tag!=null && chkStartUp.Tag.Equals("changing"))
            {
                chkStartUp.Tag = null;
                return;
            }

            SetStartup();
        }
    }
}
