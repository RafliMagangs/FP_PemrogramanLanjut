using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Login.Model.Context;
using Login.Model.Entity;
using System.Windows.Forms;

namespace Login.Model.Repository
{
    public class LoginRepository
    {
        private MySqlConnection _conn;
        public LoginRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int login(string username, string password)
        {
            int result = 0;
            BackOffice bo = new BackOffice();
            string sql = @"select * from backoffice where usn_bo = @username and pass_bo = @password limit 1";
            using(MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                  if(reader.Read())
                    {
                        bo.Id = Convert.ToInt32(reader["id_bo"]);
                        bo.Username = reader["usn_bo"].ToString();
                        bo.Password = reader["pass_bo"].ToString();
                        result = 1;
                    }
                }
            }
            return result;

        }
    }
}
