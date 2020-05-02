namespace bankamatik_simulasyonu
{
    partial class frm_hesaphareketleri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGrid_gonderilem = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGrid_alinan = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_gonderilem)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_alinan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 360);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "GÖNDERİLEN HAREKETLERİ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGrid_gonderilem);
            this.panel3.Location = new System.Drawing.Point(28, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 272);
            this.panel3.TabIndex = 3;
            // 
            // dataGrid_gonderilem
            // 
            this.dataGrid_gonderilem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_gonderilem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_gonderilem.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_gonderilem.Name = "dataGrid_gonderilem";
            this.dataGrid_gonderilem.Size = new System.Drawing.Size(332, 272);
            this.dataGrid_gonderilem.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(395, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 360);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ALINAN HAREKETLERİ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGrid_alinan);
            this.panel2.Location = new System.Drawing.Point(24, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 272);
            this.panel2.TabIndex = 4;
            // 
            // dataGrid_alinan
            // 
            this.dataGrid_alinan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_alinan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_alinan.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_alinan.Name = "dataGrid_alinan";
            this.dataGrid_alinan.Size = new System.Drawing.Size(332, 272);
            this.dataGrid_alinan.TabIndex = 1;
            // 
            // frm_hesaphareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(791, 384);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_hesaphareketleri";
            this.Text = "HESAP HAREKETLERİ";
            this.Load += new System.EventHandler(this.frm_hesaphareketleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_gonderilem)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_alinan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGrid_gonderilem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGrid_alinan;
    }
}