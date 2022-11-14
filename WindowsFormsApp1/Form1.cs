using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int counter = 0;

            if (counter % 2 == 0 & textBox1.Text == "Marco")
            {
                counter += 1;
            }
            else if (counter % 2 != 0 & textBox1.Text == "Polo")
            {
                counter += 1;
            }
        }
    }
}
