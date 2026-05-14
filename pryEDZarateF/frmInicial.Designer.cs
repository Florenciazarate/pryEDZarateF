namespace pryEDZarateF
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaciónOOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUnaTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUnaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesEnBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasVariasConOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlAccent = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pctInicial = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.programaciónOOToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLinealesToolStripMenuItem,
            this.aToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(940, 31);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.acercaDeToolStripMenuItem.Tag = "frmDatosDesarrollador";
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.salirToolStripMenuItem.Tag = "Salir";
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // programaciónOOToolStripMenuItem
            // 
            this.programaciónOOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloresToolStripMenuItem,
            this.mesesToolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.carrerasToolStripMenuItem});
            this.programaciónOOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.programaciónOOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.programaciónOOToolStripMenuItem.Name = "programaciónOOToolStripMenuItem";
            this.programaciónOOToolStripMenuItem.Size = new System.Drawing.Size(132, 23);
            this.programaciónOOToolStripMenuItem.Text = "Programación OO";
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.coloresToolStripMenuItem.Tag = "frmColores";
            this.coloresToolStripMenuItem.Text = "Colores...";
            this.coloresToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // mesesToolStripMenuItem1
            // 
            this.mesesToolStripMenuItem1.Name = "mesesToolStripMenuItem1";
            this.mesesToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            this.mesesToolStripMenuItem1.Tag = "frmMeses";
            this.mesesToolStripMenuItem1.Text = "Meses...";
            this.mesesToolStripMenuItem1.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.clientesToolStripMenuItem.Tag = "frmClientes";
            this.clientesToolStripMenuItem.Text = "Clientes...";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.alumnosToolStripMenuItem.Tag = "frmAlumnos";
            this.alumnosToolStripMenuItem.Text = "Alumnos...";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.carrerasToolStripMenuItem.Tag = "frmCarreras";
            this.carrerasToolStripMenuItem.Text = "Carreras...";
            this.carrerasToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.listaSimpleToolStripMenuItem,
            this.listaDobleToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.estructurasLinealesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(137, 23);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.colaToolStripMenuItem.Tag = "frmCola";
            this.colaToolStripMenuItem.Text = "Cola...";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.pilaToolStripMenuItem.Tag = "frmPila";
            this.pilaToolStripMenuItem.Text = "Pila...";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.listaSimpleToolStripMenuItem.Tag = "frmListaSimple";
            this.listaSimpleToolStripMenuItem.Text = "Lista simple...";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // listaDobleToolStripMenuItem
            // 
            this.listaDobleToolStripMenuItem.Name = "listaDobleToolStripMenuItem";
            this.listaDobleToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.listaDobleToolStripMenuItem.Tag = "frmListaDoble";
            this.listaDobleToolStripMenuItem.Text = "Lista doble...";
            this.listaDobleToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // estructurasNoLinealesToolStripMenuItem
            // 
            this.estructurasNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolToolStripMenuItem,
            this.grafoToolStripMenuItem});
            this.estructurasNoLinealesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.estructurasNoLinealesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.estructurasNoLinealesToolStripMenuItem.Name = "estructurasNoLinealesToolStripMenuItem";
            this.estructurasNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(157, 23);
            this.estructurasNoLinealesToolStripMenuItem.Text = "Estructuras no lineales";
            // 
            // arbolToolStripMenuItem
            // 
            this.arbolToolStripMenuItem.Name = "arbolToolStripMenuItem";
            this.arbolToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.arbolToolStripMenuItem.Tag = "frmArbol";
            this.arbolToolStripMenuItem.Text = "Arbol...";
            this.arbolToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.grafoToolStripMenuItem.Tag = "frmGrafo";
            this.grafoToolStripMenuItem.Text = "Grafo...";
            this.grafoToolStripMenuItem.Click += new System.EventHandler(this.AbrirFormulario_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUnaTablaToolStripMenuItem,
            this.consultaDeUnaBaseDeDatosToolStripMenuItem,
            this.operacionesEnBaseDeDatosToolStripMenuItem,
            this.consultasVariasConOperacionesToolStripMenuItem});
            this.aToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.aToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.aToolStripMenuItem.Text = "Base de Datos";
            // 
            // consultaDeUnaTablaToolStripMenuItem
            // 
            this.consultaDeUnaTablaToolStripMenuItem.Name = "consultaDeUnaTablaToolStripMenuItem";
            this.consultaDeUnaTablaToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.consultaDeUnaTablaToolStripMenuItem.Text = "Consulta de una tabla...";
            // 
            // consultaDeUnaBaseDeDatosToolStripMenuItem
            // 
            this.consultaDeUnaBaseDeDatosToolStripMenuItem.Name = "consultaDeUnaBaseDeDatosToolStripMenuItem";
            this.consultaDeUnaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.consultaDeUnaBaseDeDatosToolStripMenuItem.Text = "Consulta de una Base de Datos...";
            // 
            // operacionesEnBaseDeDatosToolStripMenuItem
            // 
            this.operacionesEnBaseDeDatosToolStripMenuItem.Name = "operacionesEnBaseDeDatosToolStripMenuItem";
            this.operacionesEnBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.operacionesEnBaseDeDatosToolStripMenuItem.Text = "Operaciones en Base de Datos...";
            // 
            // consultasVariasConOperacionesToolStripMenuItem
            // 
            this.consultasVariasConOperacionesToolStripMenuItem.Name = "consultasVariasConOperacionesToolStripMenuItem";
            this.consultasVariasConOperacionesToolStripMenuItem.Size = new System.Drawing.Size(289, 24);
            this.consultasVariasConOperacionesToolStripMenuItem.Text = "Consultas varias con operaciones...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.pnlAccent.BorderRadius = 2;
            this.pnlAccent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(187)))), ((int)(((byte)(229)))));
            this.pnlAccent.Location = new System.Drawing.Point(439, 208);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(60, 4);
            this.pnlAccent.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitulo.Location = new System.Drawing.Point(279, 215);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(399, 60);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Estructuras de Datos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(277, 266);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(401, 25);
            this.lblSubtitulo.TabIndex = 3;
            this.lblSubtitulo.Text = "Instancia Evaluativa · Programación Orientada a Objetos";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFooter
            // 
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFooter.Location = new System.Drawing.Point(0, 595);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(940, 20);
            this.lblFooter.TabIndex = 5;
            this.lblFooter.Text = "Comisión MB - Profesora Erica Bongiovanni";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctInicial
            // 
            this.pctInicial.BackgroundImage = global::pryEDZarateF.Properties.Resources.Logotipo_Estudio_Shonos_Diseño_multimedia_divertido_retro_y2k_rosa2;
            this.pctInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctInicial.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctInicial.InitialImage")));
            this.pctInicial.Location = new System.Drawing.Point(-84, 208);
            this.pctInicial.Name = "pctInicial";
            this.pctInicial.Size = new System.Drawing.Size(431, 437);
            this.pctInicial.TabIndex = 6;
            this.pctInicial.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlAccent);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pctInicial);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programaciónOOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDobleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnaTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesEnBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasVariasConOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel pnlAccent;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.PictureBox pctInicial;
    }
}
