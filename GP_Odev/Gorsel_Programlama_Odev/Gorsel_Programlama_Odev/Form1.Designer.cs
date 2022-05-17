namespace Gorsel_Programlama_Odev
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
            this.lblListe = new System.Windows.Forms.ListBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnSoru1 = new System.Windows.Forms.Button();
            this.btnSoru2 = new System.Windows.Forms.Button();
            this.btnSoru3 = new System.Windows.Forms.Button();
            this.btnSoru4 = new System.Windows.Forms.Button();
            this.btnSoru5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListe
            // 
            this.lblListe.FormattingEnabled = true;
            this.lblListe.ItemHeight = 20;
            this.lblListe.Location = new System.Drawing.Point(331, 45);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(155, 304);
            this.lblListe.TabIndex = 0;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(331, 368);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(50, 20);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "label2";
            // 
            // btnSoru1
            // 
            this.btnSoru1.Location = new System.Drawing.Point(106, 45);
            this.btnSoru1.Name = "btnSoru1";
            this.btnSoru1.Size = new System.Drawing.Size(94, 56);
            this.btnSoru1.TabIndex = 3;
            this.btnSoru1.Text = "Soru 1";
            this.btnSoru1.UseVisualStyleBackColor = true;
            this.btnSoru1.Click += new System.EventHandler(this.btnSoru1_Click);
            // 
            // btnSoru2
            // 
            this.btnSoru2.Location = new System.Drawing.Point(106, 107);
            this.btnSoru2.Name = "btnSoru2";
            this.btnSoru2.Size = new System.Drawing.Size(94, 56);
            this.btnSoru2.TabIndex = 4;
            this.btnSoru2.Text = "Soru 2";
            this.btnSoru2.UseVisualStyleBackColor = true;
            this.btnSoru2.Click += new System.EventHandler(this.btnSoru2_Click);
            // 
            // btnSoru3
            // 
            this.btnSoru3.Location = new System.Drawing.Point(106, 169);
            this.btnSoru3.Name = "btnSoru3";
            this.btnSoru3.Size = new System.Drawing.Size(94, 56);
            this.btnSoru3.TabIndex = 5;
            this.btnSoru3.Text = "Soru 3";
            this.btnSoru3.UseVisualStyleBackColor = true;
            this.btnSoru3.Click += new System.EventHandler(this.btnSoru3_Click);
            // 
            // btnSoru4
            // 
            this.btnSoru4.Location = new System.Drawing.Point(106, 231);
            this.btnSoru4.Name = "btnSoru4";
            this.btnSoru4.Size = new System.Drawing.Size(94, 56);
            this.btnSoru4.TabIndex = 6;
            this.btnSoru4.Text = "Soru 4";
            this.btnSoru4.UseVisualStyleBackColor = true;
            this.btnSoru4.Click += new System.EventHandler(this.btnSoru4_Click);
            // 
            // btnSoru5
            // 
            this.btnSoru5.Location = new System.Drawing.Point(106, 293);
            this.btnSoru5.Name = "btnSoru5";
            this.btnSoru5.Size = new System.Drawing.Size(94, 56);
            this.btnSoru5.TabIndex = 7;
            this.btnSoru5.Text = "Soru 5";
            this.btnSoru5.UseVisualStyleBackColor = true;
            this.btnSoru5.Click += new System.EventHandler(this.btnSoru5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 517);
            this.Controls.Add(this.btnSoru5);
            this.Controls.Add(this.btnSoru4);
            this.Controls.Add(this.btnSoru3);
            this.Controls.Add(this.btnSoru2);
            this.Controls.Add(this.btnSoru1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lblListe;
        private Label lblSonuc;
        private Button btnSoru1;
        private Button btnSoru2;
        private Button btnSoru3;
        private Button btnSoru4;
        private Button btnSoru5;
    }
}