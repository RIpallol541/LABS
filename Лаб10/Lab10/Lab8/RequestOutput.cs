using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{

    internal class RequestOutput
    {
        private OleDbConnection Connection = null;
        
        public DataSet request(string req)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;data source=" + System.IO.Path.Combine(Application.StartupPath, openFileDialog1.FileName.ToString());
            OleDbConnection conn = new OleDbConnection(connectionString);
            Connection = new OleDbConnection(connectionString);
            Connection.Open();
            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(req, Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Connection.Close();
                return ds;
            }
            catch (Exception )
            {
                DataSet ds = new DataSet();
                DataTable customers = ds.Tables.Add("Error");
                customers.Columns.Add("Error");
                customers.Rows.Add("Запрос не корректен");
                conn.Close();
                return ds;
            }
            
        }
           
    }
}
