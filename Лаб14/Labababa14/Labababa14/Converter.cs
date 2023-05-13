using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labababa14
{
    

    public partial class Converter : Form
    {
        private OleDbConnection Connection = null;
        public Converter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ripal\\Desktop\\Бдшечка.mdb";
            OleDbConnection conn = new OleDbConnection(connectionString);
            Connection = new OleDbConnection(connectionString);
            Connection.Open();
            string req = "SELECT * FROM Адреса";
            string req1 = "SELECT * FROM [Мемориальные доски]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(req, Connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            string xmlData = ds.GetXml();
            OleDbDataAdapter adapter1 = new OleDbDataAdapter(req1, Connection);
            adapter1.Fill(ds);
            xmlData += ds.GetXml();
            textBox1.Text = xmlData;
            //MessageBox.Show(xmlData);
        }
    }
}
