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
    public class SupplierRepository
    {
        private MySqlConnection _conn;
        public SupplierRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int CreateSupplier(Supplier supp)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"insert into supplier (id_splr, nama_splr, inf_pembayar)
            values (@id_splr, @nama_splr, @inf_pembayar)";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_splr", supp.id_splr);
                cmd.Parameters.AddWithValue("@nama_splr", supp.nama_splr);
                cmd.Parameters.AddWithValue("@inf_pembayar", supp.inf_pembayar);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int UpdateSupplier(Supplier supp)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"update supplier set nama_splr=@nama_splr, inf_pembayar=@inf_pembayar where id_splr=@id_splr";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_splr", supp.id_splr);
                cmd.Parameters.AddWithValue("@nama_splr", supp.nama_splr);
                cmd.Parameters.AddWithValue("@inf_pembayar", supp.inf_pembayar);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int DeleteSupplier(Supplier supp)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"delete from supplier where id_splr=@id_splr";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_splr", supp.id_splr);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Supplier> ReadAll()
        {
            // membuat objek collection untuk menampung objek Supplier
            List<Supplier> list = new List<Supplier>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_splr, nama_splr, inf_pembayar from supplier order by id_splr";
                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari resultset
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Supplier supp = new Supplier();
                            supp.id_splr = Convert.ToInt32(dtr["id_splr"]);
                            supp.nama_splr = dtr["nama_splr"].ToString();
                            supp.inf_pembayar = dtr["inf_pembayar"].ToString();
                            // tambahkan objek distributor ke dalam collection
                            list.Add(supp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }

        public List<Supplier> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek Supplier
            List<Supplier> list = new List<Supplier>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_splr, nama_splr, inf_pembayar from supplier where nama_splr like @nama order by nama_splr";
                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama", string.Format("%{0}%", nama));
                    // membuat objek dtr (data reader) untuk menampung result set(hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari resultset
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Supplier supp = new Supplier();
                            supp.id_splr = Convert.ToInt32(dtr["id_splr"]);
                            supp.nama_splr = dtr["nama_splr"].ToString();
                            supp.inf_pembayar = dtr["inf_pembayar"].ToString();
                            // tambahkan objek distributor ke dalam collection
                            list.Add(supp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}",
                ex.Message);
            }
            return list;
        }
    }
}
