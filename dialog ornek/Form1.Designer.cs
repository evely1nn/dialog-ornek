namespace dialog_ornek
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
            this.btnResim = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.rtbMesaj = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResim
            // 
            this.btnResim.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResim.Location = new System.Drawing.Point(12, 38);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(109, 40);
            this.btnResim.TabIndex = 0;
            this.btnResim.Text = "Resim Seç";
            this.btnResim.UseVisualStyleBackColor = true;
            // 
            // btnRenk
            // 
            this.btnRenk.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenk.Location = new System.Drawing.Point(280, 38);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(109, 40);
            this.btnRenk.TabIndex = 1;
            this.btnRenk.Text = "Renk Değiştir";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "|*.png*.jpeg*.jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(12, 114);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(216, 235);
            this.pbResim.TabIndex = 2;
            this.pbResim.TabStop = false;
            // 
            // rtbMesaj
            // 
            this.rtbMesaj.Location = new System.Drawing.Point(280, 114);
            this.rtbMesaj.Name = "rtbMesaj";
            this.rtbMesaj.Size = new System.Drawing.Size(216, 235);
            this.rtbMesaj.TabIndex = 3;
            this.rtbMesaj.Text = "RAVZA\nNURSEVİM\nHİLAL\nYEZDA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(547, 361);
            this.Controls.Add(this.rtbMesaj);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.btnResim);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.RichTextBox rtbMesaj;
    }
}

