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
    public partial class frmTransIN : Form
    {
        private List<Transin> transins = new List<Transin>();
        private TransinController controller;
        public frmTransIN()
        {
            InitializeComponent();
            controller= new TransinController();
            InisialisasiListView();
            LoadDataTransin(false);
        }

        private void InisialisasiListView()
        {
            lvwDataTransIn.View = View.Details;
            lvwDataTransIn.FullRowSelect = true;
            lvwDataTransIn.GridLines = true;

            lvwDataTransIn.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("ID Trans In", 80, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("ID Back Office", 90, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("Nama Back Office", 150, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("ID Supplier", 80, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("Nama Supplier", 200, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("ID Barang", 80, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("Nama Barang", 200, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("Tanggal Beli", 140, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("Jumlah Beli", 100, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("Total Beli", 100, HorizontalAlignment.Center);
            lvwDataTransIn.Columns.Add("Harga Beli", 100, HorizontalAlignment.Center);
        }

        private void LoadDataTransin(bool isSearch, List<Transin> ListIn = null)
        {
            // kosongkan listview
            lvwDataTransIn.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            if (isSearch == true)
            {
                transins = ListIn;
            }
            else
            {
                transins = controller.ReadAll();
            }
            //distributors = controller.ReadAll();
            // ekstrak objek mhs dari collection
            foreach (var tin in transins)
            {
                var noUrut = lvwDataTransIn.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(Convert.ToString(tin.id_in));
                item.SubItems.Add(Convert.ToString(tin.id_bo));
                item.SubItems.Add(tin.username);
                item.SubItems.Add(Convert.ToString(tin.id_splr));
                item.SubItems.Add(tin.nama_splr);
                item.SubItems.Add(Convert.ToString(tin.id_brg));
                item.SubItems.Add(tin.nama_brg);
                item.SubItems.Add(Convert.ToString(tin.tgl_beli));
                item.SubItems.Add(Convert.ToString(tin.jml_beli));
                item.SubItems.Add(Convert.ToString(tin.ttl_beli));
                item.SubItems.Add(Convert.ToString(tin.hrg_beli));
                // tampilkan data mhs ke listview
                lvwDataTransIn.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Transin tin)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            transins.Add(tin);
            int noUrut = lvwDataTransIn.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(Convert.ToString(tin.id_in));
            item.SubItems.Add(Convert.ToString(tin.id_bo));
            item.SubItems.Add(tin.username);
            item.SubItems.Add(Convert.ToString(tin.id_splr));
            item.SubItems.Add(tin.nama_splr);
            item.SubItems.Add(Convert.ToString(tin.id_brg));
            item.SubItems.Add(tin.nama_brg);
            item.SubItems.Add(Convert.ToString(tin.tgl_beli));
            item.SubItems.Add(Convert.ToString(tin.jml_beli));
            item.SubItems.Add(Convert.ToString(tin.ttl_beli));
            item.SubItems.Add(Convert.ToString(tin.hrg_beli));
            // tampilkan data mhs ke listview
            lvwDataTransIn.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Transin tin)
        {
            // ambil index data mhs yang edit
            int index = lvwDataTransIn.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = lvwDataTransIn.Items[index];
            itemRow.SubItems[1].Text = Convert.ToString(tin.id_in);
            itemRow.SubItems[2].Text = Convert.ToString(tin.id_bo);
            itemRow.SubItems[3].Text = (tin.username);
            itemRow.SubItems[4].Text = Convert.ToString(tin.id_splr);
            itemRow.SubItems[5].Text = (tin.nama_splr);
            itemRow.SubItems[6].Text = Convert.ToString(tin.id_brg);
            itemRow.SubItems[7].Text = (tin.nama_brg);
            itemRow.SubItems[8].Text = Convert.ToString(tin.tgl_beli);
            itemRow.SubItems[9].Text = Convert.ToString(tin.jml_beli);
            itemRow.SubItems[10].Text = Convert.ToString(tin.ttl_beli);
            itemRow.SubItems[11].Text = Convert.ToString(tin.hrg_beli);
        }

        private void lvwDataDis_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnTambahTransIn_Click(object sender, EventArgs e)
        {
            frmInputTransIn form6 = new frmInputTransIn("Tambah Data Transaksi", controller);
            form6.OnCreate += OnCreateEventHandler;
            form6.Show();
            Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwDataTransIn.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Transin tin = transins[lvwDataTransIn.SelectedIndices[0]];
                frmInputTransIn form7 = new frmInputTransIn("Edit Data Transaksi", tin, controller);
                form7.OnUpdate += OnUpdateEventHandler;
                form7.Show();
                Visible = false;
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnBrgKeluar_Click(object sender, EventArgs e)
        {
            frmTransOUT form8 = new frmTransOUT();
            form8.Show();
            Visible = false;
        }

        private void frmTransIN_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength != 0)
            {
                transins = controller.ReadByNama(txtSearch.Text);
                if (transins.Count > 0)
                {
                    LoadDataTransin(true, transins);
                }
                else
                {
                    MessageBox.Show("Search GAGAL, 404 Not Found !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                LoadDataTransin(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwDataTransIn.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data transaksi ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Transin tin = transins[lvwDataTransIn.SelectedIndices[0]];
                    // panggil operasi CRUD
                    var result = controller.DeleteTransin(tin);
                    if (result > 0)
                        LoadDataTransin(false);
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data transaksi belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
