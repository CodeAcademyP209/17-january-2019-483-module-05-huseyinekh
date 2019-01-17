namespace Delegate
{
    partial class workersPanel
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_isSaati = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_workDate = new System.Windows.Forms.DateTimePicker();
            this.btn_comfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_addWorker = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(162, 40);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(227, 22);
            this.txt_name.TabIndex = 0;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(162, 79);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(227, 22);
            this.txt_surname.TabIndex = 0;
            // 
            // txt_isSaati
            // 
            this.txt_isSaati.Location = new System.Drawing.Point(162, 196);
            this.txt_isSaati.Name = "txt_isSaati";
            this.txt_isSaati.Size = new System.Drawing.Size(227, 22);
            this.txt_isSaati.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(162, 117);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(227, 22);
            this.txt_email.TabIndex = 0;
            // 
            // txt_maas
            // 
            this.txt_maas.Location = new System.Drawing.Point(162, 156);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(227, 22);
            this.txt_maas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtp_workDate);
            this.groupBox1.Controls.Add(this.btn_comfirm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_surname);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_maas);
            this.groupBox1.Controls.Add(this.txt_isSaati);
            this.groupBox1.Location = new System.Drawing.Point(74, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Registration";
            // 
            // dtp_workDate
            // 
            this.dtp_workDate.Location = new System.Drawing.Point(162, 240);
            this.dtp_workDate.Name = "dtp_workDate";
            this.dtp_workDate.Size = new System.Drawing.Size(227, 22);
            this.dtp_workDate.TabIndex = 3;
            // 
            // btn_comfirm
            // 
            this.btn_comfirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_comfirm.Location = new System.Drawing.Point(36, 311);
            this.btn_comfirm.Name = "btn_comfirm";
            this.btn_comfirm.Size = new System.Drawing.Size(353, 38);
            this.btn_comfirm.TabIndex = 2;
            this.btn_comfirm.Text = "Comfirm";
            this.btn_comfirm.UseVisualStyleBackColor = false;
            this.btn_comfirm.Click += new System.EventHandler(this.btn_comfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "isleme vaxti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Maas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // dgv_addWorker
            // 
            this.dgv_addWorker.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgv_addWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addWorker.Location = new System.Drawing.Point(515, 39);
            this.dgv_addWorker.Name = "dgv_addWorker";
            this.dgv_addWorker.RowTemplate.Height = 24;
            this.dgv_addWorker.Size = new System.Drawing.Size(634, 362);
            this.dgv_addWorker.TabIndex = 3;
            // 
            // workersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 496);
            this.Controls.Add(this.dgv_addWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "workersPanel";
            this.Text = "Add Worker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_isSaati;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_addWorker;
        private System.Windows.Forms.Button btn_comfirm;
        private System.Windows.Forms.DateTimePicker dtp_workDate;
        private System.Windows.Forms.Label label7;
    }
}