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
    public class BarangRepository
    {
        private MySqlConnection _conn;
        public BarangRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int CreateBarang(Barang brg)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"insert into barang (id_brg, nama_brg, kategori_brg, stock_awal, hrg_jual, hrg_beli)
            values (@id_brg, @nama_brg, @kategori_brg, @stock_awal, @hrg_jual, @hrg_beli)";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_brg", brg.id_brg);
                cmd.Parameters.AddWithValue("@nama_brg", brg.nama_brg);
                cmd.Parameters.AddWithValue("@kategori_brg", brg.kategori_brg);
                cmd.Parameters.AddWithValue("@stock_awal", brg.stock_awal);
                cmd.Parameters.AddWithValue("@hrg_jual", brg.hrg_jual);
                cmd.Parameters.AddWithValue("@hrg_beli", brg.hrg_beli);
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

        public int UpdateBarang(Barang brg)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"update barang set nama_brg=@nama_brg, kategori_brg=@kategori_brg, 
                        stock_awal= @stock_awal, hrg_jual=@hrg_jual, hrg_beli=@hrg_beli where id_brg= @id_brg";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_brg", brg.id_brg);
                cmd.Parameters.AddWithValue("@nama_brg", brg.nama_brg);
                cmd.Parameters.AddWithValue("@kategori_brg", brg.kategori_brg);
                cmd.Parameters.AddWithValue("@stock_awal", brg.stock_awal);
                cmd.Parameters.AddWithValue("@hrg_jual", brg.hrg_jual);
                cmd.Parameters.AddWithValue("@hrg_beli", brg.hrg_beli);
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

        public int DeleteBarang(Barang brg)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"delete from barang where id_brg= @id_brg";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_brg", brg.id_brg);
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

        public List<Barang> ReadAll()
        {
            // membuat objek collection untuk menampung objek Barang
            List<Barang> list = new List<Barang>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_brg, nama_brg, kategori_brg, stock_awal, hrg_jual, hrg_beli from barang order by id_brg";
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
                            Barang brg = new Barang();
                            brg.id_brg = Convert.ToInt32(dtr["id_brg"]);
                            brg.nama_brg = dtr["nama_brg"].ToString();
                            brg.kategori_brg = dtr["kategori_brg"].ToString();
                            brg.stock_awal = Convert.ToInt32(dtr["stock_awal"]);
                            brg.hrg_jual = Convert.ToInt32(dtr["hrg_jual"]);
                            brg.hrg_beli = Convert.ToInt32(dtr["hrg_beli"]);
                            // tambahkan objek distributor ke dalam collection
                            list.Add(brg);
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

        public List<Barang> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek Barang
            List<Barang> list = new List<Barang>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_brg, nama_brg, kategori_brg, stock_awal, hrg_jual, hrg_beli from barang 
                               where nama_brg like @nama order by nama_brg";
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
                            Barang brg = new Barang();
                            brg.id_brg = Convert.ToInt32(dtr["id_brg"]);
                            brg.nama_brg = dtr["nama_brg"].ToString();
                            brg.kategori_brg = dtr["kategori_brg"].ToString();
                            brg.stock_awal = Convert.ToInt32(dtr["stock_awal"]);
                            brg.hrg_jual = Convert.ToInt32(dtr["hrg_jual"]);
                            brg.hrg_beli = Convert.ToInt32(dtr["hrg_beli"]);
                            // tambahkan objek distributor ke dalam collection
                            list.Add(brg);
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
