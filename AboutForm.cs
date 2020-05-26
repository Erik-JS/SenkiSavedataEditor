using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenkiSavedataEditor
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            lblVersion.Text += v.ToString();
            DateTime dt = new DateTime(2000, 1, 1).AddDays(v.Build).AddSeconds(v.Revision * 2);
            lblDate.Text = dt.ToString("yyyy.MM.dd HH:mm:ss");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

    }
}
