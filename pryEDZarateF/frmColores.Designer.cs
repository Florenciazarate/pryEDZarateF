namespace pryEDZarateF
{
    partial class frmColores
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtNombreColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lstColor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(196, 138);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(70, 36);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrabar.Location = new System.Drawing.Point(274, 138);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(78, 36);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtNombreColor
            // 
            this.txtNombreColor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreColor.Location = new System.Drawing.Point(102, 81);
            this.txtNombreColor.Name = "txtNombreColor";
            this.txtNombreColor.Size = new System.Drawing.Size(250, 29);
            this.txtNombreColor.TabIndex = 3;
            this.txtNombreColor.TextChanged += new System.EventHandler(this.txtNombreColor_TextChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(40, 86);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 20);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBienvenido.Location = new System.Drawing.Point(39, 36);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(140, 17);
            this.lblBienvenido.TabIndex = 7;
            this.lblBienvenido.Text = "Bienvenido a colores";
            // 
            // lstColor
            // 
            this.lstColor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstColor.FormattingEnabled = true;
            this.lstColor.ItemHeight = 20;
            this.lstColor.Location = new System.Drawing.Point(432, 81);
            this.lstColor.Name = "lstColor";
            this.lstColor.Size = new System.Drawing.Size(337, 144);
            this.lstColor.TabIndex = 8;
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(823, 293);
            this.Controls.Add(this.lstColor);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtNombreColor);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnListar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtNombreColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.ListBox lstColor;
    }
}
