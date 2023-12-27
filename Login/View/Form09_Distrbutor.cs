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
    public partial class frmDataDistri : Form
    {
        private List<distributor> distributors = new List<distributor>();
        private DistributorController controller;
        public frmDataDistri()
        {
            InitializeComponent();
            controller = new DistributorController();
            InisialisasiListView();
            LoadDataDistributor(false);
        }

        private void InisialisasiListView()
        {
            lvwDataDis.View = View.Details;
            lvwDataDis.FullRowSelect = true;
            lvwDataDis.GridLines = true;

            lvwDataDis.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwDataDis.Columns.Add("ID Distributor", 100, HorizontalAlignment.Center);
            lvwDataDis.Columns.Add("Nama Distributor", 200, HorizontalAlignment.Center);
            lvwDataDis.Columns.Add("Informasi Pembayaran", 300, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataDistributor(bool isSearch, List<distributor> ListDistri=null)
        {
            // kosongkan listview
            lvwDataDis.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            if(isSearch == true)
            {
                distributors = ListDistri;
            }
            else
            {
                distributors = controller.ReadAll();
            }
            //distributors = controller.ReadAll();
            // ekstrak objek mhs dari collection
            foreach (var distri in distributors)
            {
                var noUrut = lvwDataDis.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(Convert.ToString(distri.id_distributor));
                item.SubItems.Add(distri.nama_distributor);
                item.SubItems.Add(distri.inf_bayar);
                // tampilkan data mhs ke listview
                lvwDataDis.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(distributor distri)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            distributors.Add(distri);
            int noUrut = lvwDataDis.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(Convert.ToString(distri.id_distributor));
            item.SubItems.Add(distri.nama_distributor);
            item.SubItems.Add(distri.inf_bayar);
            lvwDataDis.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(distributor distri)
        {
            // ambil index data mhs yang edit
            int index = lvwDataDis.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = lvwDataDis.Items[index];
            itemRow.SubItems[1].Text = Convert.ToString(distri.id_distributor);
            itemRow.SubItems[2].Text = distri.nama_distributor;
            itemRow.SubItems[3].Text = distri.inf_bayar;
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void btnSupp_Click(object sender, EventArgs e)
        {
            frmSupplier form6 = new frmSupplier();
            form6.Show();
            Visible = false;
        }

        private void btnTambahDis_Click(object sender, EventArgs e)
        {

            frmInputDistri form7 = new frmInputDistri("Tambah Data Distributor", controller);
            form7.OnCreate += OnCreateEventHandler;
            form7.Show();
            Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwDataDis.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                distributor distri = distributors[lvwDataDis.SelectedIndices[0]];
                // buat objek form entry data mahasiswa
                frmInputDistri form8 = new frmInputDistri("Edit Data Distributor", distri, controller);
                // mendaftarkan method event handler untuk merespon event OnUpdate
                form8.OnUpdate += OnUpdateEventHandler;
                // tampilkan form entry mahasiswa
                form8.Show();
                Visible = false;
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
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

        private void frmDataDistri_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength != 0)
            {
                distributors = controller.ReadByNama(txtSearch.Text);
                if (distributors.Count > 0)
                {
                    LoadDataDistributor(true, distributors);
                }
                else
                {
                    MessageBox.Show("Search GAGAL, 404 Not Found !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                LoadDataDistributor(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwDataDis.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data distributor ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    distributor distri = distributors[lvwDataDis.SelectedIndices[0]];
                    // panggil operasi CRUD
                    var result = controller.DeleteDistributor(distri);
                    if (result > 0) 
                        LoadDataDistributor(false);
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data distributor belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
