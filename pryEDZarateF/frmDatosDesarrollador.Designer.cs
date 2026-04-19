namespace pryEDZarateF
{
    partial class frmDatosDesarrollador
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
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pctDatos = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.FloralWhite;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.Navy;
            this.lblSalir.Location = new System.Drawing.Point(20, 17);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(20, 20);
            this.lblSalir.TabIndex = 3;
            this.lblSalir.Text = "X";
            this.lblSalir.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.AutoSize = true;
            this.lblSiguiente.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblSiguiente.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiguiente.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSiguiente.Location = new System.Drawing.Point(397, 297);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(25, 26);
            this.lblSiguiente.TabIndex = 4;
            this.lblSiguiente.Text = ">";
            this.lblSiguiente.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(18, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "<";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnSiguiente.Location = new System.Drawing.Point(400, 299);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(22, 23);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "button1";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctDatos
            // 
            this.pctDatos.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pctDatos.BackgroundImage = global::pryEDZarateF.Properties.Resources.Logotipo_Estudio_Shonos_Diseño_multimedia_divertido_retro_y2k_rosa1;
            this.pctDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctDatos.Location = new System.Drawing.Point(1, -67);
            this.pctDatos.Name = "pctDatos";
            this.pctDatos.Size = new System.Drawing.Size(444, 498);
            this.pctDatos.TabIndex = 0;
            this.pctDatos.TabStop = false;
            this.pctDatos.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSalir.Location = new System.Drawing.Point(16, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmDatosDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(444, 334);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSiguiente);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pctDatos);
            this.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatosDesarrollador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del desarrollador";
            this.Load += new System.EventHandler(this.frmDatosDesarrollador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDatos;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblSiguiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnSalir;
    }
}