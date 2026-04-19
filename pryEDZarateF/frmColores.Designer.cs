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
            this.lstColor = new System.Windows.Forms.ListBox();
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.groupBienvenido = new System.Windows.Forms.GroupBox();
            this.groupColor.SuspendLayout();
            this.groupBienvenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(144, 69);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(80, 30);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrabar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(232, 69);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 30);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtNombreColor
            // 
            this.txtNombreColor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNombreColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreColor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreColor.Location = new System.Drawing.Point(62, 39);
            this.txtNombreColor.Name = "txtNombreColor";
            this.txtNombreColor.Size = new System.Drawing.Size(250, 22);
            this.txtNombreColor.TabIndex = 3;
            this.txtNombreColor.TextChanged += new System.EventHandler(this.txtNombreColor_TextChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(16, 42);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 17);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color";
            // 
            // lstColor
            // 
            this.lstColor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstColor.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lstColor.FormattingEnabled = true;
            this.lstColor.ItemHeight = 20;
            this.lstColor.Location = new System.Drawing.Point(409, 43);
            this.lstColor.Name = "lstColor";
            this.lstColor.Size = new System.Drawing.Size(337, 140);
            this.lstColor.TabIndex = 8;
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.btnGrabar);
            this.groupColor.Controls.Add(this.lblColor);
            this.groupColor.Controls.Add(this.txtNombreColor);
            this.groupColor.Controls.Add(this.btnListar);
            this.groupColor.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupColor.Location = new System.Drawing.Point(26, 34);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(365, 150);
            this.groupColor.TabIndex = 9;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "Ingresar un color";
            // 
            // groupBienvenido
            // 
            this.groupBienvenido.Controls.Add(this.groupColor);
            this.groupBienvenido.Controls.Add(this.lstColor);
            this.groupBienvenido.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBienvenido.Location = new System.Drawing.Point(23, 21);
            this.groupBienvenido.Name = "groupBienvenido";
            this.groupBienvenido.Size = new System.Drawing.Size(788, 222);
            this.groupBienvenido.TabIndex = 10;
            this.groupBienvenido.TabStop = false;
            this.groupBienvenido.Text = "Bienvenido a la sección colores";
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(823, 268);
            this.Controls.Add(this.groupBienvenido);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores";
            this.Load += new System.EventHandler(this.frmColores_Load);
            this.groupColor.ResumeLayout(false);
            this.groupColor.PerformLayout();
            this.groupBienvenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtNombreColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ListBox lstColor;
        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.GroupBox groupBienvenido;
    }
}
