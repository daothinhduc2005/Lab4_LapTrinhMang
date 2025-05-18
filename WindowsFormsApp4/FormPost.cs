using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class FormPost : Form
    {
        public FormPost()
        {
            InitializeComponent();
            this.Text = "Bài 2 - POST dữ liệu";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập URL.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu để gửi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string url = textBox1.Text;
                string postData = richTextBox1.Text;
                byte[] dataBytes = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = comboBox1.SelectedItem?.ToString() ?? "application/x-www-form-urlencoded";
                request.ContentLength = dataBytes.Length;

                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(dataBytes, 0, dataBytes.Length);
                }

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string responseText = reader.ReadToEnd();
                    richTextBox2.Text = responseText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
