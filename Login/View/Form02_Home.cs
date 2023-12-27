using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Login.Controller;
using Login.Model.Repository;

namespace Login
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
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

        private void btnDataBarang_Click(object sender, EventArgs e)
        {
            frmDataBrg form3 = new frmDataBrg();
            form3.Show();
            Visible = false;
        }

        private void btnDetailBarang_Click(object sender, EventArgs e)
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

        private void btnSupplierD_Click(object sender, EventArgs e)
        {
            frmSupplier form5 = new frmSupplier();
            form5.Show();
            Visible = false;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier form6 = new frmSupplier();
            form6.Show();
            Visible = false;
        }

        private void btnTotalBrgMasuk_Click(object sender, EventArgs e)
        {
            frmDataDistri form7 = new frmDataDistri();
            form7.Show();
            Visible = false;
        }

        private void btnTotalTransIn_Click(object sender, EventArgs e)
        {
            frmTransIN form8 = new frmTransIN();
            form8.Show();
            Visible = false;
        }

        private void btnBrgMasuk_Click(object sender, EventArgs e)
        {
            frmTransIN form9 = new frmTransIN();
            form9.Show();
            Visible = false;
        }

        private void lblTTLTransOut_Click(object sender, EventArgs e)
        {

        }

        private void btnTotalTransOut_Click(object sender, EventArgs e)
        {
            frmTransOUT form10 = new frmTransOUT();
            form10.Show();
            Visible = false;
        }

        private void btnBrgKeluar_Click(object sender, EventArgs e)
        {
            frmTransOUT form11 = new frmTransOUT();
            form11.Show();
            Visible = false;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            HomeController home = new HomeController();
            string resultBrg = home.Count_Barang();
            lblJmlBrg.Text= resultBrg;
            string resultSplr = home.Count_Supplier();
            lblJmlSupp.Text= resultSplr;
            string Result = home.Count_Distri();
            lblDistri.Text = Result;
            string resultTransin = home.Count_Transin();
            lblTTLTransIn.Text= resultTransin;
            string resultTransout = home.Count_Transout();
            lblTTLTransOut.Text= resultTransout;
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblTTLBrgIn_Click(object sender, EventArgs e)
        {

        }
    }
}
