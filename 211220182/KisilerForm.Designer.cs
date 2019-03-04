namespace _211220182
{
    partial class Form2
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
            this.groupBxKisiler = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtBxTc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTxtBxİs = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBxCep = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGet = new System.Windows.Forms.Button();
            this.groupBxKisiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBxKisiler
            // 
            this.groupBxKisiler.Controls.Add(this.btnKaydet);
            this.groupBxKisiler.Controls.Add(this.txtBxTc);
            this.groupBxKisiler.Controls.Add(this.label6);
            this.groupBxKisiler.Controls.Add(this.txtBxEmail);
            this.groupBxKisiler.Controls.Add(this.label5);
            this.groupBxKisiler.Controls.Add(this.maskedTxtBxİs);
            this.groupBxKisiler.Controls.Add(this.maskedTxtBxCep);
            this.groupBxKisiler.Controls.Add(this.label4);
            this.groupBxKisiler.Controls.Add(this.label3);
            this.groupBxKisiler.Controls.Add(this.txtBxSoyad);
            this.groupBxKisiler.Controls.Add(this.label2);
            this.groupBxKisiler.Controls.Add(this.txtName);
            this.groupBxKisiler.Controls.Add(this.label1);
            this.groupBxKisiler.Location = new System.Drawing.Point(21, 21);
            this.groupBxKisiler.Name = "groupBxKisiler";
            this.groupBxKisiler.Size = new System.Drawing.Size(243, 405);
            this.groupBxKisiler.TabIndex = 0;
            this.groupBxKisiler.TabStop = false;
            this.groupBxKisiler.Text = "Kişiler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(56, 343);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 45);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtBxTc
            // 
            this.txtBxTc.Location = new System.Drawing.Point(91, 262);
            this.txtBxTc.Name = "txtBxTc";
            this.txtBxTc.Size = new System.Drawing.Size(100, 20);
            this.txtBxTc.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tc Kimlik";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(91, 220);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBxEmail.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // maskedTxtBxİs
            // 
            this.maskedTxtBxİs.Location = new System.Drawing.Point(91, 179);
            this.maskedTxtBxİs.Mask = "(999) 000-0000";
            this.maskedTxtBxİs.Name = "maskedTxtBxİs";
            this.maskedTxtBxİs.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtBxİs.TabIndex = 9;
            // 
            // maskedTxtBxCep
            // 
            this.maskedTxtBxCep.Location = new System.Drawing.Point(91, 137);
            this.maskedTxtBxCep.Mask = "(999) 000-0000";
            this.maskedTxtBxCep.Name = "maskedTxtBxCep";
            this.maskedTxtBxCep.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtBxCep.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "İş Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cep Tel";
            // 
            // txtBxSoyad
            // 
            this.txtBxSoyad.Location = new System.Drawing.Point(91, 96);
            this.txtBxSoyad.Name = "txtBxSoyad";
            this.txtBxSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtBxSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 321);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(566, 386);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(124, 40);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Getir";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 511);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBxKisiler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBxKisiler.ResumeLayout(false);
            this.groupBxKisiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBxKisiler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxİs;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxCep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtBxTc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGet;
    }
}