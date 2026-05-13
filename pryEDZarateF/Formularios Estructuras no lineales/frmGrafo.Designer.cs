namespace pryEDZarateF
{
    partial class frmGrafo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafo));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBarraColor = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCarga = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCargar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBorrarTodo = new Guna.UI2.WinForms.Guna2Button();
            this.txtCargaPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCargaPrecio = new System.Windows.Forms.Label();
            this.cmbCargaDestino = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCargaDestino = new System.Windows.Forms.Label();
            this.cmbCargaOrigen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCargaOrigen = new System.Windows.Forms.Label();
            this.lblCargaSub = new System.Windows.Forms.Label();
            this.lblCargaTitulo = new System.Windows.Forms.Label();
            this.pnlConsulta = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBorrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnConsultar = new Guna.UI2.WinForms.Guna2Button();
            this.txtConsultaPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConsultaPrecio = new System.Windows.Forms.Label();
            this.cmbConsultaDestino = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblConsultaDestino = new System.Windows.Forms.Label();
            this.cmbConsultaOrigen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblConsultaOrigen = new System.Windows.Forms.Label();
            this.lblConsultaSub = new System.Windows.Forms.Label();
            this.lblConsultaTitulo = new System.Windows.Forms.Label();
            this.pnlListar = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvMatriz = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblMatrizSub = new System.Windows.Forms.Label();
            this.lblMatrizTitulo = new System.Windows.Forms.Label();
            this.pnlFiltros = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVerTodos = new Guna.UI2.WinForms.Guna2Button();
            this.btnListarOrigenes = new Guna.UI2.WinForms.Guna2Button();
            this.cmbHasta = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnListarDestinos = new Guna.UI2.WinForms.Guna2Button();
            this.cmbDesde = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblListarSub = new System.Windows.Forms.Label();
            this.lblListarTitulo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlCarga.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            this.pnlListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pnlBarraColor);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Depth = 4;
            this.pnlHeader.ShadowDecoration.Enabled = true;
            this.pnlHeader.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.pnlHeader.Size = new System.Drawing.Size(1180, 95);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBarraColor
            // 
            this.pnlBarraColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.pnlBarraColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.pnlBarraColor.Location = new System.Drawing.Point(35, 25);
            this.pnlBarraColor.Name = "pnlBarraColor";
            this.pnlBarraColor.Size = new System.Drawing.Size(5, 50);
            this.pnlBarraColor.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(54, 56);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(250, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Operaciones en un grafo de conexiones";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(85, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Grafo";
            // 
            // pnlCarga
            // 
            this.pnlCarga.BackColor = System.Drawing.Color.Transparent;
            this.pnlCarga.BorderRadius = 14;
            this.pnlCarga.Controls.Add(this.btnCargar);
            this.pnlCarga.Controls.Add(this.btnBorrarTodo);
            this.pnlCarga.Controls.Add(this.txtCargaPrecio);
            this.pnlCarga.Controls.Add(this.lblCargaPrecio);
            this.pnlCarga.Controls.Add(this.cmbCargaDestino);
            this.pnlCarga.Controls.Add(this.lblCargaDestino);
            this.pnlCarga.Controls.Add(this.cmbCargaOrigen);
            this.pnlCarga.Controls.Add(this.lblCargaOrigen);
            this.pnlCarga.Controls.Add(this.lblCargaSub);
            this.pnlCarga.Controls.Add(this.lblCargaTitulo);
            this.pnlCarga.FillColor = System.Drawing.Color.White;
            this.pnlCarga.Location = new System.Drawing.Point(25, 120);
            this.pnlCarga.Name = "pnlCarga";
            this.pnlCarga.ShadowDecoration.BorderRadius = 14;
            this.pnlCarga.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.pnlCarga.ShadowDecoration.Depth = 8;
            this.pnlCarga.ShadowDecoration.Enabled = true;
            this.pnlCarga.Size = new System.Drawing.Size(560, 320);
            this.pnlCarga.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.BorderRadius = 8;
            this.btnCargar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(33)))), ((int)(((byte)(2)))));
            this.btnCargar.Location = new System.Drawing.Point(290, 250);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(250, 45);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnBorrarTodo.BorderRadius = 8;
            this.btnBorrarTodo.BorderThickness = 1;
            this.btnBorrarTodo.FillColor = System.Drawing.Color.White;
            this.btnBorrarTodo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnBorrarTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnBorrarTodo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnBorrarTodo.Location = new System.Drawing.Point(22, 250);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(250, 45);
            this.btnBorrarTodo.TabIndex = 8;
            this.btnBorrarTodo.Text = "Borrar Todo";
            // 
            // txtCargaPrecio
            // 
            this.txtCargaPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.txtCargaPrecio.BorderRadius = 8;
            this.txtCargaPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCargaPrecio.DefaultText = "";
            this.txtCargaPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.txtCargaPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCargaPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCargaPrecio.Location = new System.Drawing.Point(22, 185);
            this.txtCargaPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargaPrecio.Name = "txtCargaPrecio";
            this.txtCargaPrecio.PlaceholderText = "Precio del viaje";
            this.txtCargaPrecio.SelectedText = "";
            this.txtCargaPrecio.Size = new System.Drawing.Size(518, 40);
            this.txtCargaPrecio.TabIndex = 7;
            // 
            // lblCargaPrecio
            // 
            this.lblCargaPrecio.AutoSize = true;
            this.lblCargaPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCargaPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblCargaPrecio.Location = new System.Drawing.Point(22, 165);
            this.lblCargaPrecio.Name = "lblCargaPrecio";
            this.lblCargaPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblCargaPrecio.TabIndex = 6;
            this.lblCargaPrecio.Text = "Precio";
            // 
            // cmbCargaDestino
            // 
            this.cmbCargaDestino.BackColor = System.Drawing.Color.Transparent;
            this.cmbCargaDestino.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.cmbCargaDestino.BorderRadius = 8;
            this.cmbCargaDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCargaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargaDestino.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbCargaDestino.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbCargaDestino.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCargaDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCargaDestino.ItemHeight = 30;
            this.cmbCargaDestino.Location = new System.Drawing.Point(290, 110);
            this.cmbCargaDestino.Name = "cmbCargaDestino";
            this.cmbCargaDestino.Size = new System.Drawing.Size(250, 36);
            this.cmbCargaDestino.TabIndex = 5;
            // 
            // lblCargaDestino
            // 
            this.lblCargaDestino.AutoSize = true;
            this.lblCargaDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCargaDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblCargaDestino.Location = new System.Drawing.Point(290, 90);
            this.lblCargaDestino.Name = "lblCargaDestino";
            this.lblCargaDestino.Size = new System.Drawing.Size(48, 15);
            this.lblCargaDestino.TabIndex = 4;
            this.lblCargaDestino.Text = "Destino";
            // 
            // cmbCargaOrigen
            // 
            this.cmbCargaOrigen.BackColor = System.Drawing.Color.Transparent;
            this.cmbCargaOrigen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.cmbCargaOrigen.BorderRadius = 8;
            this.cmbCargaOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCargaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargaOrigen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbCargaOrigen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbCargaOrigen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCargaOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCargaOrigen.ItemHeight = 30;
            this.cmbCargaOrigen.Location = new System.Drawing.Point(22, 110);
            this.cmbCargaOrigen.Name = "cmbCargaOrigen";
            this.cmbCargaOrigen.Size = new System.Drawing.Size(250, 36);
            this.cmbCargaOrigen.TabIndex = 3;
            // 
            // lblCargaOrigen
            // 
            this.lblCargaOrigen.AutoSize = true;
            this.lblCargaOrigen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCargaOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblCargaOrigen.Location = new System.Drawing.Point(22, 90);
            this.lblCargaOrigen.Name = "lblCargaOrigen";
            this.lblCargaOrigen.Size = new System.Drawing.Size(43, 15);
            this.lblCargaOrigen.TabIndex = 2;
            this.lblCargaOrigen.Text = "Origen";
            // 
            // lblCargaSub
            // 
            this.lblCargaSub.AutoSize = true;
            this.lblCargaSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCargaSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCargaSub.Location = new System.Drawing.Point(24, 50);
            this.lblCargaSub.Name = "lblCargaSub";
            this.lblCargaSub.Size = new System.Drawing.Size(194, 15);
            this.lblCargaSub.TabIndex = 1;
            this.lblCargaSub.Text = "Cargar una nueva conexión al grafo";
            // 
            // lblCargaTitulo
            // 
            this.lblCargaTitulo.AutoSize = true;
            this.lblCargaTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblCargaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCargaTitulo.Location = new System.Drawing.Point(22, 22);
            this.lblCargaTitulo.Name = "lblCargaTitulo";
            this.lblCargaTitulo.Size = new System.Drawing.Size(143, 25);
            this.lblCargaTitulo.TabIndex = 0;
            this.lblCargaTitulo.Text = "Carga de Datos";
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.BackColor = System.Drawing.Color.Transparent;
            this.pnlConsulta.BorderRadius = 14;
            this.pnlConsulta.Controls.Add(this.btnBorrar);
            this.pnlConsulta.Controls.Add(this.btnConsultar);
            this.pnlConsulta.Controls.Add(this.txtConsultaPrecio);
            this.pnlConsulta.Controls.Add(this.lblConsultaPrecio);
            this.pnlConsulta.Controls.Add(this.cmbConsultaDestino);
            this.pnlConsulta.Controls.Add(this.lblConsultaDestino);
            this.pnlConsulta.Controls.Add(this.cmbConsultaOrigen);
            this.pnlConsulta.Controls.Add(this.lblConsultaOrigen);
            this.pnlConsulta.Controls.Add(this.lblConsultaSub);
            this.pnlConsulta.Controls.Add(this.lblConsultaTitulo);
            this.pnlConsulta.FillColor = System.Drawing.Color.White;
            this.pnlConsulta.Location = new System.Drawing.Point(605, 120);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.ShadowDecoration.BorderRadius = 14;
            this.pnlConsulta.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.pnlConsulta.ShadowDecoration.Depth = 8;
            this.pnlConsulta.ShadowDecoration.Enabled = true;
            this.pnlConsulta.Size = new System.Drawing.Size(560, 320);
            this.pnlConsulta.TabIndex = 2;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnBorrar.BorderRadius = 8;
            this.btnBorrar.BorderThickness = 1;
            this.btnBorrar.FillColor = System.Drawing.Color.White;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnBorrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnBorrar.Location = new System.Drawing.Point(290, 250);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(250, 45);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BorderRadius = 8;
            this.btnConsultar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(33)))), ((int)(((byte)(2)))));
            this.btnConsultar.Location = new System.Drawing.Point(22, 250);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(250, 45);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            // 
            // txtConsultaPrecio
            // 
            this.txtConsultaPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.txtConsultaPrecio.BorderRadius = 8;
            this.txtConsultaPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsultaPrecio.DefaultText = "";
            this.txtConsultaPrecio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtConsultaPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.txtConsultaPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConsultaPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtConsultaPrecio.Location = new System.Drawing.Point(22, 185);
            this.txtConsultaPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultaPrecio.Name = "txtConsultaPrecio";
            this.txtConsultaPrecio.PlaceholderText = "Resultado de la consulta";
            this.txtConsultaPrecio.ReadOnly = true;
            this.txtConsultaPrecio.SelectedText = "";
            this.txtConsultaPrecio.Size = new System.Drawing.Size(518, 40);
            this.txtConsultaPrecio.TabIndex = 7;
            // 
            // lblConsultaPrecio
            // 
            this.lblConsultaPrecio.AutoSize = true;
            this.lblConsultaPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblConsultaPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblConsultaPrecio.Location = new System.Drawing.Point(22, 165);
            this.lblConsultaPrecio.Name = "lblConsultaPrecio";
            this.lblConsultaPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblConsultaPrecio.TabIndex = 6;
            this.lblConsultaPrecio.Text = "Precio";
            // 
            // cmbConsultaDestino
            // 
            this.cmbConsultaDestino.BackColor = System.Drawing.Color.Transparent;
            this.cmbConsultaDestino.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.cmbConsultaDestino.BorderRadius = 8;
            this.cmbConsultaDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbConsultaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultaDestino.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbConsultaDestino.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbConsultaDestino.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbConsultaDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbConsultaDestino.ItemHeight = 30;
            this.cmbConsultaDestino.Location = new System.Drawing.Point(290, 110);
            this.cmbConsultaDestino.Name = "cmbConsultaDestino";
            this.cmbConsultaDestino.Size = new System.Drawing.Size(250, 36);
            this.cmbConsultaDestino.TabIndex = 5;
            // 
            // lblConsultaDestino
            // 
            this.lblConsultaDestino.AutoSize = true;
            this.lblConsultaDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblConsultaDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblConsultaDestino.Location = new System.Drawing.Point(290, 90);
            this.lblConsultaDestino.Name = "lblConsultaDestino";
            this.lblConsultaDestino.Size = new System.Drawing.Size(48, 15);
            this.lblConsultaDestino.TabIndex = 4;
            this.lblConsultaDestino.Text = "Destino";
            // 
            // cmbConsultaOrigen
            // 
            this.cmbConsultaOrigen.BackColor = System.Drawing.Color.Transparent;
            this.cmbConsultaOrigen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.cmbConsultaOrigen.BorderRadius = 8;
            this.cmbConsultaOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbConsultaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultaOrigen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbConsultaOrigen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbConsultaOrigen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbConsultaOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbConsultaOrigen.ItemHeight = 30;
            this.cmbConsultaOrigen.Location = new System.Drawing.Point(22, 110);
            this.cmbConsultaOrigen.Name = "cmbConsultaOrigen";
            this.cmbConsultaOrigen.Size = new System.Drawing.Size(250, 36);
            this.cmbConsultaOrigen.TabIndex = 3;
            // 
            // lblConsultaOrigen
            // 
            this.lblConsultaOrigen.AutoSize = true;
            this.lblConsultaOrigen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblConsultaOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblConsultaOrigen.Location = new System.Drawing.Point(22, 90);
            this.lblConsultaOrigen.Name = "lblConsultaOrigen";
            this.lblConsultaOrigen.Size = new System.Drawing.Size(43, 15);
            this.lblConsultaOrigen.TabIndex = 2;
            this.lblConsultaOrigen.Text = "Origen";
            // 
            // lblConsultaSub
            // 
            this.lblConsultaSub.AutoSize = true;
            this.lblConsultaSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConsultaSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblConsultaSub.Location = new System.Drawing.Point(24, 50);
            this.lblConsultaSub.Name = "lblConsultaSub";
            this.lblConsultaSub.Size = new System.Drawing.Size(245, 15);
            this.lblConsultaSub.TabIndex = 1;
            this.lblConsultaSub.Text = "Consultar el precio de una conexión existente";
            // 
            // lblConsultaTitulo
            // 
            this.lblConsultaTitulo.AutoSize = true;
            this.lblConsultaTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblConsultaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblConsultaTitulo.Location = new System.Drawing.Point(22, 22);
            this.lblConsultaTitulo.Name = "lblConsultaTitulo";
            this.lblConsultaTitulo.Size = new System.Drawing.Size(168, 25);
            this.lblConsultaTitulo.TabIndex = 0;
            this.lblConsultaTitulo.Text = "Consulta de Datos";
            // 
            // pnlListar
            // 
            this.pnlListar.BackColor = System.Drawing.Color.Transparent;
            this.pnlListar.BorderRadius = 14;
            this.pnlListar.Controls.Add(this.dgvMatriz);
            this.pnlListar.Controls.Add(this.lblMatrizSub);
            this.pnlListar.Controls.Add(this.lblMatrizTitulo);
            this.pnlListar.Controls.Add(this.pnlFiltros);
            this.pnlListar.FillColor = System.Drawing.Color.White;
            this.pnlListar.Location = new System.Drawing.Point(25, 455);
            this.pnlListar.Name = "pnlListar";
            this.pnlListar.ShadowDecoration.BorderRadius = 14;
            this.pnlListar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.pnlListar.ShadowDecoration.Depth = 8;
            this.pnlListar.ShadowDecoration.Enabled = true;
            this.pnlListar.Size = new System.Drawing.Size(1140, 490);
            this.pnlListar.TabIndex = 3;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMatriz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatriz.ColumnHeadersHeight = 38;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatriz.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvMatriz.Location = new System.Drawing.Point(20, 265);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.ReadOnly = true;
            this.dgvMatriz.RowHeadersVisible = false;
            this.dgvMatriz.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatriz.RowTemplate.Height = 32;
            this.dgvMatriz.Size = new System.Drawing.Size(1100, 200);
            this.dgvMatriz.TabIndex = 3;
            this.dgvMatriz.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMatriz.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMatriz.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMatriz.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMatriz.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMatriz.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMatriz.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvMatriz.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.dgvMatriz.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatriz.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dgvMatriz.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.dgvMatriz.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMatriz.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvMatriz.ThemeStyle.ReadOnly = true;
            this.dgvMatriz.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMatriz.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMatriz.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvMatriz.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvMatriz.ThemeStyle.RowsStyle.Height = 32;
            this.dgvMatriz.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.dgvMatriz.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            // 
            // lblMatrizSub
            // 
            this.lblMatrizSub.AutoSize = true;
            this.lblMatrizSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMatrizSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMatrizSub.Location = new System.Drawing.Point(22, 236);
            this.lblMatrizSub.Name = "lblMatrizSub";
            this.lblMatrizSub.Size = new System.Drawing.Size(191, 15);
            this.lblMatrizSub.TabIndex = 2;
            this.lblMatrizSub.Text = "Precios entre cada origen y destino";
            // 
            // lblMatrizTitulo
            // 
            this.lblMatrizTitulo.AutoSize = true;
            this.lblMatrizTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblMatrizTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblMatrizTitulo.Location = new System.Drawing.Point(20, 210);
            this.lblMatrizTitulo.Name = "lblMatrizTitulo";
            this.lblMatrizTitulo.Size = new System.Drawing.Size(142, 25);
            this.lblMatrizTitulo.TabIndex = 1;
            this.lblMatrizTitulo.Text = "Matriz de viajes";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiltros.BorderRadius = 10;
            this.pnlFiltros.Controls.Add(this.btnVerTodos);
            this.pnlFiltros.Controls.Add(this.btnListarOrigenes);
            this.pnlFiltros.Controls.Add(this.cmbHasta);
            this.pnlFiltros.Controls.Add(this.lblHasta);
            this.pnlFiltros.Controls.Add(this.btnListarDestinos);
            this.pnlFiltros.Controls.Add(this.cmbDesde);
            this.pnlFiltros.Controls.Add(this.lblDesde);
            this.pnlFiltros.Controls.Add(this.lblListarSub);
            this.pnlFiltros.Controls.Add(this.lblListarTitulo);
            this.pnlFiltros.FillColor = System.Drawing.Color.White;
            this.pnlFiltros.Location = new System.Drawing.Point(20, 20);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1100, 175);
            this.pnlFiltros.TabIndex = 0;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BorderRadius = 8;
            this.btnVerTodos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.btnVerTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVerTodos.ForeColor = System.Drawing.Color.White;
            this.btnVerTodos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(33)))), ((int)(((byte)(2)))));
            this.btnVerTodos.Location = new System.Drawing.Point(812, 90);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(270, 36);
            this.btnVerTodos.TabIndex = 8;
            this.btnVerTodos.Text = "Ver todos los viajes";
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.btnListarOrigenes.BorderRadius = 8;
            this.btnListarOrigenes.BorderThickness = 1;
            this.btnListarOrigenes.FillColor = System.Drawing.Color.White;
            this.btnListarOrigenes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnListarOrigenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.btnListarOrigenes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.btnListarOrigenes.Location = new System.Drawing.Point(625, 90);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(160, 36);
            this.btnListarOrigenes.TabIndex = 7;
            this.btnListarOrigenes.Text = "Listar Orígenes";
            // 
            // cmbHasta
            // 
            this.cmbHasta.BackColor = System.Drawing.Color.Transparent;
            this.cmbHasta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.cmbHasta.BorderRadius = 8;
            this.cmbHasta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbHasta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbHasta.ItemHeight = 30;
            this.cmbHasta.Location = new System.Drawing.Point(417, 90);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(200, 36);
            this.cmbHasta.TabIndex = 6;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblHasta.Location = new System.Drawing.Point(417, 70);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(37, 15);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta";
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.btnListarDestinos.BorderRadius = 8;
            this.btnListarDestinos.BorderThickness = 1;
            this.btnListarDestinos.FillColor = System.Drawing.Color.White;
            this.btnListarDestinos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnListarDestinos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.btnListarDestinos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.btnListarDestinos.Location = new System.Drawing.Point(228, 90);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(160, 36);
            this.btnListarDestinos.TabIndex = 4;
            this.btnListarDestinos.Text = "Listar Destinos";
            // 
            // cmbDesde
            // 
            this.cmbDesde.BackColor = System.Drawing.Color.Transparent;
            this.cmbDesde.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.cmbDesde.BorderRadius = 8;
            this.cmbDesde.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbDesde.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.cmbDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDesde.ItemHeight = 30;
            this.cmbDesde.Location = new System.Drawing.Point(20, 90);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(200, 36);
            this.cmbDesde.TabIndex = 3;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblDesde.Location = new System.Drawing.Point(20, 70);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(40, 15);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde";
            // 
            // lblListarSub
            // 
            this.lblListarSub.AutoSize = true;
            this.lblListarSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblListarSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblListarSub.Location = new System.Drawing.Point(20, 40);
            this.lblListarSub.Name = "lblListarSub";
            this.lblListarSub.Size = new System.Drawing.Size(200, 15);
            this.lblListarSub.TabIndex = 1;
            this.lblListarSub.Text = "Filtrar viajes por origen o por destino";
            // 
            // lblListarTitulo
            // 
            this.lblListarTitulo.AutoSize = true;
            this.lblListarTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblListarTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblListarTitulo.Location = new System.Drawing.Point(18, 14);
            this.lblListarTitulo.Name = "lblListarTitulo";
            this.lblListarTitulo.Size = new System.Drawing.Size(108, 25);
            this.lblListarTitulo.TabIndex = 0;
            this.lblListarTitulo.Text = "Listar viajes";
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1180, 970);
            this.Controls.Add(this.pnlListar);
            this.Controls.Add(this.pnlConsulta);
            this.Controls.Add(this.pnlCarga);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones en un Grafo";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCarga.ResumeLayout(false);
            this.pnlCarga.PerformLayout();
            this.pnlConsulta.ResumeLayout(false);
            this.pnlConsulta.PerformLayout();
            this.pnlListar.ResumeLayout(false);
            this.pnlListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlBarraColor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private Guna.UI2.WinForms.Guna2Panel pnlCarga;
        private System.Windows.Forms.Label lblCargaTitulo;
        private System.Windows.Forms.Label lblCargaSub;
        private System.Windows.Forms.Label lblCargaOrigen;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCargaOrigen;
        private System.Windows.Forms.Label lblCargaDestino;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCargaDestino;
        private System.Windows.Forms.Label lblCargaPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtCargaPrecio;
        private Guna.UI2.WinForms.Guna2Button btnBorrarTodo;
        private Guna.UI2.WinForms.Guna2Button btnCargar;

        private Guna.UI2.WinForms.Guna2Panel pnlConsulta;
        private System.Windows.Forms.Label lblConsultaTitulo;
        private System.Windows.Forms.Label lblConsultaSub;
        private System.Windows.Forms.Label lblConsultaOrigen;
        private Guna.UI2.WinForms.Guna2ComboBox cmbConsultaOrigen;
        private System.Windows.Forms.Label lblConsultaDestino;
        private Guna.UI2.WinForms.Guna2ComboBox cmbConsultaDestino;
        private System.Windows.Forms.Label lblConsultaPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultaPrecio;
        private Guna.UI2.WinForms.Guna2Button btnConsultar;
        private Guna.UI2.WinForms.Guna2Button btnBorrar;

        private Guna.UI2.WinForms.Guna2Panel pnlListar;
        private Guna.UI2.WinForms.Guna2Panel pnlFiltros;
        private System.Windows.Forms.Label lblListarTitulo;
        private System.Windows.Forms.Label lblListarSub;
        private System.Windows.Forms.Label lblDesde;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDesde;
        private Guna.UI2.WinForms.Guna2Button btnListarDestinos;
        private System.Windows.Forms.Label lblHasta;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHasta;
        private Guna.UI2.WinForms.Guna2Button btnListarOrigenes;
        private Guna.UI2.WinForms.Guna2Button btnVerTodos;

        private System.Windows.Forms.Label lblMatrizTitulo;
        private System.Windows.Forms.Label lblMatrizSub;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMatriz;
    }
}
