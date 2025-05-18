using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            txtURL.Text = "http://";
        }

       
        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                url = "http://" + url;
            }

            try
            {
               
                string html = GetHTML(url);
                rtbHTML.Text = html;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trang:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private string GetHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            using (WebResponse response = request.GetResponse())
            using (Stream dataStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(dataStream))
            {
                return reader.ReadToEnd();
            }
        }

        
        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rtbHTML_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
