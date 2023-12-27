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
using Org.BouncyCastle.Utilities.IO;
using System.IO;

namespace Login
{
    public partial class frmInputSup : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Supplier supp);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi objek controller
        private SupplierController controller;
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek mahasiswa
        private Supplier supp;
        public frmInputSup()
        {
            InitializeComponent();
        }
        public frmInputSup(string title, SupplierController controller)
       : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public frmInputSup(string title, Supplier obj, SupplierController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
            isNewData = false; // set status edit data
            supp = obj; // set objek mhs yang akan diedit
                          // untuk edit data, tampilkan data lama
            txtIdSup.Enabled= false;
            txtIdSup.Text = Convert.ToString(supp.id_splr);
            txtNamaSup.Text = supp.nama_splr;
            txtInfPem.Text = supp.inf_pembayar;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda Ingin Keluar?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                frmLogin form1 = new frmLogin();
                form1.Show();
                Visible = false;
            }
        }

        private void btsDashboard_Click(object sender, EventArgs e)
        {
            frmHome form2 = new frmHome();
            form2.Show();
            Visible = false;
        }

        private void btnDataBarang_Click(object sender, EventArgs e)
        {
            frmDataBrg form3 = new frmDataBrg();
            form3.Show();
            Visible = false;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier form4 = new frmSupplier();
            form4.Show();
            Visible = false;
        }

        private void btnUpStck_Click(object sender, EventArgs e)
        {
            frmUpStock form5 = new frmUpStock();
            form5.Show();
            Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void frmInputSup_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "PDF files (*.pdf)|*.pdf|Word File (*.docx)|*.docx|Excel File (*.xlsx)|*.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtInfPem.Text = System.IO.Path.GetFileName(dlg.FileName);
            }
            else
            {
                MessageBox.Show("File harus pdf/docx/xlsx !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) supp = new Supplier();
            // set nilai property objek mahasiswa yg diambil dari TextBox
            supp.id_splr = Convert.ToInt32(txtIdSup.Text);
            supp.nama_splr = txtNamaSup.Text;
            supp.inf_pembayar = txtInfPem.Text;
            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.CreateSupplier(supp);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate(supp); // panggil event OnCreate
                                      // reset form input, utk persiapan input data berikutnya
                    txtIdSup.Clear();
                    txtNamaSup.Clear();
                    txtInfPem.Clear();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.UpdateSupplier(supp);
                if (result > 0)
                {
                    OnUpdate(supp); // panggil event OnUpdate
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
