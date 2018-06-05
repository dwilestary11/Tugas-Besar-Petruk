namespace Apotek
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.keluar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.dGView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karantinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Create = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.TextBox();
            this.pnykt = new System.Windows.Forms.TextBox();
            this.nm_obt = new System.Windows.Forms.TextBox();
            this.kd_obt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kdluarsa = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keluar
            // 
            this.keluar.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.keluar, "keluar");
            this.keluar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.keluar.Name = "keluar";
            this.keluar.UseVisualStyleBackColor = false;
            this.keluar.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // admin
            // 
            resources.ApplyResources(this.admin, "admin");
            this.admin.Name = "admin";
            this.admin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.delete, "delete");
            this.delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Name = "delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.reload, "reload");
            this.reload.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.reload.Name = "reload";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // dGView1
            // 
            this.dGView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dGView1, "dGView1");
            this.dGView1.Name = "dGView1";
            this.dGView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuToolStripMenuItem,
            this.transaksiToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karantinaToolStripMenuItem,
            this.historyToolStripMenuItem1});
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            // 
            // karantinaToolStripMenuItem
            // 
            this.karantinaToolStripMenuItem.Name = "karantinaToolStripMenuItem";
            resources.ApplyResources(this.karantinaToolStripMenuItem, "karantinaToolStripMenuItem");
            this.karantinaToolStripMenuItem.Click += new System.EventHandler(this.karantinaToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem1
            // 
            this.historyToolStripMenuItem1.Name = "historyToolStripMenuItem1";
            resources.ApplyResources(this.historyToolStripMenuItem1, "historyToolStripMenuItem1");
            this.historyToolStripMenuItem1.Click += new System.EventHandler(this.historyToolStripMenuItem1_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            resources.ApplyResources(this.transaksiToolStripMenuItem, "transaksiToolStripMenuItem");
            this.transaksiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.Create, "Create");
            this.Create.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Create.Name = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.update, "update");
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Name = "update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Harga
            // 
            resources.ApplyResources(this.Harga, "Harga");
            this.Harga.Name = "Harga";
            // 
            // Stock
            // 
            resources.ApplyResources(this.Stock, "Stock");
            this.Stock.Name = "Stock";
            // 
            // pnykt
            // 
            resources.ApplyResources(this.pnykt, "pnykt");
            this.pnykt.Name = "pnykt";
            // 
            // nm_obt
            // 
            resources.ApplyResources(this.nm_obt, "nm_obt");
            this.nm_obt.Name = "nm_obt";
            // 
            // kd_obt
            // 
            resources.ApplyResources(this.kd_obt, "kd_obt");
            this.kd_obt.Name = "kd_obt";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // kdluarsa
            // 
            resources.ApplyResources(this.kdluarsa, "kdluarsa");
            this.kdluarsa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kdluarsa.Name = "kdluarsa";
            // 
            // menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.kdluarsa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.pnykt);
            this.Controls.Add(this.nm_obt);
            this.Controls.Add(this.kd_obt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.dGView1);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox admin;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.DataGridView dGView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem karantinaToolStripMenuItem;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Harga;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.TextBox pnykt;
        private System.Windows.Forms.TextBox nm_obt;
        private System.Windows.Forms.TextBox kd_obt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker kdluarsa;


    }
}