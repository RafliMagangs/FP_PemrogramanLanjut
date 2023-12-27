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
    public partial class frmSupplier : Form
    {
        private List<Supplier> suppliers = new List<Supplier>();
        private SupplierController controller;
        public frmSupplier()
        {
            InitializeComponent();
            controller= new SupplierController();
            InisialisasiListView();
            LoadDataSupplier(false);
        }

        private void InisialisasiListView()
        {
            lvwDataSup.View = View.Details;
            lvwDataSup.FullRowSelect = true;
            lvwDataSup.GridLines = true;

            lvwDataSup.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwDataSup.Columns.Add("ID Supplier", 100, HorizontalAlignment.Center);
            lvwDataSup.Columns.Add("Nama Supplier", 200, HorizontalAlignment.Center);
            lvwDataSup.Columns.Add("Informasi Pembayaran", 300, HorizontalAlignment.Center);
        }

        private void LoadDataSupplier(bool isSearch, List<Supplier> ListSupp = null)
        {
            // kosongkan listview
            lvwDataSup.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            if (isSearch == true)
            {
                suppliers = ListSupp;
            }
            else
            {
                suppliers = controller.ReadAll();
            }
            //distributors = controller.ReadAll();
            // ekstrak objek mhs dari collection
            foreach (var supp in suppliers)
            {
                var noUrut = lvwDataSup.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(Convert.ToString(supp.id_splr));
                item.SubItems.Add(supp.nama_splr);
                item.SubItems.Add(supp.inf_pembayar);
                // tampilkan data mhs ke listview
                lvwDataSup.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Supplier supp)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            suppliers.Add(supp);
            int noUrut = lvwDataSup.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(Convert.ToString(supp.id_splr));
            item.SubItems.Add(supp.nama_splr);
            item.SubItems.Add(supp.inf_pembayar);
            lvwDataSup.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Supplier supp)
        {
            // ambil index data mhs yang edit
            int index = lvwDataSup.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = lvwDataSup.Items[index];
            itemRow.SubItems[1].Text = Convert.ToString(supp.id_splr);
            itemRow.SubItems[2].Text = supp.nama_splr;
            itemRow.SubItems[3].Text = supp.inf_pembayar;
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

        private void btnUpStck_Click(object sender, EventArgs e)
        {
            frmUpStock form4 = new frmUpStock();
            form4.Show();
            Visible = false;
        }

        private void lvwDataSup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTambahSup_Click(object sender, EventArgs e)
        {
            frmInputSup form5  = new frmInputSup("Tambah Data Supplier", controller);
            form5.OnCreate += OnCreateEventHandler;
            form5.Show();
            Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwDataSup.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Supplier supp = suppliers[lvwDataSup.SelectedIndices[0]];
                // buat objek form entry data mahasiswa
                frmInputSup form6 = new frmInputSup("Edit Data Supplier", supp, controller);
                form6.OnUpdate += OnUpdateEventHandler;
                form6.Show();
                Visible = false;
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnDistri_Click(object sender, EventArgs e)
        {
            frmDataDistri form7 = new frmDataDistri();
            form7.Show();
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

        private void frmSupplier_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength != 0)
            {
                suppliers = controller.ReadByNama(txtSearch.Text);
                if (suppliers.Count > 0)
                {
                    LoadDataSupplier(true, suppliers);
                }
                else
                {
                    MessageBox.Show("Search GAGAL, 404 Not Found !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                LoadDataSupplier(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwDataSup.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data Supplier ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Supplier supp = suppliers[lvwDataSup.SelectedIndices[0]];
                    // panggil operasi CRUD
                    var result = controller.DeleteSupplier(supp);
                    if (result > 0)
                        LoadDataSupplier(false);
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Supplier belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
