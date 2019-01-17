namespace Delegate
{
    partial class Form1
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
            this.dgv_w = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ortalama = new System.Windows.Forms.Button();
            this.btn_sonBirAy = new System.Windows.Forms.Button();
            this.btn_heftelikIS = new System.Windows.Forms.Button();
            this.btn_maasOrtaYuxari = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_orta = new System.Windows.Forms.Label();
            this.cmbx_worker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_w)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_w
            // 
            this.dgv_w.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_w.Location = new System.Drawing.Point(12, 12);
            this.dgv_w.Name = "dgv_w";
            this.dgv_w.RowTemplate.Height = 24;
            this.dgv_w.Size = new System.Drawing.Size(545, 233);
            this.dgv_w.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ortalama
            // 
            this.btn_ortalama.Location = new System.Drawing.Point(59, 135);
            this.btn_ortalama.Name = "btn_ortalama";
            this.btn_ortalama.Size = new System.Drawing.Size(302, 39);
            this.btn_ortalama.TabIndex = 1;
            this.btn_ortalama.Text = "Maas Ortalamsai";
            this.btn_ortalama.UseVisualStyleBackColor = true;
            this.btn_ortalama.Click += new System.EventHandler(this.btn_ortalama_Click);
            // 
            // btn_sonBirAy
            // 
            this.btn_sonBirAy.Location = new System.Drawing.Point(59, 239);
            this.btn_sonBirAy.Name = "btn_sonBirAy";
            this.btn_sonBirAy.Size = new System.Drawing.Size(302, 42);
            this.btn_sonBirAy.TabIndex = 1;
            this.btn_sonBirAy.Text = "Son Bir Ayda En Cox islieyen";
            this.btn_sonBirAy.UseVisualStyleBackColor = true;
            // 
            // btn_heftelikIS
            // 
            this.btn_heftelikIS.Location = new System.Drawing.Point(59, 296);
            this.btn_heftelikIS.Name = "btn_heftelikIS";
            this.btn_heftelikIS.Size = new System.Drawing.Size(302, 46);
            this.btn_heftelikIS.TabIndex = 1;
            this.btn_heftelikIS.Text = "Heftelik isleme saati 30 dan az olan isciler";
            this.btn_heftelikIS.UseVisualStyleBackColor = true;
            this.btn_heftelikIS.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_maasOrtaYuxari
            // 
            this.btn_maasOrtaYuxari.Location = new System.Drawing.Point(59, 189);
            this.btn_maasOrtaYuxari.Name = "btn_maasOrtaYuxari";
            this.btn_maasOrtaYuxari.Size = new System.Drawing.Size(302, 44);
            this.btn_maasOrtaYuxari.TabIndex = 1;
            this.btn_maasOrtaYuxari.Text = "Maasi ortalamadan Yuxari olanlar";
            this.btn_maasOrtaYuxari.UseVisualStyleBackColor = true;
            this.btn_maasOrtaYuxari.Click += new System.EventHandler(this.btn_maasOrtaYuxari_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ortalama);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_sonBirAy);
            this.groupBox1.Controls.Add(this.btn_maasOrtaYuxari);
            this.groupBox1.Controls.Add(this.btn_heftelikIS);
            this.groupBox1.Location = new System.Drawing.Point(573, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 391);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPTIOS";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1217, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 10);
            this.button3.TabIndex = 1;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(632, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(323, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bütün işçilər";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_orta
            // 
            this.lbl_orta.AutoSize = true;
            this.lbl_orta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_orta.Location = new System.Drawing.Point(1008, 158);
            this.lbl_orta.Name = "lbl_orta";
            this.lbl_orta.Size = new System.Drawing.Size(218, 18);
            this.lbl_orta.TabIndex = 4;
            this.lbl_orta.Text = "ortalama burda göstəriləcək";
            // 
            // cmbx_worker
            // 
            this.cmbx_worker.FormattingEnabled = true;
            this.cmbx_worker.Location = new System.Drawing.Point(12, 299);
            this.cmbx_worker.Name = "cmbx_worker";
            this.cmbx_worker.Size = new System.Drawing.Size(545, 24);
            this.cmbx_worker.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1235, 636);
            this.Controls.Add(this.lbl_orta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbx_worker);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_w);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_w)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_w;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ortalama;
        private System.Windows.Forms.Button btn_sonBirAy;
        private System.Windows.Forms.Button btn_heftelikIS;
        private System.Windows.Forms.Button btn_maasOrtaYuxari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_orta;
        private System.Windows.Forms.ComboBox cmbx_worker;
        private System.Windows.Forms.Button button3;
    }
}

