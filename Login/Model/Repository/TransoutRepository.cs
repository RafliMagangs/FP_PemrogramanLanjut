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
    public class TransoutRepository
    {
        private MySqlConnection _conn;
        public TransoutRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int CreateTransout(Transout tout)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"insert into transout (id_out, tgl_jual, jml_jual, ttl_jual, id_brg, id_distributor, id_bo)
            values (@id_out, @tgl_jual, @jml_jual, @ttl_jual, @id_brg, @id_distributor, @id_bo)";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_out", tout.id_out);
                cmd.Parameters.AddWithValue("@tgl_jual", tout.tgl_jual);
                cmd.Parameters.AddWithValue("@jml_jual", tout.jml_jual);
                cmd.Parameters.AddWithValue("@ttl_jual", tout.ttl_jual);
                cmd.Parameters.AddWithValue("@id_brg", tout.id_brg);
                cmd.Parameters.AddWithValue("@id_distributor", tout.id_distributor);
                cmd.Parameters.AddWithValue("@id_bo", tout.id_bo);
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

        public int UpdateTransout(Transout tout)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"update transout set tgl_jual=@tgl_jual, jml_jual=@jml_jual, ttl_jual=@ttl_jual, id_brg=@id_brg, 
                         id_distributor=@id_distributor, id_bo=@id_bo where id_out=@id_out";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_out", tout.id_out);
                cmd.Parameters.AddWithValue("@tgl_jual", tout.tgl_jual);
                cmd.Parameters.AddWithValue("@jml_jual", tout.jml_jual);
                cmd.Parameters.AddWithValue("@ttl_jual", tout.ttl_jual);
                cmd.Parameters.AddWithValue("@id_brg", tout.id_brg);
                cmd.Parameters.AddWithValue("@id_distributor", tout.id_distributor);
                cmd.Parameters.AddWithValue("@id_bo", tout.id_bo);
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

        public int DeleteTransout(Transout tout)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"delete from transout where id_out=@id_out";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_out", tout.id_out);
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

        public List<Transout> ReadAll()
        {
            // membuat objek collection untuk menampung objek Barang
            List<Transout> list = new List<Transout>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_out, tgl_jual, jml_jual, ttl_jual, hrg_jual, id_brg, nama_brg, id_distributor, nama_distributor, id_bo, usn_bo
                               from transout inner join barang using(id_brg) 
                               inner join distributor using(id_distributor)
                               inner join backoffice using (id_bo) order by id_out";
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
                            Transout tout = new Transout();
                            tout.id_out = Convert.ToInt32(dtr["id_out"]);
                            tout.tgl_jual = (DateTime)dtr["tgl_jual"];
                            tout.jml_jual = Convert.ToInt32(dtr["jml_jual"]);
                            tout.ttl_jual = Convert.ToInt32(dtr["ttl_jual"]);
                            tout.hrg_jual = Convert.ToInt32(dtr["hrg_jual"]);
                            tout.id_brg = Convert.ToInt32(dtr["id_brg"]);
                            tout.nama_brg = dtr["nama_brg"].ToString();
                            tout.id_distributor = Convert.ToInt32(dtr["id_distributor"]);
                            tout.nama_distributor = dtr["nama_distributor"].ToString();
                            tout.id_bo = Convert.ToInt32(dtr["id_bo"]);
                            tout.username = dtr["usn_bo"].ToString();
                            // tambahkan objek distributor ke dalam collection
                            list.Add(tout);
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

        public List<Transout> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek Barang
            List<Transout> list = new List<Transout>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_out, tgl_jual, jml_jual, ttl_jual, hrg_jual, id_brg, nama_brg, id_distributor, nama_distributor, id_bo, usn_bo
                               from transout inner join barang using(id_brg) 
                               inner join distributor using(id_distributor)
                               inner join backoffice using (id_bo) where id_out like @nama order by id_out";
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
                            Transout tout = new Transout();
                            tout.id_out = Convert.ToInt32(dtr["id_out"]);
                            tout.tgl_jual = (DateTime)dtr["tgl_jual"];
                            tout.jml_jual = Convert.ToInt32(dtr["jml_jual"]);
                            tout.ttl_jual = Convert.ToInt32(dtr["ttl_jual"]);
                            tout.hrg_jual = Convert.ToInt32(dtr["hrg_jual"]);
                            tout.id_brg = Convert.ToInt32(dtr["id_brg"]);
                            tout.nama_brg = dtr["nama_brg"].ToString();
                            tout.id_distributor = Convert.ToInt32(dtr["id_distributor"]);
                            tout.nama_distributor = dtr["nama_distributor"].ToString();
                            tout.id_bo = Convert.ToInt32(dtr["id_bo"]);
                            tout.username = dtr["usn_bo"].ToString();
                            // tambahkan objek distributor ke dalam collection
                            list.Add(tout);
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
