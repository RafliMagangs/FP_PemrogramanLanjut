using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Login.Model.Repository;
using Login.Model.Context;
using Login.Model.Entity;

namespace Login.Controller
{
    public class HomeController
    {
        private HomeRepository _repository;

        public string Count_Barang()
        {
            string result;

            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new HomeRepository(context);
                result = _repository.CountBarang();
            }

            return result;
        }

        public string Count_Supplier()
        {
            string result;

            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new HomeRepository(context);
                result = _repository.CountSupplier();
            }

            return result;
        }

        public string Count_Distri()
        {
            string result;

            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new HomeRepository(context);
                result = _repository.CountDistri();
            }

            return result;
        }

        public string Count_Transin()
        {
            string result;

            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new HomeRepository(context);
                result = _repository.CountTransIn();
            }

            return result;
        }

        public string Count_Transout()
        {
            string result;

            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new HomeRepository(context);
                result = _repository.CountTransOut();
            }

            return result;
        }
    }
}
