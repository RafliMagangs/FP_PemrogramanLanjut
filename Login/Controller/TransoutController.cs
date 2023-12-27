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
    public class TransoutController
    {
        private TransoutRepository _repository;

        public int CreateTransout(Transout tout)
        {
            int result = 0;
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_out)))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tout.tgl_jual)))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tout.jml_jual)))
            {
                MessageBox.Show("Jumlah jual harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.ttl_jual)))
            {
                MessageBox.Show("Total jual harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_brg)))
            {
                MessageBox.Show("ID Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_distributor)))
            {
                MessageBox.Show("ID Distributor harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_bo)))
            {
                MessageBox.Show("ID Back Office harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransoutRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.CreateTransout(tout);
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

        public int UpdateTransout(Transout tout)
        {
            int result = 0;
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_out)))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tout.tgl_jual)))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tout.jml_jual)))
            {
                MessageBox.Show("Jumlah jual harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.ttl_jual)))
            {
                MessageBox.Show("Total jual harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_brg)))
            {
                MessageBox.Show("ID Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_distributor)))
            {
                MessageBox.Show("ID Distributor harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_bo)))
            {
                MessageBox.Show("ID Back Office harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransoutRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.UpdateTransout(tout);
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

        public int DeleteTransout(Transout tout)
        {
            int result = 0;
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_out)))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tout.tgl_jual)))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(tout.jml_jual)))
            {
                MessageBox.Show("Jumlah jual harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.ttl_jual)))
            {
                MessageBox.Show("Total jual harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_brg)))
            {
                MessageBox.Show("ID Barang harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_distributor)))
            {
                MessageBox.Show("ID Distributor harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(Convert.ToString(tout.id_bo)))
            {
                MessageBox.Show("ID Back Office harus diisi !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransoutRepository(context);
                // panggil method Create class repository untuk menambahkan data
                result = _repository.DeleteTransout(tout);
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

        public List<Transout> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Transout> list = new List<Transout>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransoutRepository(context);
                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }
            return list;
        }
        public List<Transout> ReadAll()
        {
            // membuat objek collection
            List<Transout> list = new List<Transout>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransoutRepository(context);
                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }
    }
}
