namespace pryEDZarateF
{
    partial class frmCarreras
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
            this.lstCarrera = new System.Windows.Forms.ListBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCarrera
            // 
            this.lstCarrera.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstCarrera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstCarrera.FormattingEnabled = true;
            this.lstCarrera.ItemHeight = 20;
            this.lstCarrera.Location = new System.Drawing.Point(413, 76);
            this.lstCarrera.Name = "lstCarrera";
            this.lstCarrera.Size = new System.Drawing.Size(337, 162);
            this.lstCarrera.TabIndex = 14;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBienvenido.Location = new System.Drawing.Point(20, 31);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(147, 17);
            this.lblBienvenido.TabIndex = 13;
            this.lblBienvenido.Text = "Bienvenido a carreras";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(21, 81);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(57, 20);
            this.lblCarrera.TabIndex = 12;
            this.lblCarrera.Text = "Carrera";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCarrera.Location = new System.Drawing.Point(83, 76);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(250, 29);
            this.txtNombreCarrera.TabIndex = 11;
            this.txtNombreCarrera.TextChanged += new System.EventHandler(this.txtNombreCarrera_TextChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrabar.Location = new System.Drawing.Point(255, 133);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(78, 36);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(790, 276);
            this.Controls.Add(this.lstCarrera);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.btnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarrera;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Button btnGrabar;
    }
}
