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
    public partial class Form3_Sandwiches : Form
    {
        public Form3_Sandwiches()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();

        }
    }
}
