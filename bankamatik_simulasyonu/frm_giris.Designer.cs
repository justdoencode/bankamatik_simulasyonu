namespace bankamatik_simulasyonu
{
    partial class frm_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_giris));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hesapno = new System.Windows.Forms.TextBox();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_kayit = new System.Windows.Forms.LinkLabel();
            this.btn_giris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap Numarası :";
            // 
            // txt_hesapno
            // 
            this.txt_hesapno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hesapno.Location = new System.Drawing.Point(158, 23);
            this.txt_hesapno.Name = "txt_hesapno";
            this.txt_hesapno.Size = new System.Drawing.Size(100, 23);
            this.txt_hesapno.TabIndex = 1;
            // 
            // txt_parola
            // 
            this.txt_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_parola.Location = new System.Drawing.Point(158, 52);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(100, 23);
            this.txt_parola.TabIndex = 3;
            this.txt_parola.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lbl_kayit);
            this.panel1.Controls.Add(this.btn_giris);
            this.panel1.Controls.Add(this.txt_hesapno);
            this.panel1.Controls.Add(this.txt_parola);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(104, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 151);
            this.panel1.TabIndex = 4;
            // 
            // lbl_kayit
            // 
            this.lbl_kayit.AutoSize = true;
            this.lbl_kayit.Location = new System.Drawing.Point(66, 101);
            this.lbl_kayit.Name = "lbl_kayit";
            this.lbl_kayit.Size = new System.Drawing.Size(55, 13);
            this.lbl_kayit.TabIndex = 5;
            this.lbl_kayit.TabStop = true;
            this.lbl_kayit.Text = "KAYIT OL";
            this.lbl_kayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_kayit_LinkClicked);
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(158, 92);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 338);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hesapno;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbl_kayit;
        private System.Windows.Forms.Button btn_giris;
    }
}

