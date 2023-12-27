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
    public partial class frmTransOUT : Form
    {
        private List<Transout> transouts = new List<Transout>();
        private TransoutController controller;
        public frmTransOUT()
        {
            InitializeComponent();
            controller = new TransoutController();
            InisialisasiListView();
            LoadDataTransout(false);
        }

        private void InisialisasiListView()
        {
            lvwDataTransOut.View = View.Details;
            lvwDataTransOut.FullRowSelect = true;
            lvwDataTransOut.GridLines = true;

            lvwDataTransOut.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("ID Trans Out", 80, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("ID Back Office", 90, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("Nama Back Office", 150, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("ID Distributor", 80, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("Nama Distributor", 200, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("ID Barang", 80, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("Nama Barang", 200, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("Tanggal Jual", 140, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("Jumlah Jual", 100, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("Total Jual", 100, HorizontalAlignment.Center);
            lvwDataTransOut.Columns.Add("Harga Jual", 100, HorizontalAlignment.Center);
        }

        private void LoadDataTransout(bool isSearch, List<Transout> ListOut = null)
        {
            // kosongkan listview
            lvwDataTransOut.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            if (isSearch == true)
            {
                transouts = ListOut;
            }
            else
            {
                transouts = controller.ReadAll();
            }
            //distributors = controller.ReadAll();
            // ekstrak objek mhs dari collection
            foreach (var tout in transouts)
            {
                var noUrut = lvwDataTransOut.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(Convert.ToString(tout.id_out));
                item.SubItems.Add(Convert.ToString(tout.id_bo));
                item.SubItems.Add(tout.username);
                item.SubItems.Add(Convert.ToString(tout.id_distributor));
                item.SubItems.Add(tout.nama_distributor);
                item.SubItems.Add(Convert.ToString(tout.id_brg));
                item.SubItems.Add(tout.nama_brg);
                item.SubItems.Add(Convert.ToString(tout.tgl_jual));
                item.SubItems.Add(Convert.ToString(tout.jml_jual));
                item.SubItems.Add(Convert.ToString(tout.ttl_jual));
                item.SubItems.Add(Convert.ToString(tout.hrg_jual));
                // tampilkan data mhs ke listview
                lvwDataTransOut.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Transout tout)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            transouts.Add(tout);
            int noUrut = lvwDataTransOut.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(Convert.ToString(tout.id_out));
            item.SubItems.Add(Convert.ToString(tout.id_bo));
            item.SubItems.Add(tout.username);
            item.SubItems.Add(Convert.ToString(tout.id_distributor));
            item.SubItems.Add(tout.nama_distributor);
            item.SubItems.Add(Convert.ToString(tout.id_brg));
            item.SubItems.Add(tout.nama_brg);
            item.SubItems.Add(Convert.ToString(tout.tgl_jual));
            item.SubItems.Add(Convert.ToString(tout.jml_jual));
            item.SubItems.Add(Convert.ToString(tout.ttl_jual));
            item.SubItems.Add(Convert.ToString(tout.hrg_jual));
            // tampilkan data mhs ke listview
            lvwDataTransOut.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Transout tout)
        {
            // ambil index data mhs yang edit
            int index = lvwDataTransOut.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = lvwDataTransOut.Items[index];
            itemRow.SubItems[1].Text = Convert.ToString(tout.id_out);
            itemRow.SubItems[2].Text = Convert.ToString(tout.id_bo);
            itemRow.SubItems[3].Text = (tout.username);
            itemRow.SubItems[4].Text = Convert.ToString(tout.id_distributor);
            itemRow.SubItems[5].Text = (tout.nama_distributor);
            itemRow.SubItems[6].Text = Convert.ToString(tout.id_brg);
            itemRow.SubItems[7].Text = (tout.nama_brg);
            itemRow.SubItems[8].Text = Convert.ToString(tout.tgl_jual);
            itemRow.SubItems[9].Text = Convert.ToString(tout.jml_jual);
            itemRow.SubItems[10].Text = Convert.ToString(tout.ttl_jual);
            itemRow.SubItems[11].Text = Convert.ToString(tout.hrg_jual);
        }

        private void lvwDataTransIn_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnBrgMasuk_Click(object sender, EventArgs e)
        {
            frmTransIN form5 = new frmTransIN();
            form5.Show();
            Visible = false;
        }

        private void btnUpStck_Click(object sender, EventArgs e)
        {
            frmUpStock form6 = new frmUpStock();
            form6.Show();
            Visible = false;
        }

        private void btnTambahTransOut_Click(object sender, EventArgs e)
        {
            frmInputTransOut form7 = new frmInputTransOut("Tambah Data Transaksi", controller);
            form7.OnCreate += OnCreateEventHandler;
            form7.Show();
            Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwDataTransOut.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Transout tout = transouts[lvwDataTransOut.SelectedIndices[0]];
                frmInputTransOut form8 = new frmInputTransOut("Edit Data Transaksi", tout, controller);
                form8.OnUpdate += OnUpdateEventHandler;
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

        private void frmTransOUT_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength != 0)
            {
                transouts = controller.ReadByNama(txtSearch.Text);
                if (transouts.Count > 0)
                {
                    LoadDataTransout(true, transouts);
                }
                else
                {
                    MessageBox.Show("Search GAGAL, 404 Not Found !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                LoadDataTransout(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwDataTransOut.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data transaksi ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Transout tout = transouts[lvwDataTransOut.SelectedIndices[0]];
                    // panggil operasi CRUD
                    var result = controller.DeleteTransout(tout);
                    if (result > 0)
                        LoadDataTransout(false);
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
