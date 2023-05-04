using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using NLog.Internal;

namespace Lab8
{
    public partial class Form1 : Form
    {
        
        public OleDbConnection Connection = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
          

        }
        public Form1(string text)
        {
            InitializeComponent();
            textBox1.Text = text;
        }

        

        public void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();

        }
    }
}
