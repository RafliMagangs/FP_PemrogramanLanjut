using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Login.Model.Entity;
using Login.Controller;

namespace Login
{
    public partial class frmInputDistri : Form
    {
        //private List<distributor> distributors = new List<distributor>();
        //private InputDistributorController controller;

        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(distributor distri);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi objek controller
        private DistributorController controller;
        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        // deklarasi field untuk meyimpan objek mahasiswa
        private distributor distri;
        public frmInputDistri()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public frmInputDistri(string title, DistributorController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public frmInputDistri(string title, distributor obj, DistributorController controller)
        : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
            isNewData = false; // set status edit data
            distri = obj; // set objek mhs yang akan diedit
                       // untuk edit data, tampilkan data lama
            txtIdDis.Enabled= false;
            txtIdDis.Text = Convert.ToString(distri.id_distributor);
            txtNamaDis.Text = distri.nama_distributor;
            txtInfPem.Text = distri.inf_bayar;
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
            frmDataDistri form6 = new frmDataDistri();
            form6.Show();
            Visible = false;
        }

        private void btnBrgMasuk_Click(object sender, EventArgs e)
        {
            frmTransIN form7 =  new frmTransIN();
            form7.Show();
            Visible = false;
        }

        private void btnBrgKeluar_Click(object sender, EventArgs e)
        {
            frmTransOUT form8 = new frmTransOUT();
            form8.Show();
            Visible = false;
        }

        private void frmInputDistri_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) distri = new distributor();
            // set nilai property objek mahasiswa yg diambil dari TextBox
            distri.id_distributor = Convert.ToInt32(txtIdDis.Text);
            distri.nama_distributor = txtNamaDis.Text;
            distri.inf_bayar = txtInfPem.Text;
            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.CreateDistributor(distri);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate(distri); // panggil event OnCreate
                                   // reset form input, utk persiapan input data berikutnya
                    txtIdDis.Clear();
                    txtNamaDis.Clear();
                    txtInfPem.Clear();
                    txtIdDis.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.UpdateDistributor(distri);
                if (result > 0)
                {
                    OnUpdate(distri); // panggil event OnUpdate
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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
    }
}
