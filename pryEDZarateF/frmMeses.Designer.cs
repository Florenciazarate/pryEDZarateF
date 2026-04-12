namespace pryEDZarateF
{
    partial class frmMeses
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.lblBienvenidoMeses = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtNombreMes = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstMeses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 20;
            this.lstMeses.Location = new System.Drawing.Point(422, 80);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(337, 162);
            this.lstMeses.TabIndex = 14;
            // 
            // lblBienvenidoMeses
            // 
            this.lblBienvenidoMeses.AutoSize = true;
            this.lblBienvenidoMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBienvenidoMeses.Location = new System.Drawing.Point(29, 35);
            this.lblBienvenidoMeses.Name = "lblBienvenidoMeses";
            this.lblBienvenidoMeses.Size = new System.Drawing.Size(135, 17);
            this.lblBienvenidoMeses.TabIndex = 13;
            this.lblBienvenidoMeses.Text = "Bienvenido a meses";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(30, 85);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(50, 20);
            this.lblMes.TabIndex = 12;
            this.lblMes.Text = "Meses";
            // 
            // txtNombreMes
            // 
            this.txtNombreMes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMes.Location = new System.Drawing.Point(92, 80);
            this.txtNombreMes.Name = "txtNombreMes";
            this.txtNombreMes.Size = new System.Drawing.Size(250, 29);
            this.txtNombreMes.TabIndex = 11;
            this.txtNombreMes.TextChanged += new System.EventHandler(this.txtNombreMes_TextChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrabar.Location = new System.Drawing.Point(264, 137);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(78, 36);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListar.Location = new System.Drawing.Point(178, 137);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(78, 36);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.lblBienvenidoMeses);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.txtNombreMes);
            this.Controls.Add(this.btnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Label lblBienvenidoMeses;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtNombreMes;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnListar;
    }
}
