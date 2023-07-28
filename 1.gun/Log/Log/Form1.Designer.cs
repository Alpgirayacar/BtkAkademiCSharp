namespace Log
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
            label2 = new Label();
            cmbLogTip = new ComboBox();
            txtBoxHataTipi = new TextBox();
            lblSonuc = new Label();
            btnKayit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 82);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "log Tipi ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 117);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "HataKodu";
            // 
            // cmbLogTip
            // 
            cmbLogTip.AutoCompleteCustomSource.AddRange(new string[] { "jsonLog", "XmlLog", "DbLog" });
            cmbLogTip.FormattingEnabled = true;
            cmbLogTip.Location = new Point(329, 83);
            cmbLogTip.Name = "cmbLogTip";
            cmbLogTip.Size = new Size(121, 23);
            cmbLogTip.TabIndex = 2;
            // 
            // txtBoxHataTipi
            // 
            txtBoxHataTipi.Location = new Point(333, 121);
            txtBoxHataTipi.Name = "txtBoxHataTipi";
            txtBoxHataTipi.Size = new Size(100, 23);
            txtBoxHataTipi.TabIndex = 3;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(226, 210);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(40, 15);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "Sonuc";
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(340, 209);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(75, 23);
            btnKayit.TabIndex = 5;
            btnKayit.Text = "kaydet";
            btnKayit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKayit);
            Controls.Add(lblSonuc);
            Controls.Add(txtBoxHataTipi);
            Controls.Add(cmbLogTip);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbLogTip;
        private TextBox txtBoxHataTipi;
        private Label lblSonuc;
        private Button btnKayit;
    }
}