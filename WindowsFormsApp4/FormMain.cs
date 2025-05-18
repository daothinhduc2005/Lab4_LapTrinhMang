using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPost f = new FormPost();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDownload f = new FormDownload();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBrowser f = new FormBrowser();
            f.Show();
        }
    }

}
