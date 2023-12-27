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
    public partial class frmUpStock : Form
    {
        private List<Updatestock> updatestocks= new List<Updatestock>();
        private UpdatestockController controller;
        public frmUpStock()
        {
            InitializeComponent();
            controller = new UpdatestockController();
            InisialisasiListView();
            LoadDataBarang(false);
        }

        private void InisialisasiListView()
        {
            lvwDataBrg.View = View.Details;
            lvwDataBrg.FullRowSelect = true;
            lvwDataBrg.GridLines = true;

            lvwDataBrg.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("ID UpStock", 90, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("Tanggal Update", 150, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("Jumlah Update", 100, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("ID Barang", 90, HorizontalAlignment.Center);
            lvwDataBrg.Columns.Add("Nama Barang", 200, HorizontalAlignment.Center);
        }

        private void LoadDataBarang(bool isSearch, List<Updatestock> Listups = null)
        {
            // kosongkan listview
            lvwDataBrg.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            if (isSearch == true)
            {
                updatestocks = Listups;
            }
            else
            {
                updatestocks = controller.ReadAll();
            }
            //distributors = controller.ReadAll();
            // ekstrak objek mhs dari collection
            foreach (var upstock in updatestocks)
            {
                var noUrut = lvwDataBrg.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(Convert.ToString(upstock.id_upstock));
                item.SubItems.Add(Convert.ToString(upstock.tgl_update));
                item.SubItems.Add(Convert.ToString(upstock.jml_update));
                item.SubItems.Add(Convert.ToString(upstock.id_brg));
                item.SubItems.Add(upstock.nama_brg);
                // tampilkan data mhs ke listview
                lvwDataBrg.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Updatestock upstock)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            updatestocks.Add(upstock);
            int noUrut = lvwDataBrg.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(Convert.ToString(upstock.id_upstock));
            item.SubItems.Add(Convert.ToString(upstock.tgl_update));
            item.SubItems.Add(Convert.ToString(upstock.jml_update));
            item.SubItems.Add(Convert.ToString(upstock.id_brg));
            item.SubItems.Add(upstock.nama_brg);
            lvwDataBrg.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Updatestock upstock)
        {
            // ambil index data mhs yang edit
            int index = lvwDataBrg.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = lvwDataBrg.Items[index];
            itemRow.SubItems[1].Text = Convert.ToString(upstock.id_upstock);
            itemRow.SubItems[2].Text = Convert.ToString(upstock.tgl_update);
            itemRow.SubItems[3].Text = Convert.ToString(upstock.jml_update);
            itemRow.SubItems[4].Text = Convert.ToString(upstock.id_brg);
            itemRow.SubItems[5].Text = upstock.nama_brg;
        }

        private void label3_Click(object sender, EventArgs e)
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda Ingin Keluar?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                frmLogin form3 = new frmLogin();
                form3.Show();
                Visible = false;
            }
        }

        private void lvwDataBrg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTambahBrg_Click(object sender, EventArgs e)
        {
            frmInputUpStock form4 = new frmInputUpStock("Tambah Data Update Stock", controller);
            form4.OnCreate += OnCreateEventHandler;
            form4.Show();
            Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwDataBrg.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Updatestock upstock = updatestocks[lvwDataBrg.SelectedIndices[0]];
                frmInputUpStock form5 = new frmInputUpStock("Edit Data Barang", upstock, controller);
                form5.OnUpdate += OnUpdateEventHandler;
                form5.Show();
                Visible = false;
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
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

        private void frmUpStock_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength != 0)
            {
                updatestocks = controller.ReadByNama(txtSearch.Text);
                if (updatestocks.Count > 0)
                {
                    LoadDataBarang(true, updatestocks);
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
                    Updatestock upstock = updatestocks[lvwDataBrg.SelectedIndices[0]];
                    // panggil operasi CRUD
                    var result = controller.DeleteUpstock(upstock);
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
