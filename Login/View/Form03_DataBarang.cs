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
    public partial class frmDataBrg : Form
    {
        private List<Barang> barangs = new List<Barang>();
        private BarangController controller;
       
        public frmDataBrg()
        {
            InitializeComponent();
            controller = new BarangController();
            InisialisasiListView();
            LoadDataBarang(false);
           
        }

        private void InisialisasiListView()
        {
            lvwDataBrg.View = View.Details;
            lvwDataBrg.FullRowSelect = true;
            lvwDataBrg.GridLines = true;

            lvwDataBrg.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("ID Barang", 100, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("Nama Barang", 160, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("Kategori", 100, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("Stok Awal", 90, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("Harga Jual", 100, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("Harga Beli", 100, HorizontalAlignment.Center);
        }

        private void LoadDataBarang(bool isSearch, List<Barang> Listbrg = null)
        {
            // kosongkan listview
            lvwDataBrg.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            if (isSearch == true)
            {
                barangs = Listbrg;
            }
            else
            {
                barangs = controller.ReadAll();
            }
            //distributors = controller.ReadAll();
            // ekstrak objek mhs dari collection
            foreach (var brg in barangs)
            {
                var noUrut = lvwDataBrg.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(Convert.ToString(brg.id_brg));
                item.SubItems.Add(brg.nama_brg);
                item.SubItems.Add(brg.kategori_brg);
                item.SubItems.Add(Convert.ToString(brg.stock_awal));
                item.SubItems.Add(Convert.ToString(brg.hrg_jual));
                item.SubItems.Add(Convert.ToString(brg.hrg_beli));
                // tampilkan data mhs ke listview
                lvwDataBrg.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Barang brg)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            barangs.Add(brg);
            int noUrut = lvwDataBrg.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(Convert.ToString(brg.id_brg));
            item.SubItems.Add(brg.nama_brg);
            item.SubItems.Add(brg.kategori_brg);
            item.SubItems.Add(Convert.ToString(brg.stock_awal));
            item.SubItems.Add(Convert.ToString(brg.hrg_jual));
            item.SubItems.Add(Convert.ToString(brg.hrg_beli));
            lvwDataBrg.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Barang brg)
        {
            // ambil index data mhs yang edit
            int index = lvwDataBrg.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = lvwDataBrg.Items[index];
            itemRow.SubItems[1].Text = Convert.ToString(brg.id_brg);
            itemRow.SubItems[2].Text = brg.nama_brg;
            itemRow.SubItems[3].Text = brg.kategori_brg;
            itemRow.SubItems[4].Text = Convert.ToString(brg.stock_awal);
            itemRow.SubItems[7].Text = Convert.ToString(brg.hrg_jual);
            itemRow.SubItems[8].Text = Convert.ToString(brg.hrg_beli);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            Visible = false;
        }

        private void lvwDataBrg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btsDashboard_Click(object sender, EventArgs e)
        {
            frmHome form2 = new frmHome();
            form2.Show();
            Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDataBrg_Load(object sender, EventArgs e)
        {

        }

        private void btnTambahBrg_Click(object sender, EventArgs e)
        {
            frmInputDataBrg form3 = new frmInputDataBrg("Tambah Data Barang", controller);
            form3.OnCreate += OnCreateEventHandler;
            form3.Show();
            Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwDataBrg.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Barang brg = barangs[lvwDataBrg.SelectedIndices[0]];
                frmInputDataBrg form4 = new frmInputDataBrg("Edit Data Barang", brg, controller);
                form4.OnUpdate += OnUpdateEventHandler;
                form4.Show();
                Visible = false;
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnDataBarang_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda Ingin Keluar?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                frmLogin form1 = new frmLogin();
                form1.Show();
                Visible = false;
            }
        }

        private void btsDashboard_Click_1(object sender, EventArgs e)
        {
            frmHome form2 = new frmHome();
            form2.Show();
            Visible = false;
        }

        private void btnUpStck_Click(object sender, EventArgs e)
        {
            frmUpStock form3 = new frmUpStock();
            form3.Show();
            Visible = false;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier form4 = new frmSupplier();
            form4.Show();
            Visible = false;
        }

        private void btnBrgMasuk_Click(object sender, EventArgs e)
        {
            frmTransIN form5 = new frmTransIN();
            form5.Show();
            Visible = false;
        }

        private void btnBrgKeluar_Click(object sender, EventArgs e)
        {
            frmTransOUT form6 = new frmTransOUT();
            form6.Show();
            Visible = false;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSearch.TextLength != 0)
            {
                barangs = controller.ReadByNama(txtSearch.Text);
                if (barangs.Count > 0)
                {
                    LoadDataBarang(true, barangs);
                }
                else
                {
                    MessageBox.Show("Search GAGAL, 404 Not Found !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                LoadDataBarang(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwDataBrg.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data barang ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Barang brg = barangs[lvwDataBrg.SelectedIndices[0]];
                    // panggil operasi CRUD
                    var result = controller.DeleteBarang(brg);
                    if (result > 0)
                        LoadDataBarang(false);
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data barang belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
