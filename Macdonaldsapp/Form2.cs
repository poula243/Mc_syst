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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        private void pictureBox1_sandw_Click(object sender, EventArgs e)
        {
            Form3_Sandwiches f = new Form3_Sandwiches();
            f.ShowDialog(); 
        }

        private void pictureBox2_meals_Click(object sender, EventArgs e)
        {
            Form4_Meals f = new Form4_Meals();
           
            f.ShowDialog();
        }

        private void pictureBox3_dessert_Click(object sender, EventArgs e)
        {
            Form5_Dessert f = new Form5_Dessert();
          
            f.ShowDialog();
        }

        private void pictureBox4_drinks_Click(object sender, EventArgs e)
        {
            Form6_Drinks f = new Form6_Drinks();
            f.ShowDialog();
        }
    }
}
