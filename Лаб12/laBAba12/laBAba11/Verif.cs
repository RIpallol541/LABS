using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laBAba11
{
    public partial class Verif : Form
    {
        public Verif()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Admin") && (textBox2.Text == "admin") )
            {
                IDADD f= new IDADD();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Данные не верны");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Easy f = new Easy();
            this.Hide();
            f.Show();
        }
    }
}
