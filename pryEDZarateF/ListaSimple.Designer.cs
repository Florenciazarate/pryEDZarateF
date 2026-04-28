namespace pryEDZarateF
{
    partial class ListaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaSimple));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvElementos = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblEliminado = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramiteEliminado = new System.Windows.Forms.Label();
            this.lblNombreEliminado = new System.Windows.Forms.Label();
            this.lblCodigo22 = new System.Windows.Forms.Label();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.grpElemento = new System.Windows.Forms.GroupBox();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).BeginInit();
            this.grpEliminado.SuspendLayout();
            this.grpElemento.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(93, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 22);
            this.txtNombre.TabIndex = 69;
            // 
            // dgvElementos
            // 
            this.dgvElementos.AllowUserToAddRows = false;
            this.dgvElementos.AllowUserToDeleteRows = false;
            this.dgvElementos.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvElementos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvElementos.GridColor = System.Drawing.Color.AntiqueWhite;
            this.dgvElementos.Location = new System.Drawing.Point(385, 307);
            this.dgvElementos.Name = "dgvElementos";
            this.dgvElementos.ReadOnly = true;
            this.dgvElementos.Size = new System.Drawing.Size(320, 104);
            this.dgvElementos.TabIndex = 78;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmTramite
            // 
            this.clmTramite.HeaderText = "Trámite";
            this.clmTramite.Name = "clmTramite";
            this.clmTramite.ReadOnly = true;
            // 
            // lstElementos
            // 
            this.lstElementos.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstElementos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.Location = new System.Drawing.Point(45, 307);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(320, 104);
            this.lstElementos.TabIndex = 77;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(393, 110);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(64, 20);
            this.lblNombre2.TabIndex = 75;
            this.lblNombre2.Text = "Nombre";
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite2.Location = new System.Drawing.Point(393, 146);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTramite2.Size = new System.Drawing.Size(59, 20);
            this.lblTramite2.TabIndex = 74;
            this.lblTramite2.Text = "Trámite";
            // 
            // lblEliminado
            // 
            this.lblEliminado.AutoSize = true;
            this.lblEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEliminado.Location = new System.Drawing.Point(392, 26);
            this.lblEliminado.Name = "lblEliminado";
            this.lblEliminado.Size = new System.Drawing.Size(132, 17);
            this.lblEliminado.TabIndex = 73;
            this.lblEliminado.Text = "Elemento Eliminado";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(393, 76);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo2.TabIndex = 72;
            this.lblCodigo2.Text = "Código";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Location = new System.Drawing.Point(397, 219);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(308, 30);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // grpEliminado
            // 
            this.grpEliminado.Controls.Add(this.lblTramiteEliminado);
            this.grpEliminado.Controls.Add(this.lblNombreEliminado);
            this.grpEliminado.Controls.Add(this.lblCodigo22);
            this.grpEliminado.Location = new System.Drawing.Point(385, 29);
            this.grpEliminado.Name = "grpEliminado";
            this.grpEliminado.Size = new System.Drawing.Size(342, 242);
            this.grpEliminado.TabIndex = 76;
            this.grpEliminado.TabStop = false;
            this.grpEliminado.Text = "grpEliminado";
            // 
            // lblTramiteEliminado
            // 
            this.lblTramiteEliminado.AutoSize = true;
            this.lblTramiteEliminado.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblTramiteEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteEliminado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTramiteEliminado.Location = new System.Drawing.Point(76, 120);
            this.lblTramiteEliminado.Name = "lblTramiteEliminado";
            this.lblTramiteEliminado.Size = new System.Drawing.Size(78, 15);
            this.lblTramiteEliminado.TabIndex = 2;
            this.lblTramiteEliminado.Text = "                       ";
            // 
            // lblNombreEliminado
            // 
            this.lblNombreEliminado.AutoSize = true;
            this.lblNombreEliminado.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblNombreEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEliminado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNombreEliminado.Location = new System.Drawing.Point(76, 86);
            this.lblNombreEliminado.Name = "lblNombreEliminado";
            this.lblNombreEliminado.Size = new System.Drawing.Size(78, 15);
            this.lblNombreEliminado.TabIndex = 1;
            this.lblNombreEliminado.Text = "                       ";
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
            // txtTramite
            // 
            this.txtTramite.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTramite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTramite.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramite.Location = new System.Drawing.Point(94, 158);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(171, 22);
            this.txtTramite.TabIndex = 68;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(93, 74);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(171, 22);
            this.txtCodigo.TabIndex = 67;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrabar.Location = new System.Drawing.Point(35, 219);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(308, 30);
            this.btnGrabar.TabIndex = 66;
            this.btnGrabar.Text = "Agregar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            // 
            // grpElemento
            // 
            this.grpElemento.Controls.Add(this.lblNombre);
            this.grpElemento.Controls.Add(this.lblTramite);
            this.grpElemento.Controls.Add(this.lblCodigo);
            this.grpElemento.Location = new System.Drawing.Point(23, 28);
            this.grpElemento.Name = "grpElemento";
            this.grpElemento.Size = new System.Drawing.Size(342, 243);
            this.grpElemento.TabIndex = 70;
            this.grpElemento.TabStop = false;
            this.grpElemento.Text = "Nuevo elemento";
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.lblListado);
            this.grpListado.Location = new System.Drawing.Point(23, 276);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(704, 153);
            this.grpListado.TabIndex = 79;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "grpNuevo";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblListado.Location = new System.Drawing.Point(7, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(212, 17);
            this.lblListado.TabIndex = 46;
            this.lblListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(8, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(8, 130);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTramite.Size = new System.Drawing.Size(59, 20);
            this.lblTramite.TabIndex = 34;
            this.lblTramite.Text = "Trámite";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo.TabIndex = 33;
            this.lblCodigo.Text = "Código";
            // 
            // pctImagen
            // 
            this.pctImagen.BackColor = System.Drawing.Color.MintCream;
            this.pctImagen.BackgroundImage = global::pryEDZarateF.Properties.Resources._01_ListasSimplementeEnlazadas;
            this.pctImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctImagen.InitialImage")));
            this.pctImagen.Location = new System.Drawing.Point(749, 115);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(281, 231);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagen.TabIndex = 80;
            this.pctImagen.TabStop = false;
            // 
            // ListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pctImagen);
            this.Controls.Add(this.dgvElementos);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.lblTramite2);
            this.Controls.Add(this.lblEliminado);
            this.Controls.Add(this.lblCodigo2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grpEliminado);
            this.Controls.Add(this.txtTramite);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.grpElemento);
            this.Controls.Add(this.grpListado);
            this.Name = "ListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaSimple";
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).EndInit();
            this.grpEliminado.ResumeLayout(false);
            this.grpEliminado.PerformLayout();
            this.grpElemento.ResumeLayout(false);
            this.grpElemento.PerformLayout();
            this.grpListado.ResumeLayout(false);
            this.grpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pctImagen;
        private System.Windows.Forms.DataGridView dgvElementos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblEliminado;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grpEliminado;
        private System.Windows.Forms.Label lblTramiteEliminado;
        private System.Windows.Forms.Label lblNombreEliminado;
        private System.Windows.Forms.Label lblCodigo22;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox grpElemento;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblCodigo;
    }
}