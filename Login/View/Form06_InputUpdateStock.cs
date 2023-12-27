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
using System.Globalization;

namespace Login
{
    public partial class frmInputUpStock : Form
    {
        public delegate void CreateUpdateEventHandler(Updatestock upstock);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi objek controller
        private UpdatestockController controll;
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek mahasiswa
        private Updatestock upstock;
        public frmInputUpStock()
        {
            InitializeComponent();
        }

        public frmInputUpStock(string title, UpdatestockController controller)
       : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controll = controller;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public frmInputUpStock(string title, Updatestock obj, UpdatestockController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controll = controller;
            isNewData = false; // set status edit data
            upstock = obj; // set objek mhs yang akan diedit
                       // untuk edit data, tampilkan data lama
            txtIdBrg.Enabled = false;
            txtIdStock.Enabled = false;
            txtIdStock.Text = Convert.ToString(upstock.id_upstock);
            //DateTime tgl = upstock.tgl_update;
            //txtTglBeli.Text = string.Concat(upstock.tgl_update);
            txtJmlUp.Text = Convert.ToString(upstock.jml_update);
            txtIdBrg.Text = Convert.ToString(upstock.id_brg);
        }

        private void txtIdStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTglBeli_TextChanged(object sender, EventArgs e)
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

        private void btnUpStck_Click(object sender, EventArgs e)
        {
            frmUpStock form3 = new frmUpStock();
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

        private void btnBack_Click(object sender, EventArgs e)
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

        private void frmInputUpStock_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) upstock = new Updatestock();
            // set nilai property objek mahasiswa yg diambil dari TextBox
            upstock.id_upstock = Convert.ToInt32(txtIdStock.Text);
            // var date = DateTime.Parse(txtTglBeli.Text);
            /*DateTime.ParseExact(txtTglBeli.Text);
            DateTime date = Convert.ToDateTime(txtTglBeli.Text).Date;*/
            // IFormatProvider provider = new CultureInfo("fr-FR");
            upstock.tgl_update = DateTime.Now; 
            upstock.jml_update = Convert.ToInt32(txtJmlUp.Text);
            upstock.id_brg = Convert.ToInt32(txtIdBrg.Text);
            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controll.CreateUpstock(upstock);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate(upstock); // panggil event OnCreate
                                   // reset form input, utk persiapan input data berikutnya
                    txtIdBrg.Clear();
                    txtIdStock.Clear();
                    txtJmlUp.Clear();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controll.UpdateUpstock(upstock);
                if (result > 0)
                {
                    OnUpdate(upstock); // panggil event OnUpdate
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
