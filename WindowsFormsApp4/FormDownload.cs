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
namespace WindowsFormsApp4
{
    public partial class FormDownload : Form
    {
        public FormDownload()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            string filePath = textBox2.Text;

            try
            {
                using (WebClient myClient = new WebClient())
                {
                    // Tải file HTML về máy
                    myClient.DownloadFile(url, filePath);

                    // Đọc nội dung đã lưu vào file
                    string content = File.ReadAllText(filePath);

                    // Hiển thị nội dung vào richTextBox
                    richTextBox1.Text = content;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
