using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {   
        private OleDbConnection Connection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["myBd"].ConnectionString);
            Connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(
                "SELECT [Мемориальные доски].Код, [Мемориальные доски].Достопремечательность\r\nFROM [Мемориальные доски];", Connection
                );
            DataSet ds = new DataSet();
            adapter.Fill( ds );
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(
                "SELECT Адреса.Код, Адреса.[Описание адреса(Район)]\r\nFROM Адреса;", Connection
                );
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(
                "SELECT [Мемориальные доски].Код, [Мемориальные доски].Достопремечательность, [Мемориальные доски].Год\r\nFROM [Мемориальные доски]\r\nWHERE ((([Мемориальные доски].Год)>1999))\r\nORDER BY [Мемориальные доски].Код;\r\n", Connection
                );
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(
                "TRANSFORM Min(Адреса.[Год постройки]) AS [Min-Год постройки1]\r\nSELECT Адреса.Код, Адреса.Месторасположение, Адреса.[Описание адреса(Район)], Адреса.[Год постройки]\r\nFROM Адреса\r\nGROUP BY Адреса.Код, Адреса.Месторасположение, Адреса.[Описание адреса(Район)], Адреса.[Год постройки]\r\nORDER BY Адреса.[Год постройки]\r\nPIVOT Адреса.[На чём можно добраться];\r\n", Connection
                );
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(
                "TRANSFORM Min([Мемориальные доски].Год) AS [Min-Год]\r\nSELECT [Мемориальные доски].Код, [Мемориальные доски].Достопремечательность, [Мемориальные доски].Год\r\nFROM [Мемориальные доски]\r\nGROUP BY [Мемориальные доски].Код, [Мемориальные доски].Достопремечательность, [Мемориальные доски].Год\r\nPIVOT [Мемориальные доски].Код;\r\n", Connection
                );
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
