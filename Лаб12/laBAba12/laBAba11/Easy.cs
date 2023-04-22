using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laBAba11
{
    public partial class Easy : Form
    {
        public Easy()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ripal\\source\\repos\\laBAba11\\laBAba11\\Mem.mdf;Integrated Security=True");
            Con.Open();
            String res = textBox8.Text;
            SqlCommand cmd = new SqlCommand(res);
            cmd.Connection = Con;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Memor", Con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Easy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "memDataSet.Memor". При необходимости она может быть перемещена или удалена.
            this.memorTableAdapter.Fill(this.memDataSet.Memor);

        }
    }
}
