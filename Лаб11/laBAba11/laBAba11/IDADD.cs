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
using System.Configuration;
using System.Security.Cryptography;

namespace laBAba11
{
    public partial class IDADD : Form
    {
        public IDADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ripal\\source\\repos\\laBAba11\\laBAba11\\Mem.mdf;Integrated Security=True");
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Memor (ID, Достопремечательность,Фото, Открытие,Местоположение,Описание) values (@ID, @Достопремечательность,@Фото, @Открытие ,@Местоположение,@Описание)");
            cmd.Connection = Con;
            try
            {
                cmd.Parameters.AddWithValue("ID", textBox7.Text);
                cmd.Parameters.AddWithValue("Достопремечательность", textBox1.Text);
                cmd.Parameters.AddWithValue("Фото", textBox2.Text);
                cmd.Parameters.AddWithValue("Открытие", textBox3.Text);
                cmd.Parameters.AddWithValue("Местоположение", textBox4.Text);
                cmd.Parameters.AddWithValue("Описание", textBox5.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Memor", Con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте Данные");
            }


        }

        private void IDADD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "memDataSet.Memor". При необходимости она может быть перемещена или удалена.
            this.memorTableAdapter.Fill(this.memDataSet.Memor);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ripal\\source\\repos\\laBAba11\\laBAba11\\Mem.mdf;Integrated Security=True");
            Con.Open();
            String res = "DELETE FROM Memor WHERE ID =" + textBox6.Text;
            SqlCommand cmd = new SqlCommand(res);
            cmd.Connection = Con;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Memor", Con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

		private void button3_Click(object sender, EventArgs e)
		{
			SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ripal\\source\\repos\\laBAba11\\laBAba11\\Mem.mdf;Integrated Security=True");
			Con.Open();
			SqlCommand cmd = new SqlCommand("UPDATE Memor SET Достопремечательность = " + textBox1.Text + "WHERE ID =" + textBox7.Text);
			SqlCommand cmd1 = new SqlCommand("UPDATE Memor SET Фото = " + textBox1.Text + "WHERE ID =" + textBox7.Text);
			SqlCommand cmd2 = new SqlCommand("UPDATE Memor SET Открытие = " + textBox1.Text + "WHERE ID =" + textBox7.Text);
			SqlCommand cmd3 = new SqlCommand("UPDATE Memor SET Местоположение = " + textBox1.Text + "WHERE ID =" + textBox7.Text);
			SqlCommand cmd4 = new SqlCommand("UPDATE Memor SET Описание = " + textBox1.Text + "WHERE ID =" + textBox7.Text);
            cmd.Connection = Con;
			cmd1.Connection = Con;
			cmd2.Connection = Con;
			cmd3.Connection = Con;
			cmd4.Connection = Con;
			cmd.ExecuteNonQuery();
			cmd1.ExecuteNonQuery();
			cmd2.ExecuteNonQuery();
			cmd3.ExecuteNonQuery();
			cmd4.ExecuteNonQuery();
			SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Memor", Con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}
	}
}