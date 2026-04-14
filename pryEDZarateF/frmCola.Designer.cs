namespace pryEDZarateF
{
    partial class frmCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.grpElemento = new System.Windows.Forms.GroupBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblEliminado = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigo22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.dgvElementos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(30, 131);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNombre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(92, 126);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 29);
            this.txtNombre.TabIndex = 31;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(30, 181);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTramite.Size = new System.Drawing.Size(59, 20);
            this.lblTramite.TabIndex = 30;
            this.lblTramite.Text = "Trámite";
            // 
            // txtTramite
            // 
            this.txtTramite.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTramite.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramite.Location = new System.Drawing.Point(92, 176);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(171, 29);
            this.txtTramite.TabIndex = 29;
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNuevo.Location = new System.Drawing.Point(29, 34);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(112, 17);
            this.lblNuevo.TabIndex = 28;
            this.lblNuevo.Text = "Nuevo Elemento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(30, 84);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtCodigo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(92, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(171, 29);
            this.txtCodigo.TabIndex = 26;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrabar.Location = new System.Drawing.Point(34, 227);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(308, 30);
            this.btnGrabar.TabIndex = 25;
            this.btnGrabar.Text = "Agregar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            // 
            // grpElemento
            // 
            this.grpElemento.Location = new System.Drawing.Point(22, 37);
            this.grpElemento.Name = "grpElemento";
            this.grpElemento.Size = new System.Drawing.Size(342, 242);
            this.grpElemento.TabIndex = 33;
            this.grpElemento.TabStop = false;
            this.grpElemento.Text = "groupBox1";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(392, 131);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(64, 20);
            this.lblNombre2.TabIndex = 41;
            this.lblNombre2.Text = "Nombre";
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite2.Location = new System.Drawing.Point(392, 181);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTramite2.Size = new System.Drawing.Size(59, 20);
            this.lblTramite2.TabIndex = 39;
            this.lblTramite2.Text = "Trámite";
            // 
            // lblEliminado
            // 
            this.lblEliminado.AutoSize = true;
            this.lblEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEliminado.Location = new System.Drawing.Point(391, 34);
            this.lblEliminado.Name = "lblEliminado";
            this.lblEliminado.Size = new System.Drawing.Size(132, 17);
            this.lblEliminado.TabIndex = 37;
            this.lblEliminado.Text = "Elemento Eliminado";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(392, 84);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo2.TabIndex = 36;
            this.lblCodigo2.Text = "Código";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Location = new System.Drawing.Point(396, 227);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(308, 30);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCodigo22);
            this.groupBox1.Location = new System.Drawing.Point(384, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 242);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblCodigo22
            // 
            this.lblCodigo22.AutoSize = true;
            this.lblCodigo22.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblCodigo22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCodigo22.Location = new System.Drawing.Point(75, 50);
            this.lblCodigo22.Name = "lblCodigo22";
            this.lblCodigo22.Size = new System.Drawing.Size(78, 15);
            this.lblCodigo22.TabIndex = 0;
            this.lblCodigo22.Text = "                       ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(76, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "                       ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(76, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "                       ";
            // 
            // lstElementos
            // 
            this.lstElementos.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.Location = new System.Drawing.Point(44, 316);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(320, 95);
            this.lstElementos.TabIndex = 43;
            // 
            // dgvElementos
            // 
            this.dgvElementos.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvElementos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementos.GridColor = System.Drawing.Color.AntiqueWhite;
            this.dgvElementos.Location = new System.Drawing.Point(384, 316);
            this.dgvElementos.Name = "dgvElementos";
            this.dgvElementos.Size = new System.Drawing.Size(320, 95);
            this.dgvElementos.TabIndex = 44;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 153);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Listado en una Lista y una Grilla";
            // 
            // pctImagen
            // 
            this.pctImagen.BackgroundImage = global::pryEDZarateF.Properties.Resources.b10;
            this.pctImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctImagen.InitialImage")));
            this.pctImagen.Location = new System.Drawing.Point(743, 87);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(291, 297);
            this.pctImagen.TabIndex = 46;
            this.pctImagen.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1065, 505);
            this.Controls.Add(this.pctImagen);
            this.Controls.Add(this.dgvElementos);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.lblTramite2);
            this.Controls.Add(this.lblEliminado);
            this.Controls.Add(this.lblCodigo2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTramite);
            this.Controls.Add(this.txtTramite);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.grpElemento);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinámica Lineal - Cola";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox grpElemento;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblEliminado;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigo22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.DataGridView dgvElementos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctImagen;
    }
}