using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Login.Model.Repository;
using Login.Model.Context;
using Login.Model.Entity;
using System.Windows.Forms;

namespace Login.Controller
{
    public class UpdatestockController
    {
        private UpdatestockRepository _repository;
        public int CreateUpstock(Updatestock upstock)
        {
            int result = 0;
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(upstock.id_upstock)))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(upstock.tgl_update)))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(upstock.jml_update)))
            {
                MessageBox.Show("Jumlah Update harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(upstock.id_brg)))
            {
                MessageBox.Show("ID Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new UpdatestockRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.CreateUpstock(upstock);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Update Barang berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Update Barang gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int UpdateUpstock(Updatestock upstock)
        {
            int result = 0;
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(upstock.id_upstock)))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(upstock.tgl_update)))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(upstock.jml_update)))
            {
                MessageBox.Show("Jumlah Update harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(upstock.id_brg)))
            {
                MessageBox.Show("ID Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new UpdatestockRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.UpdateUpstock(upstock);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Update Barang berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Update Barang gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int DeleteUpstock(Updatestock upstock)
        {
            int result = 0;
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(upstock.id_upstock)))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(upstock.tgl_update)))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(upstock.jml_update)))
            {
                MessageBox.Show("Jumlah Update harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(upstock.id_brg)))
            {
                MessageBox.Show("ID Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new UpdatestockRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.DeleteUpstock(upstock);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Update Barang berhasil dihapus !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Update Barang gagal dihapus !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public List<Updatestock> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Updatestock> list = new List<Updatestock>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new UpdatestockRepository(context);
                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }
            return list;
        }
        public List<Updatestock> ReadAll()
        {
            // membuat objek collection
            List<Updatestock> list = new List<Updatestock>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new UpdatestockRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }
    }
}
