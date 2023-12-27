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
    public class TransinController
    {
        private TransinRepository _repository;

        public int CreateTransin(Transin tin)
        {
            int result = 0;
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_in)))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tin.tgl_beli)))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tin.jml_beli)))
            {
                MessageBox.Show("Jumlah Beli harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.ttl_beli)))
            {
                MessageBox.Show("Total Beli harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_brg)))
            {
                MessageBox.Show("ID Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_splr)))
            {
                MessageBox.Show("ID Supplier harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_bo)))
            {
                MessageBox.Show("ID Back Office harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransinRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.CreateTransin(tin);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Transaksi berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Transaksi Barang gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int UpdateTransin(Transin tin)
        {
            int result = 0;
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_in)))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tin.tgl_beli)))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tin.jml_beli)))
            {
                MessageBox.Show("Jumlah Beli harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.ttl_beli)))
            {
                MessageBox.Show("Total Beli harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_brg)))
            {
                MessageBox.Show("ID Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_splr)))
            {
                MessageBox.Show("ID Supplier harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_bo)))
            {
                MessageBox.Show("ID Back Office harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransinRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.UpdateTransin(tin);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Transaksi berhasil disimpan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Transaksi Barang gagal disimpan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int DeleteTransin(Transin tin)
        {
            int result = 0;
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_in)))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tin.tgl_beli)))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tin.jml_beli)))
            {
                MessageBox.Show("Jumlah Beli harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.ttl_beli)))
            {
                MessageBox.Show("Total Beli harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_brg)))
            {
                MessageBox.Show("ID Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_splr)))
            {
                MessageBox.Show("ID Supplier harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tin.id_bo)))
            {
                MessageBox.Show("ID Back Office harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransinRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.DeleteTransin(tin);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Transaksi berhasil dihapus !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Transaksi Barang gagal dihapus !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public List<Transin> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Transin> list = new List<Transin>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransinRepository(context);
                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }
            return list;
        }
        public List<Transin> ReadAll()
        {
            // membuat objek collection
            List<Transin> list = new List<Transin>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransinRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }
    }
}
