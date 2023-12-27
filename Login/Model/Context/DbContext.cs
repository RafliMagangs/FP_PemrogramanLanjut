using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Login.Model.Context
{
    public class DbContext : IDisposable
    {
        private MySqlConnection _conn;
        public MySqlConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }
        private MySqlConnection GetOpenConnection()
        {
            MySqlConnection conn = null;
            try
            {
                string anjayKoneksi = "server=127.0.0.1;uid=root;pwd=;database=dbgudangyudha";
                conn = new MySqlConnection(anjayKoneksi);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}; Error Number : {1}", ex.Message, ex.Number);
            }
            return conn;
        }
        // Method ini digunakan untuk menghapus objek koneksi dari memory ketikasudah tidak digunakan
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }
    }
}

