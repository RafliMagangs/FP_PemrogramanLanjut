using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Model.Entity;
using Login.Controller;

namespace Login
{
    public partial class frmInputDataBrg : Form
    {
        public delegate void CreateUpdateEventHandler(Barang brg);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi objek controller
        private BarangController controll;
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek mahasiswa
        private Barang brg;
        public frmInputDataBrg()
        {
            InitializeComponent();
        }
        public frmInputDataBrg(string title, BarangController controller)
       : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controll = controller;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public frmInputDataBrg(string title, Barang obj, BarangController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controll = controller;
            isNewData = false; // set status edit data
            brg = obj; // set objek mhs yang akan diedit
                       // untuk edit data, tampilkan data lama
            txtIdBrg.Enabled= false;
            txtIdBrg.Text = Convert.ToString(brg.id_brg);
            txtNamaBrg.Text = brg.nama_brg;
            txtKategori.Text= brg.kategori_brg;
            txtStok.Text = Convert.ToString(brg.stock_awal);
            txtHrgJual.Text = Convert.ToString(brg.hrg_jual);
            txtHrgBeli.Text = Convert.ToString(brg.hrg_beli);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btsDashboard_Click(object sender, EventArgs e)
        {
            frmHome form1 = new frmHome();
            form1.Show();
            Visible = false;
        }

        private void btnDataBarang_Click(object sender, EventArgs e)
        {
            frmDataBrg form2 = new frmDataBrg();
            form2.Show();
            Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDataBrg form3 = new frmDataBrg();
            form3.Show();
            Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda Ingin Keluar?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                frmLogin form4 = new frmLogin();
                form4.Show();
                Visible = false;
            }
        }

        private void frmInputDataBrg_Load(object sender, EventArgs e)
        {

        }

        private void btnUpStck_Click(object sender, EventArgs e)
        {
            frmUpStock form5 = new frmUpStock();
            form5.Show();
            Visible = false;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier form6 = new frmSupplier();
            form6.Show();
            Visible = false;
        }

        private void btnBrgMasuk_Click(object sender, EventArgs e)
        {
            frmTransIN form7 = new frmTransIN();
            form7.Show();
            Visible = false;
        }

        private void btnBrgKeluar_Click(object sender, EventArgs e)
        {
            frmTransOUT form8 = new frmTransOUT();
            form8.Show();
            Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) brg = new Barang();
            // set nilai property objek mahasiswa yg diambil dari TextBox
            brg.id_brg = Convert.ToInt32(txtIdBrg.Text);
            brg.nama_brg = txtNamaBrg.Text;
            brg.kategori_brg = txtKategori.Text;
            brg.stock_awal = Convert.ToInt32(txtStok.Text);
            brg.hrg_jual = Convert.ToInt32(txtHrgJual.Text);
            brg.hrg_beli = Convert.ToInt32(txtHrgBeli.Text);
            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controll.CreateBarang(brg);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate(brg); // panggil event OnCreate
                                      // reset form input, utk persiapan input data berikutnya
                    txtIdBrg.Clear();
                    txtNamaBrg.Clear();
                    txtKategori.Clear();
                    txtStok.Clear();
                    txtHrgJual.Clear();
                    txtHrgBeli.Clear();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controll.UpdateBarang(brg);
                if (result > 0)
                {
                    OnUpdate(brg); // panggil event OnUpdate
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
