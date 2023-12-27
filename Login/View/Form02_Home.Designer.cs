namespace Login
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblTTLTransIn = new System.Windows.Forms.Label();
            this.lblDistri = new System.Windows.Forms.Label();
            this.lblJmlSupp = new System.Windows.Forms.Label();
            this.lblTTLTransOut = new System.Windows.Forms.Label();
            this.lblJmlBrg = new System.Windows.Forms.Label();
            this.btnTotalTransOut = new System.Windows.Forms.Button();
            this.btnTotalTransIn = new System.Windows.Forms.Button();
            this.btnTotalBrgMasuk = new System.Windows.Forms.Button();
            this.btnSupplierD = new System.Windows.Forms.Button();
            this.btnDetailBarang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            // lblTTLTransIn
            // 
            this.lblTTLTransIn.AutoSize = true;
            this.lblTTLTransIn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTLTransIn.ForeColor = System.Drawing.Color.White;
            this.lblTTLTransIn.Image = ((System.Drawing.Image)(resources.GetObject("lblTTLTransIn.Image")));
            this.lblTTLTransIn.Location = new System.Drawing.Point(766, 281);
            this.lblTTLTransIn.Name = "lblTTLTransIn";
            this.lblTTLTransIn.Size = new System.Drawing.Size(129, 35);
            this.lblTTLTransIn.TabIndex = 54;
            this.lblTTLTransIn.Text = "JmlBarang";
            // 
            // lblDistri
            // 
            this.lblDistri.AutoSize = true;
            this.lblDistri.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistri.ForeColor = System.Drawing.Color.White;
            this.lblDistri.Image = ((System.Drawing.Image)(resources.GetObject("lblDistri.Image")));
            this.lblDistri.Location = new System.Drawing.Point(300, 468);
            this.lblDistri.Name = "lblDistri";
            this.lblDistri.Size = new System.Drawing.Size(129, 35);
            this.lblDistri.TabIndex = 53;
            this.lblDistri.Text = "JmlBarang";
            this.lblDistri.EnabledChanged += new System.EventHandler(this.frmHome_Load);
            this.lblDistri.TextChanged += new System.EventHandler(this.frmHome_Load);
            this.lblDistri.Click += new System.EventHandler(this.lblTTLBrgIn_Click);
            // 
            // lblJmlSupp
            // 
            this.lblJmlSupp.AutoSize = true;
            this.lblJmlSupp.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmlSupp.ForeColor = System.Drawing.Color.White;
            this.lblJmlSupp.Image = ((System.Drawing.Image)(resources.GetObject("lblJmlSupp.Image")));
            this.lblJmlSupp.Location = new System.Drawing.Point(300, 290);
            this.lblJmlSupp.Name = "lblJmlSupp";
            this.lblJmlSupp.Size = new System.Drawing.Size(129, 35);
            this.lblJmlSupp.TabIndex = 51;
            this.lblJmlSupp.Text = "JmlBarang";
            // 
            // lblTTLTransOut
            // 
            this.lblTTLTransOut.AutoSize = true;
            this.lblTTLTransOut.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTLTransOut.ForeColor = System.Drawing.Color.White;
            this.lblTTLTransOut.Image = ((System.Drawing.Image)(resources.GetObject("lblTTLTransOut.Image")));
            this.lblTTLTransOut.Location = new System.Drawing.Point(766, 468);
            this.lblTTLTransOut.Name = "lblTTLTransOut";
            this.lblTTLTransOut.Size = new System.Drawing.Size(129, 35);
            this.lblTTLTransOut.TabIndex = 50;
            this.lblTTLTransOut.Text = "JmlBarang";
            this.lblTTLTransOut.Click += new System.EventHandler(this.lblTTLTransOut_Click);
            // 
            // lblJmlBrg
            // 
            this.lblJmlBrg.AutoSize = true;
            this.lblJmlBrg.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmlBrg.ForeColor = System.Drawing.Color.White;
            this.lblJmlBrg.Image = ((System.Drawing.Image)(resources.GetObject("lblJmlBrg.Image")));
            this.lblJmlBrg.Location = new System.Drawing.Point(522, 93);
            this.lblJmlBrg.Name = "lblJmlBrg";
            this.lblJmlBrg.Size = new System.Drawing.Size(129, 35);
            this.lblJmlBrg.TabIndex = 49;
            this.lblJmlBrg.Text = "JmlBarang";
            // 
            // btnTotalTransOut
            // 
            this.btnTotalTransOut.AutoSize = true;
            this.btnTotalTransOut.FlatAppearance.BorderSize = 0;
            this.btnTotalTransOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalTransOut.Image = ((System.Drawing.Image)(resources.GetObject("btnTotalTransOut.Image")));
            this.btnTotalTransOut.Location = new System.Drawing.Point(754, 449);
            this.btnTotalTransOut.Name = "btnTotalTransOut";
            this.btnTotalTransOut.Size = new System.Drawing.Size(259, 154);
            this.btnTotalTransOut.TabIndex = 48;
            this.btnTotalTransOut.UseVisualStyleBackColor = true;
            this.btnTotalTransOut.Click += new System.EventHandler(this.btnTotalTransOut_Click);
            // 
            // btnTotalTransIn
            // 
            this.btnTotalTransIn.AutoSize = true;
            this.btnTotalTransIn.FlatAppearance.BorderSize = 0;
            this.btnTotalTransIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalTransIn.Image = ((System.Drawing.Image)(resources.GetObject("btnTotalTransIn.Image")));
            this.btnTotalTransIn.Location = new System.Drawing.Point(754, 262);
            this.btnTotalTransIn.Name = "btnTotalTransIn";
            this.btnTotalTransIn.Size = new System.Drawing.Size(259, 154);
            this.btnTotalTransIn.TabIndex = 47;
            this.btnTotalTransIn.UseVisualStyleBackColor = true;
            this.btnTotalTransIn.Click += new System.EventHandler(this.btnTotalTransIn_Click);
            // 
            // btnTotalBrgMasuk
            // 
            this.btnTotalBrgMasuk.AutoSize = true;
            this.btnTotalBrgMasuk.FlatAppearance.BorderSize = 0;
            this.btnTotalBrgMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalBrgMasuk.Image = ((System.Drawing.Image)(resources.GetObject("btnTotalBrgMasuk.Image")));
            this.btnTotalBrgMasuk.Location = new System.Drawing.Point(288, 449);
            this.btnTotalBrgMasuk.Name = "btnTotalBrgMasuk";
            this.btnTotalBrgMasuk.Size = new System.Drawing.Size(259, 154);
            this.btnTotalBrgMasuk.TabIndex = 45;
            this.btnTotalBrgMasuk.UseVisualStyleBackColor = true;
            this.btnTotalBrgMasuk.Click += new System.EventHandler(this.btnTotalBrgMasuk_Click);
            // 
            // btnSupplierD
            // 
            this.btnSupplierD.AutoSize = true;
            this.btnSupplierD.FlatAppearance.BorderSize = 0;
            this.btnSupplierD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierD.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierD.Image")));
            this.btnSupplierD.Location = new System.Drawing.Point(288, 268);
            this.btnSupplierD.Name = "btnSupplierD";
            this.btnSupplierD.Size = new System.Drawing.Size(259, 154);
            this.btnSupplierD.TabIndex = 44;
            this.btnSupplierD.UseVisualStyleBackColor = true;
            this.btnSupplierD.Click += new System.EventHandler(this.btnSupplierD_Click);
            // 
            // btnDetailBarang
            // 
            this.btnDetailBarang.AutoSize = true;
            this.btnDetailBarang.FlatAppearance.BorderSize = 0;
            this.btnDetailBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailBarang.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailBarang.Image")));
            this.btnDetailBarang.Location = new System.Drawing.Point(510, 71);
            this.btnDetailBarang.Name = "btnDetailBarang";
            this.btnDetailBarang.Size = new System.Drawing.Size(259, 154);
            this.btnDetailBarang.TabIndex = 43;
            this.btnDetailBarang.UseVisualStyleBackColor = true;
            this.btnDetailBarang.Click += new System.EventHandler(this.btnDetailBarang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 41);
            this.label3.TabIndex = 42;
            this.label3.Text = "DASHBOARD";
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(-23, 600);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(218, 39);
            this.btnLogOut.TabIndex = 41;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUpStck
            // 
            this.btnUpStck.AutoSize = true;
            this.btnUpStck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpStck.BackgroundImage")));
            this.btnUpStck.FlatAppearance.BorderSize = 0;
            this.btnUpStck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpStck.Image = ((System.Drawing.Image)(resources.GetObject("btnUpStck.Image")));
            this.btnUpStck.Location = new System.Drawing.Point(3, 491);
            this.btnUpStck.Name = "btnUpStck";
            this.btnUpStck.Size = new System.Drawing.Size(238, 47);
            this.btnUpStck.TabIndex = 40;
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
            this.btnBrgKeluar.Location = new System.Drawing.Point(-4, 432);
            this.btnBrgKeluar.Name = "btnBrgKeluar";
            this.btnBrgKeluar.Size = new System.Drawing.Size(260, 53);
            this.btnBrgKeluar.TabIndex = 39;
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
            this.btnBrgMasuk.Location = new System.Drawing.Point(12, 376);
            this.btnBrgMasuk.Name = "btnBrgMasuk";
            this.btnBrgMasuk.Size = new System.Drawing.Size(230, 50);
            this.btnBrgMasuk.TabIndex = 38;
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
            this.btnSupplier.Location = new System.Drawing.Point(3, 321);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(227, 49);
            this.btnSupplier.TabIndex = 37;
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
            this.btnDataBarang.Location = new System.Drawing.Point(-4, 262);
            this.btnDataBarang.Margin = new System.Windows.Forms.Padding(0);
            this.btnDataBarang.Name = "btnDataBarang";
            this.btnDataBarang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDataBarang.Size = new System.Drawing.Size(235, 45);
            this.btnDataBarang.TabIndex = 36;
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
            this.btsDashboard.Location = new System.Drawing.Point(15, 212);
            this.btsDashboard.Name = "btsDashboard";
            this.btsDashboard.Size = new System.Drawing.Size(192, 38);
            this.btsDashboard.TabIndex = 35;
            this.btsDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 136);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(272, 70);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(67, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Online";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(29, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 36);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 35);
            this.label1.TabIndex = 29;
            this.label1.Text = "Yudha Sejahtera";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 73);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 677);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lblTTLTransIn);
            this.Controls.Add(this.lblDistri);
            this.Controls.Add(this.lblJmlSupp);
            this.Controls.Add(this.lblTTLTransOut);
            this.Controls.Add(this.lblJmlBrg);
            this.Controls.Add(this.btnTotalTransOut);
            this.Controls.Add(this.btnTotalTransIn);
            this.Controls.Add(this.btnTotalBrgMasuk);
            this.Controls.Add(this.btnSupplierD);
            this.Controls.Add(this.btnDetailBarang);
            this.Controls.Add(this.label3);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTTLTransIn;
        private System.Windows.Forms.Label lblDistri;
        private System.Windows.Forms.Label lblJmlSupp;
        private System.Windows.Forms.Label lblTTLTransOut;
        private System.Windows.Forms.Label lblJmlBrg;
        private System.Windows.Forms.Button btnTotalTransOut;
        private System.Windows.Forms.Button btnTotalTransIn;
        private System.Windows.Forms.Button btnTotalBrgMasuk;
        private System.Windows.Forms.Button btnSupplierD;
        private System.Windows.Forms.Button btnDetailBarang;
        private System.Windows.Forms.Label label3;
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