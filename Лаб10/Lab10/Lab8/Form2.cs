using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            string s = main.textBox1.Text;
            RequestOutput requestOutput = new RequestOutput();
            dataGridView1.DataSource = requestOutput.request(s).Tables[0];
           
        }
    }
}
