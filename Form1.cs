using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCrypt_Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(textBox1.Text);
            textBox2.Text = hash;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                label3.Text = "Type Something";
                label3.ForeColor = Color.Red;
                textBox2.Text = (String.Empty);
            }
            else
            {
                label3.Text = "Sucessfully Hash";
                label3.ForeColor = Color.Green;
            }
        }

        [STAThread]
        private void button2_Click(object sender, EventArgs e)
        {
           if (String.IsNullOrEmpty(textBox1.Text))
            {
                label3.Text = "Can't copy, type something in text";
                label3.ForeColor = Color.Orange;
            }
           else
            {
                Clipboard.SetText(textBox2.Text);
            }
        }
    }
}
