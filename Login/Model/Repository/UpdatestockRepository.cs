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
    public class UpdatestockRepository
    {
        private MySqlConnection _conn;
        public UpdatestockRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int CreateUpstock(Updatestock upstock)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"insert into updatestock (id_upstock, tgl_update, jml_update, id_brg)
            values (@id_upstock, @tgl_update, @jml_update, @id_brg)";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_upstock", upstock.id_upstock);
                cmd.Parameters.AddWithValue("@tgl_update", upstock.tgl_update);
                cmd.Parameters.AddWithValue("@jml_update", upstock.jml_update);
                cmd.Parameters.AddWithValue("@id_brg", upstock.id_brg);
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

        public int UpdateUpstock(Updatestock upstock)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"update updatestock set tgl_update=@tgl_update, jml_update=@jml_update, id_brg=@id_brg where id_upstock=@id_upstock";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_upstock", upstock.id_upstock);
                cmd.Parameters.AddWithValue("@tgl_update", upstock.tgl_update);
                cmd.Parameters.AddWithValue("@jml_update", upstock.jml_update);
                cmd.Parameters.AddWithValue("@id_brg", upstock.id_brg);
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

        public int DeleteUpstock(Updatestock upstock)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"delete from updatestock where id_upstock=@id_upstock";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_upstock", upstock.id_upstock);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Updatestock> ReadAll()
        {
            // membuat objek collection untuk menampung objek Barang
            List<Updatestock> list = new List<Updatestock>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_upstock, tgl_update, jml_update, id_brg, nama_brg from updatestock
                               inner join barang using(id_brg) order by id_upstock";
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
                            Updatestock upstock = new Updatestock();
                            upstock.id_upstock = Convert.ToInt32(dtr["id_upstock"]);
                            upstock.tgl_update = (DateTime)dtr["tgl_update"];
                            upstock.jml_update = Convert.ToInt32(dtr["jml_update"]);
                            upstock.id_brg = Convert.ToInt32(dtr["id_brg"]);
                            upstock.nama_brg = dtr["nama_brg"].ToString();
                            // tambahkan objek distributor ke dalam collection
                            list.Add(upstock);
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

        public List<Updatestock> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek Barang
            List<Updatestock> list = new List<Updatestock>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_upstock, tgl_update, jml_update, id_brg, nama_brg from updatestock
                               inner join barang using(id_brg) where id_upstock like @nama order by id_upstock";
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
                            Updatestock upstock = new Updatestock();
                            upstock.id_upstock = Convert.ToInt32(dtr["id_upstock"]);
                            upstock.tgl_update = (DateTime)dtr["tgl_update"];
                            upstock.jml_update = Convert.ToInt32(dtr["jml_update"]);
                            upstock.id_brg = Convert.ToInt32(dtr["id_brg"]);
                            upstock.nama_brg = dtr["nama_brg"].ToString();
                            // tambahkan objek distributor ke dalam collection
                            list.Add(upstock);
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
