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
    public partial class frmInputTransIn : Form
    {
        public delegate void CreateUpdateEventHandler(Transin tin);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi objek controller
        private TransinController controll;
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek mahasiswa
        private Transin tin;
        public frmInputTransIn()
        {
            InitializeComponent();
        }

        public frmInputTransIn(string title, TransinController controller)
      : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controll = controller;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public frmInputTransIn(string title, Transin obj, TransinController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controll = controller;
            isNewData = false; // set status edit data
            tin = obj; // set objek mhs yang akan diedit
                           // untuk edit data, tampilkan data lama
            txtIdTransIn.Enabled= false;
            txtIdTransIn.Text = Convert.ToString(tin.id_in);
            txtIdBo.Text = Convert.ToString(tin.id_bo);
            txtIdSupp.Text = Convert.ToString(tin.id_splr);
            txtIDBrg.Text = Convert.ToString(tin.id_brg);
            txtJmlBeli.Text = Convert.ToString(tin.jml_beli);
            txtTtlBeli.Text = Convert.ToString(tin.ttl_beli);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) tin = new Transin();
            // set nilai property objek mahasiswa yg diambil dari TextBox
            tin.id_in = Convert.ToInt32(txtIdTransIn.Text);
            tin.id_bo = Convert.ToInt32(txtIdBo.Text);
            tin.id_splr = Convert.ToInt32(txtIdSupp.Text);
            tin.id_brg = Convert.ToInt32(txtIDBrg.Text);
            tin.tgl_beli = DateTime.Now;
            tin.jml_beli = Convert.ToInt32(txtJmlBeli.Text);
            tin.ttl_beli = Convert.ToInt32(txtTtlBeli.Text);
            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controll.CreateTransin(tin);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate(tin); // panggil event OnCreate
                                       // reset form input, utk persiapan input data berikutnya
                    txtIdTransIn.Clear();
                    txtIdBo.Clear();
                    txtTtlBeli.Clear();
                    txtIdSupp.Clear();
                    txtJmlBeli.Clear();
                    txtIDBrg.Clear(); 
                    txtJmlBeli.Clear() ;
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controll.UpdateTransin(tin);
                if (result > 0)
                {
                    OnUpdate(tin); // panggil event OnUpdate
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTransIN form1 = new frmTransIN();
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

        private void btnUpStck_Click(object sender, EventArgs e)
        {
            frmUpStock from7 = new frmUpStock();
            from7.Show();
            Visible = false;
        }

        private void btnBrgKeluar_Click(object sender, EventArgs e)
        {
            frmTransOUT form8 = new frmTransOUT();
            form8.Show();
            Visible = false;
        }

        private void frmInputTransIn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
