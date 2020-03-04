namespace SeriPortTester
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrVeriGonder = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.seriBaglanti1 = new NHSeriBaglanti.SeriBaglanti();
            this.grpVeriGonder = new System.Windows.Forms.GroupBox();
            this.chckUseRandom = new System.Windows.Forms.CheckBox();
            this.chckTekrarla = new System.Windows.Forms.CheckBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.grpRandom = new System.Windows.Forms.GroupBox();
            this.nudRandMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRandMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTekrarla = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtGonder = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAlnTemizle = new System.Windows.Forms.Button();
            this.rtxtAlınan = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGondTemizle = new System.Windows.Forms.Button();
            this.rtxtGonderilen = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.grpVeriGonder.SuspendLayout();
            this.grpRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandMin)).BeginInit();
            this.grpTekrarla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrVeriGonder
            // 
            this.tmrVeriGonder.Interval = 1000;
            this.tmrVeriGonder.Tick += new System.EventHandler(this.tmrVeriGonder_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 1200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.seriBaglanti1);
            this.panel1.Controls.Add(this.grpVeriGonder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 424);
            this.panel1.TabIndex = 4;
            // 
            // seriBaglanti1
            // 
            this.seriBaglanti1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seriBaglanti1.Location = new System.Drawing.Point(3, 3);
            this.seriBaglanti1.Name = "seriBaglanti1";
            this.seriBaglanti1.SerialPort = this.serialPort1;
            this.seriBaglanti1.Size = new System.Drawing.Size(276, 129);
            this.seriBaglanti1.TabIndex = 0;
            this.seriBaglanti1.VeriAlindi += new System.IO.Ports.SerialDataReceivedEventHandler(this.seriBaglanti1_VeriAlindi);
            this.seriBaglanti1.PortAcildi += new System.EventHandler<NHSeriBaglanti.SeriPortArgs>(this.seriBaglanti1_PortAcildi);
            this.seriBaglanti1.PortKapatildi += new System.EventHandler<NHSeriBaglanti.SeriPortArgs>(this.seriBaglanti1_PortKapatildi);
            // 
            // grpVeriGonder
            // 
            this.grpVeriGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVeriGonder.Controls.Add(this.chckUseRandom);
            this.grpVeriGonder.Controls.Add(this.chckTekrarla);
            this.grpVeriGonder.Controls.Add(this.btnSendData);
            this.grpVeriGonder.Controls.Add(this.grpRandom);
            this.grpVeriGonder.Controls.Add(this.grpTekrarla);
            this.grpVeriGonder.Controls.Add(this.rtxtGonder);
            this.grpVeriGonder.Enabled = false;
            this.grpVeriGonder.Location = new System.Drawing.Point(3, 138);
            this.grpVeriGonder.Name = "grpVeriGonder";
            this.grpVeriGonder.Size = new System.Drawing.Size(276, 283);
            this.grpVeriGonder.TabIndex = 1;
            this.grpVeriGonder.TabStop = false;
            this.grpVeriGonder.Text = "Veri Gönderme";
            // 
            // chckUseRandom
            // 
            this.chckUseRandom.AutoSize = true;
            this.chckUseRandom.Location = new System.Drawing.Point(13, 69);
            this.chckUseRandom.Name = "chckUseRandom";
            this.chckUseRandom.Size = new System.Drawing.Size(201, 17);
            this.chckUseRandom.TabIndex = 2;
            this.chckUseRandom.Text = "Rastgele Sayısal Veri Kullan(<rand/>)";
            this.chckUseRandom.UseVisualStyleBackColor = true;
            this.chckUseRandom.CheckedChanged += new System.EventHandler(this.chckUseRandom_CheckedChanged);
            // 
            // chckTekrarla
            // 
            this.chckTekrarla.AutoSize = true;
            this.chckTekrarla.Location = new System.Drawing.Point(13, 19);
            this.chckTekrarla.Name = "chckTekrarla";
            this.chckTekrarla.Size = new System.Drawing.Size(144, 17);
            this.chckTekrarla.TabIndex = 2;
            this.chckTekrarla.Text = "Veri Gönderimini Tekrarla";
            this.chckTekrarla.UseVisualStyleBackColor = true;
            this.chckTekrarla.CheckedChanged += new System.EventHandler(this.chckTekrarla_CheckedChanged);
            // 
            // btnSendData
            // 
            this.btnSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendData.Location = new System.Drawing.Point(170, 251);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(94, 23);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "Gönder";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // grpRandom
            // 
            this.grpRandom.Controls.Add(this.nudRandMax);
            this.grpRandom.Controls.Add(this.label3);
            this.grpRandom.Controls.Add(this.nudRandMin);
            this.grpRandom.Controls.Add(this.label2);
            this.grpRandom.Enabled = false;
            this.grpRandom.Location = new System.Drawing.Point(6, 69);
            this.grpRandom.Name = "grpRandom";
            this.grpRandom.Size = new System.Drawing.Size(264, 76);
            this.grpRandom.TabIndex = 3;
            this.grpRandom.TabStop = false;
            // 
            // nudRandMax
            // 
            this.nudRandMax.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudRandMax.Location = new System.Drawing.Point(132, 45);
            this.nudRandMax.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.nudRandMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRandMax.Name = "nudRandMax";
            this.nudRandMax.Size = new System.Drawing.Size(126, 20);
            this.nudRandMax.TabIndex = 3;
            this.nudRandMax.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRandMax.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "En büyük değer:";
            // 
            // nudRandMin
            // 
            this.nudRandMin.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudRandMin.Location = new System.Drawing.Point(132, 19);
            this.nudRandMin.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.nudRandMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRandMin.Name = "nudRandMin";
            this.nudRandMin.Size = new System.Drawing.Size(126, 20);
            this.nudRandMin.TabIndex = 3;
            this.nudRandMin.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRandMin.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "En küçük değer:";
            // 
            // grpTekrarla
            // 
            this.grpTekrarla.Controls.Add(this.numericUpDown1);
            this.grpTekrarla.Controls.Add(this.label1);
            this.grpTekrarla.Enabled = false;
            this.grpTekrarla.Location = new System.Drawing.Point(6, 19);
            this.grpTekrarla.Name = "grpTekrarla";
            this.grpTekrarla.Size = new System.Drawing.Size(264, 44);
            this.grpTekrarla.TabIndex = 3;
            this.grpTekrarla.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(132, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(126, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekrarlama Süresi(ms) : ";
            // 
            // rtxtGonder
            // 
            this.rtxtGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtGonder.Location = new System.Drawing.Point(6, 151);
            this.rtxtGonder.Name = "rtxtGonder";
            this.rtxtGonder.Size = new System.Drawing.Size(264, 94);
            this.rtxtGonder.TabIndex = 2;
            this.rtxtGonder.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(286, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 424);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 418);
            this.panel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAlnTemizle);
            this.groupBox3.Controls.Add(this.rtxtAlınan);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 418);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alınan Veriler";
            // 
            // btnAlnTemizle
            // 
            this.btnAlnTemizle.Location = new System.Drawing.Point(165, 386);
            this.btnAlnTemizle.Name = "btnAlnTemizle";
            this.btnAlnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnAlnTemizle.TabIndex = 1;
            this.btnAlnTemizle.Text = "Temizle";
            this.btnAlnTemizle.UseVisualStyleBackColor = true;
            this.btnAlnTemizle.Click += new System.EventHandler(this.btnAlnTemizle_Click);
            // 
            // rtxtAlınan
            // 
            this.rtxtAlınan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtAlınan.Location = new System.Drawing.Point(3, 16);
            this.rtxtAlınan.Name = "rtxtAlınan";
            this.rtxtAlınan.ReadOnly = true;
            this.rtxtAlınan.Size = new System.Drawing.Size(240, 364);
            this.rtxtAlınan.TabIndex = 0;
            this.rtxtAlınan.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(255, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 418);
            this.panel3.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGondTemizle);
            this.groupBox4.Controls.Add(this.rtxtGonderilen);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 418);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gönderilen Veriler";
            // 
            // btnGondTemizle
            // 
            this.btnGondTemizle.Location = new System.Drawing.Point(163, 386);
            this.btnGondTemizle.Name = "btnGondTemizle";
            this.btnGondTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnGondTemizle.TabIndex = 1;
            this.btnGondTemizle.Text = "Temizle";
            this.btnGondTemizle.UseVisualStyleBackColor = true;
            this.btnGondTemizle.Click += new System.EventHandler(this.btnGondTemizle_Click);
            // 
            // rtxtGonderilen
            // 
            this.rtxtGonderilen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtGonderilen.Location = new System.Drawing.Point(3, 16);
            this.rtxtGonderilen.Name = "rtxtGonderilen";
            this.rtxtGonderilen.ReadOnly = true;
            this.rtxtGonderilen.Size = new System.Drawing.Size(241, 364);
            this.rtxtGonderilen.TabIndex = 0;
            this.rtxtGonderilen.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeriPort Tester by NoviceHacker®";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.grpVeriGonder.ResumeLayout(false);
            this.grpVeriGonder.PerformLayout();
            this.grpRandom.ResumeLayout(false);
            this.grpRandom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandMin)).EndInit();
            this.grpTekrarla.ResumeLayout(false);
            this.grpTekrarla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrVeriGonder;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private NHSeriBaglanti.SeriBaglanti seriBaglanti1;
        private System.Windows.Forms.GroupBox grpVeriGonder;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.GroupBox grpTekrarla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtGonder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtxtAlınan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtxtGonderilen;
        private System.Windows.Forms.CheckBox chckTekrarla;
        private System.Windows.Forms.CheckBox chckUseRandom;
        private System.Windows.Forms.GroupBox grpRandom;
        private System.Windows.Forms.NumericUpDown nudRandMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRandMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlnTemizle;
        private System.Windows.Forms.Button btnGondTemizle;
    }
}

