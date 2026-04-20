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
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupMes = new System.Windows.Forms.GroupBox();
            this.groupBienvenido = new System.Windows.Forms.GroupBox();
            this.groupMes.SuspendLayout();
            this.groupBienvenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstMeses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstMeses.ForeColor = System.Drawing.Color.OliveDrab;
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 20;
            this.lstMeses.Location = new System.Drawing.Point(404, 51);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(337, 160);
            this.lstMeses.TabIndex = 14;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(15, 53);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(46, 17);
            this.lblMes.TabIndex = 12;
            this.lblMes.Text = "Meses";
            // 
            // cmbMeses
            // 
            this.cmbMeses.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMeses.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(77, 48);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(250, 29);
            this.cmbMeses.TabIndex = 11;
            this.cmbMeses.TextChanged += new System.EventHandler(this.cmbMeses_TextChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrabar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(247, 86);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 30);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListar.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(159, 86);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(80, 30);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click_1);
            // 
            // groupMes
            // 
            this.groupMes.Controls.Add(this.btnListar);
            this.groupMes.Controls.Add(this.cmbMeses);
            this.groupMes.Controls.Add(this.btnGrabar);
            this.groupMes.Controls.Add(this.lblMes);
            this.groupMes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMes.Location = new System.Drawing.Point(30, 43);
            this.groupMes.Name = "groupMes";
            this.groupMes.Size = new System.Drawing.Size(356, 168);
            this.groupMes.TabIndex = 16;
            this.groupMes.TabStop = false;
            this.groupMes.Text = "Ingrese un mes";
            // 
            // groupBienvenido
            // 
            this.groupBienvenido.Controls.Add(this.groupMes);
            this.groupBienvenido.Controls.Add(this.lstMeses);
            this.groupBienvenido.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBienvenido.Location = new System.Drawing.Point(24, 20);
            this.groupBienvenido.Name = "groupBienvenido";
            this.groupBienvenido.Size = new System.Drawing.Size(776, 238);
            this.groupBienvenido.TabIndex = 17;
            this.groupBienvenido.TabStop = false;
            this.groupBienvenido.Text = "Bienvenido a la sección meses";
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(821, 282);
            this.Controls.Add(this.groupBienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meses";
            this.Load += new System.EventHandler(this.frmMeses_Load);
            this.groupMes.ResumeLayout(false);
            this.groupMes.PerformLayout();
            this.groupBienvenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox groupMes;
        private System.Windows.Forms.GroupBox groupBienvenido;
    }
}
