namespace BerkahJawir
{
    partial class FormCashier
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cb_barang = new ComboBox();
            tb_harga = new TextBox();
            tb_jumlah = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tb_ttlHarga = new TextBox();
            tb_ttlBayar = new TextBox();
            tb_kembalian = new TextBox();
            btn_bayar = new Button();
            btn_ttlKembali = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btn_refresh = new Button();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(114, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 26);
            label1.TabIndex = 0;
            label1.Text = "Aladin's Shop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 14);
            label2.TabIndex = 1;
            label2.Text = "Jenis Barang";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 134);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 14);
            label3.TabIndex = 2;
            label3.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 166);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 14);
            label4.TabIndex = 3;
            label4.Text = "Jumlah";
            // 
            // cb_barang
            // 
            cb_barang.FormattingEnabled = true;
            cb_barang.Items.AddRange(new object[] { "Semen", "Paku", "Cat", "Kawat", "Seng" });
            cb_barang.Location = new Point(163, 94);
            cb_barang.Margin = new Padding(2);
            cb_barang.Name = "cb_barang";
            cb_barang.Size = new Size(158, 23);
            cb_barang.TabIndex = 4;
            cb_barang.SelectedIndexChanged += cb_barang_SelectedIndexChanged;
            // 
            // tb_harga
            // 
            tb_harga.BorderStyle = BorderStyle.FixedSingle;
            tb_harga.Location = new Point(163, 127);
            tb_harga.Margin = new Padding(2);
            tb_harga.Name = "tb_harga";
            tb_harga.Size = new Size(158, 23);
            tb_harga.TabIndex = 5;
            // 
            // tb_jumlah
            // 
            tb_jumlah.BorderStyle = BorderStyle.FixedSingle;
            tb_jumlah.Location = new Point(163, 159);
            tb_jumlah.Margin = new Padding(2);
            tb_jumlah.Name = "tb_jumlah";
            tb_jumlah.Size = new Size(158, 23);
            tb_jumlah.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(433, 325);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 14);
            label5.TabIndex = 7;
            label5.Text = "Total Harga";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(68, 260);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 14);
            label6.TabIndex = 8;
            label6.Text = "Total Bayar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(68, 292);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 14);
            label7.TabIndex = 9;
            label7.Text = "Kembalian";
            // 
            // tb_ttlHarga
            // 
            tb_ttlHarga.BorderStyle = BorderStyle.FixedSingle;
            tb_ttlHarga.Location = new Point(527, 318);
            tb_ttlHarga.Margin = new Padding(2);
            tb_ttlHarga.Name = "tb_ttlHarga";
            tb_ttlHarga.Size = new Size(182, 23);
            tb_ttlHarga.TabIndex = 10;
            // 
            // tb_ttlBayar
            // 
            tb_ttlBayar.BorderStyle = BorderStyle.FixedSingle;
            tb_ttlBayar.Location = new Point(161, 255);
            tb_ttlBayar.Margin = new Padding(2);
            tb_ttlBayar.Name = "tb_ttlBayar";
            tb_ttlBayar.Size = new Size(160, 23);
            tb_ttlBayar.TabIndex = 11;
            // 
            // tb_kembalian
            // 
            tb_kembalian.BorderStyle = BorderStyle.FixedSingle;
            tb_kembalian.Location = new Point(161, 287);
            tb_kembalian.Margin = new Padding(2);
            tb_kembalian.Name = "tb_kembalian";
            tb_kembalian.Size = new Size(160, 23);
            tb_kembalian.TabIndex = 12;
            // 
            // btn_bayar
            // 
            btn_bayar.BackColor = Color.MidnightBlue;
            btn_bayar.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_bayar.ForeColor = SystemColors.ButtonHighlight;
            btn_bayar.Location = new Point(161, 186);
            btn_bayar.Margin = new Padding(2);
            btn_bayar.Name = "btn_bayar";
            btn_bayar.Size = new Size(92, 28);
            btn_bayar.TabIndex = 13;
            btn_bayar.Text = "BAYAR";
            btn_bayar.UseVisualStyleBackColor = false;
            btn_bayar.Click += btn_bayar_Click;
            // 
            // btn_ttlKembali
            // 
            btn_ttlKembali.BackColor = Color.MidnightBlue;
            btn_ttlKembali.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ttlKembali.ForeColor = SystemColors.ButtonHighlight;
            btn_ttlKembali.Location = new Point(161, 316);
            btn_ttlKembali.Margin = new Padding(2);
            btn_ttlKembali.Name = "btn_ttlKembali";
            btn_ttlKembali.Size = new Size(92, 28);
            btn_ttlKembali.TabIndex = 14;
            btn_ttlKembali.Text = "TOTAL";
            btn_ttlKembali.UseVisualStyleBackColor = false;
            btn_ttlKembali.Click += btn_ttlKembali_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(433, 95);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(144, 23);
            label8.TabIndex = 15;
            label8.Text = "Gambar Produk";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(433, 120);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 190);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.MediumSlateBlue;
            btn_refresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_refresh.ForeColor = SystemColors.ButtonHighlight;
            btn_refresh.Location = new Point(532, 28);
            btn_refresh.Margin = new Padding(2);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(77, 25);
            btn_refresh.TabIndex = 17;
            btn_refresh.Text = "REFRESH";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.MediumSlateBlue;
            btn_exit.ForeColor = SystemColors.ButtonHighlight;
            btn_exit.Location = new Point(633, 28);
            btn_exit.Margin = new Padding(2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(76, 25);
            btn_exit.TabIndex = 18;
            btn_exit.Text = "EXIT";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // FormCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 414);
            Controls.Add(btn_exit);
            Controls.Add(btn_refresh);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(btn_ttlKembali);
            Controls.Add(btn_bayar);
            Controls.Add(tb_kembalian);
            Controls.Add(tb_ttlBayar);
            Controls.Add(tb_ttlHarga);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tb_jumlah);
            Controls.Add(tb_harga);
            Controls.Add(cb_barang);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormCashier";
            Text = "FormCashier";
            Load += FormCashier_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cb_barang;
        private TextBox tb_harga;
        private TextBox tb_jumlah;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_ttlHarga;
        private TextBox tb_ttlBayar;
        private TextBox tb_kembalian;
        private Button btn_bayar;
        private Button btn_ttlKembali;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btn_refresh;
        private Button btn_exit;
    }
}