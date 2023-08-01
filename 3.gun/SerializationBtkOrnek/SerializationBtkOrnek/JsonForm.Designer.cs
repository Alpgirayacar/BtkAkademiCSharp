namespace SerializationBtkOrnek
{
    partial class JsonForm
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
            btnDosyayaYaz = new Button();
            btnJsonOku = new Button();
            SuspendLayout();
            // 
            // btnDosyayaYaz
            // 
            btnDosyayaYaz.Location = new Point(176, 125);
            btnDosyayaYaz.Name = "btnDosyayaYaz";
            btnDosyayaYaz.Size = new Size(120, 23);
            btnDosyayaYaz.TabIndex = 0;
            btnDosyayaYaz.Text = "Dosyaya Yaz";
            btnDosyayaYaz.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDosyayaYaz.UseVisualStyleBackColor = true;
            btnDosyayaYaz.Click += btnDosyayaYaz_Click;
            // 
            // btnJsonOku
            // 
            btnJsonOku.Location = new Point(382, 128);
            btnJsonOku.Name = "btnJsonOku";
            btnJsonOku.Size = new Size(111, 23);
            btnJsonOku.TabIndex = 1;
            btnJsonOku.Text = "Json Oku";
            btnJsonOku.UseVisualStyleBackColor = true;
            btnJsonOku.Click += btnJsonOku_Click;
            // 
            // JsonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnJsonOku);
            Controls.Add(btnDosyayaYaz);
            Name = "JsonForm";
            Text = "JsonForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDosyayaYaz;
        private Button btnJsonOku;
    }
}