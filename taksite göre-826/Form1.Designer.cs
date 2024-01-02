namespace taksite_göre_826
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lbTaksit = new System.Windows.Forms.ListBox();
            this.lbSaat = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.numTaksit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTaksit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(36, 29);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lbTaksit
            // 
            this.lbTaksit.FormattingEnabled = true;
            this.lbTaksit.Location = new System.Drawing.Point(315, 29);
            this.lbTaksit.Name = "lbTaksit";
            this.lbTaksit.Size = new System.Drawing.Size(120, 95);
            this.lbTaksit.TabIndex = 1;
            // 
            // lbSaat
            // 
            this.lbSaat.FormattingEnabled = true;
            this.lbSaat.Location = new System.Drawing.Point(459, 29);
            this.lbSaat.Name = "lbSaat";
            this.lbSaat.Size = new System.Drawing.Size(120, 95);
            this.lbSaat.TabIndex = 2;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(36, 75);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 3;
            // 
            // numTaksit
            // 
            this.numTaksit.Location = new System.Drawing.Point(36, 126);
            this.numTaksit.Name = "numTaksit";
            this.numTaksit.Size = new System.Drawing.Size(120, 20);
            this.numTaksit.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numTaksit);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lbSaat);
            this.Controls.Add(this.lbTaksit);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTaksit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox lbTaksit;
        private System.Windows.Forms.ListBox lbSaat;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.NumericUpDown numTaksit;
    }
}

