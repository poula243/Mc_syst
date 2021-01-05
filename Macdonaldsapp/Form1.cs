using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macdonaldsapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = "example";
            int password = 123;

            String username = textBox_username.Text;
            int pass = int.Parse(textBox_password.Text);

            if (textBox_username.Text == null && textBox_password.Text == null)
                label_massage.Visible = true;

            else if (username == name && pass == password)
            {
                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();
            }
            else
                label_massage.Visible = true;
        }
    }
}
