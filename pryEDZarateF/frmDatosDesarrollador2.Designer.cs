namespace pryEDZarateF
{
    partial class frmDatosDesarrollador2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblSeguir = new System.Windows.Forms.Label();
            this.lblVolver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::pryEDZarateF.Properties.Resources.Logotipo_Estudio_Shonos_Diseño_multimedia_divertido_retro_y2k_rosa__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.FloralWhite;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.Location = new System.Drawing.Point(23, 15);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(20, 20);
            this.lblSalir.TabIndex = 1;
            this.lblSalir.Text = "X";
            // 
            // lblSeguir
            // 
            this.lblSeguir.AutoSize = true;
            this.lblSeguir.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblSeguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguir.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSeguir.Location = new System.Drawing.Point(405, 300);
            this.lblSeguir.Name = "lblSeguir";
            this.lblSeguir.Size = new System.Drawing.Size(18, 20);
            this.lblSeguir.TabIndex = 2;
            this.lblSeguir.Text = ">";
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVolver.Location = new System.Drawing.Point(20, 300);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(18, 20);
            this.lblVolver.TabIndex = 3;
            this.lblVolver.Text = "<";
            // 
            // frmDatosDesarrollador2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(444, 334);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.lblSeguir);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatosDesarrollador2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del desarrollador 2";
            this.Load += new System.EventHandler(this.frmDatosDesarrollador2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblSeguir;
        private System.Windows.Forms.Label lblVolver;
    }
}
