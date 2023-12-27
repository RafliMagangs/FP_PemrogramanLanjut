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
    public class TransinRepository
    {
        private MySqlConnection _conn;
        public TransinRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int CreateTransin(Transin tin)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"insert into transin (id_in, tgl_beli, jml_beli, ttl_beli, id_brg, id_splr, id_bo)
            values (@id_in, @tgl_beli, @jml_beli, @ttl_beli, @id_brg, @id_splr, @id_bo)";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_in", tin.id_in);
                cmd.Parameters.AddWithValue("@tgl_beli", tin.tgl_beli);
                cmd.Parameters.AddWithValue("@jml_beli", tin.jml_beli);
                cmd.Parameters.AddWithValue("@ttl_beli", tin.ttl_beli);
                cmd.Parameters.AddWithValue("@id_brg", tin.id_brg);
                cmd.Parameters.AddWithValue("@id_splr", tin.id_splr);
                cmd.Parameters.AddWithValue("@id_bo", tin.id_bo);
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

        public int UpdateTransin(Transin tin)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"update transin set tgl_beli=@tgl_beli, jml_beli=@jml_beli, ttl_beli=@ttl_beli, id_brg=@id_brg, id_splr=@id_splr, id_bo=@id_bo where id_in=@id_in";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_in", tin.id_in);
                cmd.Parameters.AddWithValue("@tgl_beli", tin.tgl_beli);
                cmd.Parameters.AddWithValue("@jml_beli", tin.jml_beli);
                cmd.Parameters.AddWithValue("@ttl_beli", tin.ttl_beli);
                cmd.Parameters.AddWithValue("@id_brg", tin.id_brg);
                cmd.Parameters.AddWithValue("@id_splr", tin.id_splr);
                cmd.Parameters.AddWithValue("@id_bo", tin.id_bo);
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

        public int DeleteTransin(Transin tin)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"delete from transin where id_in=@id_in";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_in", tin.id_in);
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

        public List<Transin> ReadAll()
        {
            // membuat objek collection untuk menampung objek Barang
            List<Transin> list = new List<Transin>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_in, tgl_beli, jml_beli, ttl_beli, hrg_beli, id_brg, nama_brg, id_splr, nama_splr, id_bo, usn_bo
                               from transin inner join barang using(id_brg) 
                               inner join supplier using(id_splr)
                               inner join backoffice using (id_bo) order by id_in";
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
                            Transin tin = new Transin();
                            tin.id_in = Convert.ToInt32(dtr["id_in"]);
                            tin.tgl_beli = (DateTime)dtr["tgl_beli"];
                            tin.jml_beli = Convert.ToInt32(dtr["jml_beli"]);
                            tin.ttl_beli = Convert.ToInt32(dtr["ttl_beli"]);
                            tin.hrg_beli = Convert.ToInt32(dtr["hrg_beli"]);
                            tin.id_brg = Convert.ToInt32(dtr["id_brg"]);
                            tin.nama_brg = dtr["nama_brg"].ToString();
                            tin.id_splr = Convert.ToInt32(dtr["id_splr"]);
                            tin.nama_splr = dtr["nama_splr"].ToString();
                            tin.id_bo = Convert.ToInt32(dtr["id_bo"]);
                            tin.username= dtr["usn_bo"].ToString();
                            // tambahkan objek distributor ke dalam collection
                            list.Add(tin);
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

        public List<Transin> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek Barang
            List<Transin> list = new List<Transin>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_in, tgl_beli, jml_beli, ttl_beli, hrg_beli, id_brg, nama_brg, id_splr, nama_splr, id_bo, usn_bo
                               from transin inner join barang using(id_brg) 
                               inner join supplier using(id_splr)
                               inner join backoffice using (id_bo) where id_in like @nama order by id_in";
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
                            Transin tin = new Transin();
                            tin.id_in = Convert.ToInt32(dtr["id_in"]);
                            tin.tgl_beli = (DateTime)dtr["tgl_beli"];
                            tin.jml_beli = Convert.ToInt32(dtr["jml_beli"]);
                            tin.ttl_beli = Convert.ToInt32(dtr["ttl_beli"]);
                            tin.hrg_beli = Convert.ToInt32(dtr["hrg_beli"]);
                            tin.id_brg = Convert.ToInt32(dtr["id_brg"]);
                            tin.nama_brg = dtr["nama_brg"].ToString();
                            tin.id_splr = Convert.ToInt32(dtr["id_splr"]);
                            tin.nama_splr = dtr["nama_splr"].ToString();
                            tin.id_bo = Convert.ToInt32(dtr["id_bo"]);
                            tin.username = dtr["usn_bo"].ToString();
                            // tambahkan objek distributor ke dalam collection
                            list.Add(tin);
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
