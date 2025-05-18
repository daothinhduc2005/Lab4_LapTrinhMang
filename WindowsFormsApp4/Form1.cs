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
            // Khởi tạo URL mặc định khi load form
            txtURL.Text = "http://";
        }

        // Khi người dùng nhấn nút GET
        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu chưa có http:// hoặc https:// thì thêm vào
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                url = "http://" + url;
            }

            try
            {
                // Lấy HTML và hiển thị lên RichTextBox
                string html = GetHTML(url);
                rtbHTML.Text = html;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trang:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm gọi WebRequest/WebResponse để đọc về HTML
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

        // (Nếu bạn có cần xử lý khi người dùng sửa TextBox hoặc RichTextBox,
        // có thể để nguyên hoặc xoá 2 handler sau)
        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            // Không cần làm gì thêm
        }

        private void rtbHTML_TextChanged(object sender, EventArgs e)
        {
            // Không cần làm gì thêm
        }
    }
}
