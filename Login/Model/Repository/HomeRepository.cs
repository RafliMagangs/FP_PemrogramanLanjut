using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Login.Model.Context;
using Login.Model.Entity;

namespace Login.Model.Repository
{
    public class HomeRepository
    {
        private MySqlConnection _conn;
        public HomeRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public string CountBarang()
        {
            //string result;
            // deklarasi perintah SQL
            string sql = "select count(id_brg) from barang";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                /* cmd.CommandText = sql;
                 result = Convert.ToInt32(sql);*/
                var resultBrg = cmd.ExecuteScalar().ToString();
                return resultBrg;
            }
        }

        public string CountSupplier()
        {
            //string result;
            // deklarasi perintah SQL
            string sql = "select count(id_splr) from supplier";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                /* cmd.CommandText = sql;
                 result = Convert.ToInt32(sql);*/
                var resultSup = cmd.ExecuteScalar().ToString();
                return resultSup;
            }
        }

        public string CountDistri()
        {
            //string result;
            // deklarasi perintah SQL
            string sql = "select count(id_distributor) from distributor";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
               /* cmd.CommandText = sql;
                result = Convert.ToInt32(sql);*/
                var result = cmd.ExecuteScalar().ToString();
                return result;
            }
        }

        public string CountTransIn()
        {
            //string result;
            // deklarasi perintah SQL
            string sql = "select count(id_in) from transin";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                /* cmd.CommandText = sql;
                 result = Convert.ToInt32(sql);*/
                var resultIn = cmd.ExecuteScalar().ToString();
                return resultIn;
            }
        }

        public string CountTransOut()
        {
            //string result;
            // deklarasi perintah SQL
            string sql = "select count(id_out) from transout";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                /* cmd.CommandText = sql;
                 result = Convert.ToInt32(sql);*/
                var resultout = cmd.ExecuteScalar().ToString();
                return resultout;
            }
        }
    }
}
