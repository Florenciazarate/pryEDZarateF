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
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.SlateGray;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.programaciónOOToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLinealesToolStripMenuItem,
            this.aToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 29);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // programaciónOOToolStripMenuItem
            // 
            this.programaciónOOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloresToolStripMenuItem,
            this.mesesToolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.carrerasToolStripMenuItem});
            this.programaciónOOToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programaciónOOToolStripMenuItem.Name = "programaciónOOToolStripMenuItem";
            this.programaciónOOToolStripMenuItem.Size = new System.Drawing.Size(148, 25);
            this.programaciónOOToolStripMenuItem.Text = "Programación OO";
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.coloresToolStripMenuItem.Text = "Colores...";
            this.coloresToolStripMenuItem.Click += new System.EventHandler(this.coloresToolStripMenuItem_Click);
            // 
            // mesesToolStripMenuItem1
            // 
            this.mesesToolStripMenuItem1.Name = "mesesToolStripMenuItem1";
            this.mesesToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.mesesToolStripMenuItem1.Text = "Meses...";
            this.mesesToolStripMenuItem1.Click += new System.EventHandler(this.mesesToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.clientesToolStripMenuItem.Text = "Clientes...";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.alumnosToolStripMenuItem.Text = "Alumnos...";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click_1);
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            this.carrerasToolStripMenuItem.Click += new System.EventHandler(this.carrerasToolStripMenuItem_Click);
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.listaSimpleToolStripMenuItem,
            this.listaDobleToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(155, 25);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.colaToolStripMenuItem.Text = "Cola...";
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.pilaToolStripMenuItem.Text = "Pila...";
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.listaSimpleToolStripMenuItem.Text = "Lista simple...";
            // 
            // listaDobleToolStripMenuItem
            // 
            this.listaDobleToolStripMenuItem.Name = "listaDobleToolStripMenuItem";
            this.listaDobleToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.listaDobleToolStripMenuItem.Text = "Lista doble...";
            // 
            // estructurasNoLinealesToolStripMenuItem
            // 
            this.estructurasNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolToolStripMenuItem,
            this.grafoToolStripMenuItem});
            this.estructurasNoLinealesToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estructurasNoLinealesToolStripMenuItem.Name = "estructurasNoLinealesToolStripMenuItem";
            this.estructurasNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(177, 25);
            this.estructurasNoLinealesToolStripMenuItem.Text = "Estructuras no lineales";
            // 
            // arbolToolStripMenuItem
            // 
            this.arbolToolStripMenuItem.Name = "arbolToolStripMenuItem";
            this.arbolToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.arbolToolStripMenuItem.Text = "Arbol...";
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.grafoToolStripMenuItem.Text = "Grafo...";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUnaTablaToolStripMenuItem,
            this.consultaDeUnaBaseDeDatosToolStripMenuItem,
            this.operacionesEnBaseDeDatosToolStripMenuItem,
            this.consultasVariasConOperacionesToolStripMenuItem});
            this.aToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.aToolStripMenuItem.Text = "Base de Datos";
            // 
            // consultaDeUnaTablaToolStripMenuItem
            // 
            this.consultaDeUnaTablaToolStripMenuItem.Name = "consultaDeUnaTablaToolStripMenuItem";
            this.consultaDeUnaTablaToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.consultaDeUnaTablaToolStripMenuItem.Text = "Consulta de una tabla...";
            // 
            // consultaDeUnaBaseDeDatosToolStripMenuItem
            // 
            this.consultaDeUnaBaseDeDatosToolStripMenuItem.Name = "consultaDeUnaBaseDeDatosToolStripMenuItem";
            this.consultaDeUnaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.consultaDeUnaBaseDeDatosToolStripMenuItem.Text = "Consulta de una Base de Datos...";
            // 
            // operacionesEnBaseDeDatosToolStripMenuItem
            // 
            this.operacionesEnBaseDeDatosToolStripMenuItem.Name = "operacionesEnBaseDeDatosToolStripMenuItem";
            this.operacionesEnBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.operacionesEnBaseDeDatosToolStripMenuItem.Text = "Operaciones en Base de Datos...";
            // 
            // consultasVariasConOperacionesToolStripMenuItem
            // 
            this.consultasVariasConOperacionesToolStripMenuItem.Name = "consultasVariasConOperacionesToolStripMenuItem";
            this.consultasVariasConOperacionesToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.consultasVariasConOperacionesToolStripMenuItem.Text = "Consultas varias con operaciones...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEDZarateF.Properties.Resources.happy_fairy_tail_minimalistic_wallpaper_by_greenmapple17;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
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
    }
}

