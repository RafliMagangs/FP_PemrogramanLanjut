using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Login.Model.Context;
using Login.Model.Entity;
using System.Data.SQLite;
using System.Security.Policy;

namespace Login.Model.Repository
{
    public class DistributorRepository
    {
        private MySqlConnection _conn;
        public DistributorRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int CreateDistributor(distributor distri)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"insert into distributor (id_distributor, nama_distributor, inf_bayar)
            values (@id_distributor, @nama_distributor, @inf_bayar)";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_distributor", distri.id_distributor);
                cmd.Parameters.AddWithValue("@nama_distributor", distri.nama_distributor);
                cmd.Parameters.AddWithValue("@inf_bayar", distri.inf_bayar);
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

        public int UpdateDistributor(distributor distri)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"update distributor set nama_distributor = @nama_distributor, inf_bayar = @inf_bayar where id_distributor = @id_distributor";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_distributor", distri.id_distributor);
                cmd.Parameters.AddWithValue("@nama_distributor", distri.nama_distributor);
                cmd.Parameters.AddWithValue("@inf_bayar", distri.inf_bayar);
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

        public int DeleteDistributor(distributor distri)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"delete from distributor where id_distributor = @id_distributor";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_distributor", distri.id_distributor);
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

        public List<distributor> ReadAll()
        {
            // membuat objek collection untuk menampung objek distributor
            List<distributor> list = new List<distributor>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_distributor, nama_distributor, inf_bayar from distributor order by id_distributor";
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
                            distributor distri = new distributor();
                            distri.id_distributor = Convert.ToInt32(dtr["id_distributor"]);
                            distri.nama_distributor = dtr["nama_distributor"].ToString();
                            distri.inf_bayar = dtr["inf_bayar"].ToString();
                            // tambahkan objek distributor ke dalam collection
                            list.Add(distri);
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

        public List<distributor> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek distributor
            List<distributor> list = new List<distributor>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_distributor, nama_distributor, inf_bayar from distributor where nama_distributor like @nama order by nama_distributor";
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
                            distributor distri = new distributor();
                            distri.id_distributor = Convert.ToInt32(dtr["id_distributor"]);
                            distri.nama_distributor = dtr["nama_distributor"].ToString();
                            distri.inf_bayar = dtr["inf_bayar"].ToString();
                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(distri);
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
