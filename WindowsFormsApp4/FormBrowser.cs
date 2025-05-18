using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace WindowsFormsApp4
{
    public partial class FormBrowser : Form
    {
        public FormBrowser()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            SetIEVersion(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string url = textBox1.Text;
                string html = client.DownloadString(url);
                string filePath = "D:\\downloaded_page.html";
                File.WriteAllText(filePath, html);
                MessageBox.Show("Đã lưu HTML vào: " + filePath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string url = textBox1.Text;
                string html = client.DownloadString(url);
                richTextBox1.Text = html;
            }
        }
        private void SetIEVersion()
        {
            try
            {
                string appName = System.IO.Path.GetFileName(Application.ExecutablePath);
                RegistryKey key = Registry.CurrentUser.CreateSubKey(
                    @"Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION");
                key.SetValue(appName, 11000, RegistryValueKind.DWord); // 11000 = IE11
                key.Close();
            }
            catch { }
        }
        private void FormBrowser_Load(object sender, EventArgs e)
        {
            SetIEVersion();
        }
    }
}
