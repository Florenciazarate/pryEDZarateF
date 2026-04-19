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
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupCarrera = new System.Windows.Forms.GroupBox();
            this.groupBienvenido = new System.Windows.Forms.GroupBox();
            this.groupBienvenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCarrera
            // 
            this.lstCarrera.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstCarrera.FormattingEnabled = true;
            this.lstCarrera.ItemHeight = 20;
            this.lstCarrera.Location = new System.Drawing.Point(423, 48);
            this.lstCarrera.Name = "lstCarrera";
            this.lstCarrera.Size = new System.Drawing.Size(337, 140);
            this.lstCarrera.TabIndex = 14;
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
            this.btnGrabar.Location = new System.Drawing.Point(273, 127);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(78, 36);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // groupCarrera
            // 
            this.groupCarrera.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCarrera.Location = new System.Drawing.Point(30, 42);
            this.groupCarrera.Name = "groupCarrera";
            this.groupCarrera.Size = new System.Drawing.Size(378, 148);
            this.groupCarrera.TabIndex = 15;
            this.groupCarrera.TabStop = false;
            this.groupCarrera.Text = "Ingrese una carrera";
            // 
            // groupBienvenido
            // 
            this.groupBienvenido.Controls.Add(this.lstCarrera);
            this.groupBienvenido.Controls.Add(this.txtNombreCarrera);
            this.groupBienvenido.Controls.Add(this.lblCarrera);
            this.groupBienvenido.Controls.Add(this.groupCarrera);
            this.groupBienvenido.Controls.Add(this.btnGrabar);
            this.groupBienvenido.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBienvenido.Location = new System.Drawing.Point(19, 12);
            this.groupBienvenido.Name = "groupBienvenido";
            this.groupBienvenido.Size = new System.Drawing.Size(809, 221);
            this.groupBienvenido.TabIndex = 16;
            this.groupBienvenido.TabStop = false;
            this.groupBienvenido.Text = "Bienvenido al apartado carreras";
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(846, 249);
            this.Controls.Add(this.groupBienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreras";
            this.groupBienvenido.ResumeLayout(false);
            this.groupBienvenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox groupCarrera;
        private System.Windows.Forms.GroupBox groupBienvenido;
    }
}
