namespace Login
{
    partial class frmDataBrg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataBrg));
            this.label3 = new System.Windows.Forms.Label();
            this.btnTambahBrg = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvwDataBrg = new System.Windows.Forms.ListView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUpStck = new System.Windows.Forms.Button();
            this.btnBrgKeluar = new System.Windows.Forms.Button();
            this.btnBrgMasuk = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnDataBarang = new System.Windows.Forms.Button();
            this.btsDashboard = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 41);
            this.label3.TabIndex = 69;
            this.label3.Text = "DATA BARANG";
            // 
            // btnTambahBrg
            // 
            this.btnTambahBrg.AutoSize = true;
            this.btnTambahBrg.FlatAppearance.BorderSize = 0;
            this.btnTambahBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahBrg.Image = ((System.Drawing.Image)(resources.GetObject("btnTambahBrg.Image")));
            this.btnTambahBrg.Location = new System.Drawing.Point(311, 84);
            this.btnTambahBrg.Name = "btnTambahBrg";
            this.btnTambahBrg.Size = new System.Drawing.Size(141, 35);
            this.btnTambahBrg.TabIndex = 70;
            this.btnTambahBrg.UseVisualStyleBackColor = true;
            this.btnTambahBrg.Click += new System.EventHandler(this.btnTambahBrg_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(930, 87);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 30);
            this.lblSearch.TabIndex = 71;
            this.lblSearch.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1017, 87);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 22);
            this.txtSearch.TabIndex = 72;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1195, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 31);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lvwDataBrg
            // 
            this.lvwDataBrg.HideSelection = false;
            this.lvwDataBrg.Location = new System.Drawing.Point(298, 171);
            this.lvwDataBrg.Name = "lvwDataBrg";
            this.lvwDataBrg.Size = new System.Drawing.Size(952, 410);
            this.lvwDataBrg.TabIndex = 74;
            this.lvwDataBrg.UseCompatibleStateImageBehavior = false;
            this.lvwDataBrg.SelectedIndexChanged += new System.EventHandler(this.lvwDataBrg_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(958, 603);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 30);
            this.btnEdit.TabIndex = 75;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1098, 601);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 35);
            this.btnDelete.TabIndex = 76;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(-19, 603);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(218, 39);
            this.btnLogOut.TabIndex = 90;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnUpStck
            // 
            this.btnUpStck.AutoSize = true;
            this.btnUpStck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpStck.BackgroundImage")));
            this.btnUpStck.FlatAppearance.BorderSize = 0;
            this.btnUpStck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpStck.Image = ((System.Drawing.Image)(resources.GetObject("btnUpStck.Image")));
            this.btnUpStck.Location = new System.Drawing.Point(7, 494);
            this.btnUpStck.Name = "btnUpStck";
            this.btnUpStck.Size = new System.Drawing.Size(238, 47);
            this.btnUpStck.TabIndex = 89;
            this.btnUpStck.UseVisualStyleBackColor = true;
            this.btnUpStck.Click += new System.EventHandler(this.btnUpStck_Click);
            // 
            // btnBrgKeluar
            // 
            this.btnBrgKeluar.AutoSize = true;
            this.btnBrgKeluar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrgKeluar.BackgroundImage")));
            this.btnBrgKeluar.FlatAppearance.BorderSize = 0;
            this.btnBrgKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrgKeluar.Image = ((System.Drawing.Image)(resources.GetObject("btnBrgKeluar.Image")));
            this.btnBrgKeluar.Location = new System.Drawing.Point(0, 435);
            this.btnBrgKeluar.Name = "btnBrgKeluar";
            this.btnBrgKeluar.Size = new System.Drawing.Size(260, 53);
            this.btnBrgKeluar.TabIndex = 88;
            this.btnBrgKeluar.UseVisualStyleBackColor = true;
            this.btnBrgKeluar.Click += new System.EventHandler(this.btnBrgKeluar_Click);
            // 
            // btnBrgMasuk
            // 
            this.btnBrgMasuk.AutoSize = true;
            this.btnBrgMasuk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrgMasuk.BackgroundImage")));
            this.btnBrgMasuk.FlatAppearance.BorderSize = 0;
            this.btnBrgMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrgMasuk.Image = ((System.Drawing.Image)(resources.GetObject("btnBrgMasuk.Image")));
            this.btnBrgMasuk.Location = new System.Drawing.Point(16, 379);
            this.btnBrgMasuk.Name = "btnBrgMasuk";
            this.btnBrgMasuk.Size = new System.Drawing.Size(230, 50);
            this.btnBrgMasuk.TabIndex = 87;
            this.btnBrgMasuk.UseVisualStyleBackColor = true;
            this.btnBrgMasuk.Click += new System.EventHandler(this.btnBrgMasuk_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.AutoSize = true;
            this.btnSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplier.BackgroundImage")));
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.Location = new System.Drawing.Point(7, 324);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(227, 49);
            this.btnSupplier.TabIndex = 86;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnDataBarang
            // 
            this.btnDataBarang.AutoSize = true;
            this.btnDataBarang.BackColor = System.Drawing.Color.Transparent;
            this.btnDataBarang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDataBarang.BackgroundImage")));
            this.btnDataBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDataBarang.FlatAppearance.BorderSize = 0;
            this.btnDataBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataBarang.Image = ((System.Drawing.Image)(resources.GetObject("btnDataBarang.Image")));
            this.btnDataBarang.Location = new System.Drawing.Point(0, 265);
            this.btnDataBarang.Margin = new System.Windows.Forms.Padding(0);
            this.btnDataBarang.Name = "btnDataBarang";
            this.btnDataBarang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDataBarang.Size = new System.Drawing.Size(235, 45);
            this.btnDataBarang.TabIndex = 85;
            this.btnDataBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDataBarang.UseVisualStyleBackColor = false;
            this.btnDataBarang.Click += new System.EventHandler(this.btnDataBarang_Click);
            // 
            // btsDashboard
            // 
            this.btsDashboard.AutoSize = true;
            this.btsDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btsDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsDashboard.BackgroundImage")));
            this.btsDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btsDashboard.FlatAppearance.BorderSize = 0;
            this.btsDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btsDashboard.Image")));
            this.btsDashboard.Location = new System.Drawing.Point(19, 215);
            this.btsDashboard.Name = "btsDashboard";
            this.btsDashboard.Size = new System.Drawing.Size(192, 38);
            this.btsDashboard.TabIndex = 84;
            this.btsDashboard.UseVisualStyleBackColor = false;
            this.btsDashboard.Click += new System.EventHandler(this.btsDashboard_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 139);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(272, 70);
            this.pictureBox4.TabIndex = 83;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(71, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 81;
            this.label2.Text = "Online";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 36);
            this.pictureBox3.TabIndex = 79;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 35);
            this.label1.TabIndex = 78;
            this.label1.Text = "Yudha Sejahtera";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 73);
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 677);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // frmDataBrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnUpStck);
            this.Controls.Add(this.btnBrgKeluar);
            this.Controls.Add(this.btnBrgMasuk);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnDataBarang);
            this.Controls.Add(this.btsDashboard);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvwDataBrg);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnTambahBrg);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDataBrg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Barang";
            this.Load += new System.EventHandler(this.frmDataBrg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTambahBrg;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvwDataBrg;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUpStck;
        private System.Windows.Forms.Button btnBrgKeluar;
        private System.Windows.Forms.Button btnBrgMasuk;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnDataBarang;
        private System.Windows.Forms.Button btsDashboard;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}