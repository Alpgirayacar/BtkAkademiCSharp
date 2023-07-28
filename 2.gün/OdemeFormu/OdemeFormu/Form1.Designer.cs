namespace OdemeFormu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txttutar = new TextBox();
            btnOdemeYap = new Button();
            label2 = new Label();
            cmbOdemeTipi = new ComboBox();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 136);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Tutar :";
            // 
            // txttutar
            // 
            txttutar.Location = new Point(343, 133);
            txttutar.Name = "txttutar";
            txttutar.Size = new Size(119, 23);
            txttutar.TabIndex = 1;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(343, 195);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(119, 32);
            btnOdemeYap.TabIndex = 2;
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 82);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = " Ödeme Tipi :";
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Items.AddRange(new object[] { "Seçiniz", "KrediKarti", "MailOrder", "SmsOdeme" });
            cmbOdemeTipi.Location = new Point(341, 82);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(121, 23);
            cmbOdemeTipi.TabIndex = 4;
            cmbOdemeTipi.SelectedIndexChanged += cmbOdemeTipi_SelectedIndexChanged;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(241, 296);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(46, 15);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 522);
            Controls.Add(lblSonuc);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(label2);
            Controls.Add(btnOdemeYap);
            Controls.Add(txttutar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txttutar;
        private Button btnOdemeYap;
        private Label label2;
        private ComboBox cmbOdemeTipi;
        private Label lblSonuc;
    }
}