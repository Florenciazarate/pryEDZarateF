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
            this.Carreras = new System.Windows.Forms.ListBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupCarrera = new System.Windows.Forms.GroupBox();
            this.groupBienvenido = new System.Windows.Forms.GroupBox();
            this.groupCarrera.SuspendLayout();
            this.groupBienvenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // Carreras
            // 
            this.Carreras.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Carreras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Carreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Carreras.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Carreras.FormattingEnabled = true;
            this.Carreras.ItemHeight = 20;
            this.Carreras.Location = new System.Drawing.Point(357, 50);
            this.Carreras.Name = "Carreras";
            this.Carreras.Size = new System.Drawing.Size(337, 140);
            this.Carreras.TabIndex = 14;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(39, 92);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(57, 20);
            this.lblCarrera.TabIndex = 12;
            this.lblCarrera.Text = "Carrera";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNombreCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCarrera.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCarrera.Location = new System.Drawing.Point(101, 91);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(200, 22);
            this.txtNombreCarrera.TabIndex = 11;
            this.txtNombreCarrera.TextChanged += new System.EventHandler(this.txtNombreCarrera_TextChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrabar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(191, 80);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 30);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // groupCarrera
            // 
            this.groupCarrera.Controls.Add(this.btnGrabar);
            this.groupCarrera.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCarrera.Location = new System.Drawing.Point(29, 42);
            this.groupCarrera.Name = "groupCarrera";
            this.groupCarrera.Size = new System.Drawing.Size(300, 148);
            this.groupCarrera.TabIndex = 15;
            this.groupCarrera.TabStop = false;
            this.groupCarrera.Text = "Ingrese una carrera";
            // 
            // groupBienvenido
            // 
            this.groupBienvenido.Controls.Add(this.Carreras);
            this.groupBienvenido.Controls.Add(this.txtNombreCarrera);
            this.groupBienvenido.Controls.Add(this.lblCarrera);
            this.groupBienvenido.Controls.Add(this.groupCarrera);
            this.groupBienvenido.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBienvenido.Location = new System.Drawing.Point(27, 12);
            this.groupBienvenido.Name = "groupBienvenido";
            this.groupBienvenido.Size = new System.Drawing.Size(725, 221);
            this.groupBienvenido.TabIndex = 16;
            this.groupBienvenido.TabStop = false;
            this.groupBienvenido.Text = "Bienvenido a la sección carreras";
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(778, 249);
            this.Controls.Add(this.groupBienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreras";
            this.groupCarrera.ResumeLayout(false);
            this.groupBienvenido.ResumeLayout(false);
            this.groupBienvenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Carreras;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox groupCarrera;
        private System.Windows.Forms.GroupBox groupBienvenido;
    }
}
