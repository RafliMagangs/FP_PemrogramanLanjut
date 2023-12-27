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
    public partial class frmInputTransOut : Form
    {
        public delegate void CreateUpdateEventHandler(Transout tout);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi objek controller
        private TransoutController controll;
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek mahasiswa
        private Transout tout;
        public frmInputTransOut()
        {
            InitializeComponent();
        }

        public frmInputTransOut(string title, TransoutController controller)
     : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controll = controller;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public frmInputTransOut(string title, Transout obj, TransoutController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controll = controller;
            isNewData = false; // set status edit data
            tout = obj; // set objek mhs yang akan diedit
                       // untuk edit data, tampilkan data lama
            txtIdTransOut.Enabled = false;
            txtIdTransOut.Text = Convert.ToString(tout.id_out);
            txtIdBo.Text = Convert.ToString(tout.id_bo);
            txtIdDistri.Text = Convert.ToString(tout.id_distributor);
            txtIDBrg.Text = Convert.ToString(tout.id_brg);
            txtJmlJual.Text = Convert.ToString(tout.jml_jual);
            txtTotalJual.Text = Convert.ToString(tout.ttl_jual);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTransOUT form1 = new frmTransOUT();
            form1.Show();
            Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda Ingin Keluar?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                frmLogin form2 = new frmLogin();
                form2.Show();
                Visible = false;
            }
        }

        private void btsDashboard_Click(object sender, EventArgs e)
        {
            frmHome form3 = new frmHome();
            form3.Show();
            Visible = false;
        }

        private void btnDataBarang_Click(object sender, EventArgs e)
        {
            frmDataBrg form4 = new frmDataBrg();
            form4.Show();
            Visible = false;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier form5 = new frmSupplier();
            form5.Show();
            Visible = false;
        }

        private void btnBrgMasuk_Click(object sender, EventArgs e)
        {
            frmTransIN form6 = new frmTransIN();
            form6.Show();
            Visible = false;
        }

        private void btnBrgKeluar_Click(object sender, EventArgs e)
        {
            frmTransOUT form7 = new frmTransOUT();
            form7.Show();
            Visible = false;
        }

        private void btnUpStck_Click(object sender, EventArgs e)
        {
            frmUpStock form8 = new frmUpStock();
            form8.Show();
            Visible = false;
        }

        private void txtIdBo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) tout = new Transout();
            // set nilai property objek mahasiswa yg diambil dari TextBox
            tout.id_out = Convert.ToInt32(txtIdTransOut.Text);
            tout.id_bo = Convert.ToInt32(txtIdBo.Text);
            tout.id_distributor = Convert.ToInt32(txtIdDistri.Text);
            tout.id_brg = Convert.ToInt32(txtIDBrg.Text);
            tout.tgl_jual = DateTime.Now;
            tout.jml_jual = Convert.ToInt32(txtJmlJual.Text);
            tout.ttl_jual = Convert.ToInt32(txtTotalJual.Text);
            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controll.CreateTransout(tout);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate(tout); // panggil event OnCreate
                                   // reset form input, utk persiapan input data berikutnya
                   txtIdTransOut.Clear();
                   txtIdBo.Clear();
                   txtIdDistri.Clear();
                   txtIDBrg.Clear();
                   txtJmlJual.Clear();
                   txtJmlJual.Clear();
                   txtTotalJual.Clear();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controll.UpdateTransout(tout);
                if (result > 0)
                {
                    OnUpdate(tout); // panggil event OnUpdate
                }
            }
        }
    }
}
