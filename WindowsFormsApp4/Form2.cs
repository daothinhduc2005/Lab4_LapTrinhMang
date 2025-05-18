// File: Form2.cs
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();
            string postData = txtData.Text.Trim();
            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(postData))
            {
                MessageBox.Show("Vui lòng nhập URL và dữ liệu POST!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                byte[] data = Encoding.UTF8.GetBytes(postData);
                request.ContentLength = data.Length;

                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                }

                using (WebResponse response = request.GetResponse())
                using (Stream resStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(resStream))
                {
                    string result = reader.ReadToEnd();
                    rtbHTML.Text = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi POST:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
