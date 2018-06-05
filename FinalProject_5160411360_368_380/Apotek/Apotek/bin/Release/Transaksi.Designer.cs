namespace Apotek
{
    partial class Transaksi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kd_obat = new System.Windows.Forms.TextBox();
            this.nm_obat = new System.Windows.Forms.TextBox();
            this.harga = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dGView1 = new System.Windows.Forms.DataGridView();
            this.databaseObatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tugas_bsrDataSet1 = new Apotek.tugas_bsrDataSet1();
            this.database_ObatTableAdapter = new Apotek.tugas_bsrDataSet1TableAdapters.Database_ObatTableAdapter();
            this.reload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseObatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugas_bsrDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 29);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(248, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSAKSI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kode Obat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nama Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kode Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga Obat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tanggal Transaksi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 7;
            // 
            // kd_obat
            // 
            this.kd_obat.Location = new System.Drawing.Point(119, 82);
            this.kd_obat.Name = "kd_obat";
            this.kd_obat.Size = new System.Drawing.Size(104, 20);
            this.kd_obat.TabIndex = 8;
            // 
            // nm_obat
            // 
            this.nm_obat.Location = new System.Drawing.Point(338, 52);
            this.nm_obat.Name = "nm_obat";
            this.nm_obat.Size = new System.Drawing.Size(104, 20);
            this.nm_obat.TabIndex = 9;
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(338, 82);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(104, 20);
            this.harga.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(119, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(104, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Jumlah Beli";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(119, 108);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(104, 20);
            this.textBox6.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(338, 111);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(104, 20);
            this.textBox7.TabIndex = 18;
            // 
            // dGView1
            // 
            this.dGView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView1.Location = new System.Drawing.Point(12, 160);
            this.dGView1.Name = "dGView1";
            this.dGView1.Size = new System.Drawing.Size(558, 164);
            this.dGView1.TabIndex = 19;
            this.dGView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView1_CellContentClick);
            // 
            // databaseObatBindingSource
            // 
            this.databaseObatBindingSource.DataMember = "Database_Obat";
            this.databaseObatBindingSource.DataSource = this.tugas_bsrDataSet1;
            // 
            // tugas_bsrDataSet1
            // 
            this.tugas_bsrDataSet1.DataSetName = "tugas_bsrDataSet1";
            this.tugas_bsrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database_ObatTableAdapter
            // 
            this.database_ObatTableAdapter.ClearBeforeFill = true;
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(478, 129);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(92, 23);
            this.reload.TabIndex = 20;
            this.reload.Text = "Reload";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 329);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.dGView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.nm_obat);
            this.Controls.Add(this.kd_obat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseObatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugas_bsrDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox kd_obat;
        private System.Windows.Forms.TextBox nm_obat;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dGView1;
        private tugas_bsrDataSet1 tugas_bsrDataSet1;
        private System.Windows.Forms.BindingSource databaseObatBindingSource;
        private tugas_bsrDataSet1TableAdapters.Database_ObatTableAdapter database_ObatTableAdapter;
        private System.Windows.Forms.Button reload;
    }
}