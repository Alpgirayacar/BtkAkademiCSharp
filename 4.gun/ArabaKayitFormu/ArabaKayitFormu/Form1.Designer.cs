namespace ArabaKayitFormu
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
            cmbMarka = new ComboBox();
            label2 = new Label();
            cmbModel = new ComboBox();
            label3 = new Label();
            cmbKasa = new ComboBox();
            label4 = new Label();
            txtKapiSayisi = new TextBox();
            label5 = new Label();
            txtPencereSayisi = new TextBox();
            btnSiparisVer = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 69);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Marka : ";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(365, 61);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(121, 23);
            cmbMarka.TabIndex = 1;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 112);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Model :";
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(365, 112);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(121, 23);
            cmbModel.TabIndex = 3;
            cmbModel.SelectedIndexChanged += cmbModel_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 164);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Kasa :";
            // 
            // cmbKasa
            // 
            cmbKasa.FormattingEnabled = true;
            cmbKasa.Location = new Point(364, 164);
            cmbKasa.Name = "cmbKasa";
            cmbKasa.Size = new Size(121, 23);
            cmbKasa.TabIndex = 5;
            cmbKasa.SelectedIndexChanged += cmbKasa_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 232);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Kapı :";
            // 
            // txtKapiSayisi
            // 
            txtKapiSayisi.Location = new Point(365, 229);
            txtKapiSayisi.Name = "txtKapiSayisi";
            txtKapiSayisi.Size = new Size(117, 23);
            txtKapiSayisi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 283);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Pencere :";
            // 
            // txtPencereSayisi
            // 
            txtPencereSayisi.Location = new Point(365, 275);
            txtPencereSayisi.Name = "txtPencereSayisi";
            txtPencereSayisi.Size = new Size(117, 23);
            txtPencereSayisi.TabIndex = 9;
            // 
            // btnSiparisVer
            // 
            btnSiparisVer.Location = new Point(387, 332);
            btnSiparisVer.Name = "btnSiparisVer";
            btnSiparisVer.Size = new Size(75, 23);
            btnSiparisVer.TabIndex = 10;
            btnSiparisVer.Text = "Sipariş Ver";
            btnSiparisVer.UseVisualStyleBackColor = true;
            btnSiparisVer.Click += btnSiparisVer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 372);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(720, 150);
            dataGridView1.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 534);
            Controls.Add(dataGridView1);
            Controls.Add(btnSiparisVer);
            Controls.Add(txtPencereSayisi);
            Controls.Add(label5);
            Controls.Add(txtKapiSayisi);
            Controls.Add(label4);
            Controls.Add(cmbKasa);
            Controls.Add(label3);
            Controls.Add(cmbModel);
            Controls.Add(label2);
            Controls.Add(cmbMarka);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMarka;
        private Label label2;
        private ComboBox cmbModel;
        private Label label3;
        private ComboBox cmbKasa;
        private Label label4;
        private TextBox txtKapiSayisi;
        private Label label5;
        private TextBox txtPencereSayisi;
        private Button btnSiparisVer;
        private DataGridView dataGridView1;
    }
}