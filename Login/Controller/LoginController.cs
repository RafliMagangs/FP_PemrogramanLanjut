using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Login.Model.Repository;
using Login.Model.Context;
using System.Runtime.Remoting.Contexts;
using MySqlX.XDevAPI.Common;
using Login.Model.Entity;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Login.Controller
{
    public class LoginController
    {
        private LoginRepository _repository;
        public int Login_bo(string username, string password)
        {
            int result = 0;
            
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new LoginRepository(context);
                result = _repository.login(username, password);
            }
            
            return result;
        }
    }
}
