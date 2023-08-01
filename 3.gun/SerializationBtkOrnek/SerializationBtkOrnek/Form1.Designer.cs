namespace SerializationBtkOrnek
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
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtMaas = new TextBox();
            txtDepartman = new TextBox();
            txtTelefon = new TextBox();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(455, 334);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 23;
            button2.Text = "DeSerialized";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(260, 334);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Serialized";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(387, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(386, 256);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(100, 23);
            txtMaas.TabIndex = 20;
            // 
            // txtDepartman
            // 
            txtDepartman.Location = new Point(386, 220);
            txtDepartman.Name = "txtDepartman";
            txtDepartman.Size = new Size(100, 23);
            txtDepartman.TabIndex = 19;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(386, 137);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 18;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(386, 98);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 256);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 16;
            label5.Text = "Maaş :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 223);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 15;
            label4.Text = "Departman :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 182);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 14;
            label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 137);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 13;
            label2.Text = "Telefon :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 94);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 12;
            label1.Text = "Ad:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtMaas);
            Controls.Add(txtDepartman);
            Controls.Add(txtTelefon);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMaas;
        private TextBox txtDepartman;
        private TextBox txtTelefon;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}