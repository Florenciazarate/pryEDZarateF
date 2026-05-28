namespace pryEDZarateF.Formularios_Bases_de_Datos
{
    partial class frmOperaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperaciones));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBarraColor = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlGrilla = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvOperaciones = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlProyeccion = new Guna.UI2.WinForms.Guna2Panel();
            this.btnJuntar = new Guna.UI2.WinForms.Guna2Button();
            this.btnProyeccionMulti = new Guna.UI2.WinForms.Guna2Button();
            this.btnProyeccionSimple = new Guna.UI2.WinForms.Guna2Button();
            this.lblProyeccion = new System.Windows.Forms.Label();
            this.pnlSeleccion = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSeleccionConvolucion = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeleccionMulti = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeleccionSimple = new Guna.UI2.WinForms.Guna2Button();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.pnlAlgebraicas = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDiferencia = new Guna.UI2.WinForms.Guna2Button();
            this.btnInterseccion = new Guna.UI2.WinForms.Guna2Button();
            this.btnUnion = new Guna.UI2.WinForms.Guna2Button();
            this.lblAlgebraicas = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.pnlProyeccion.SuspendLayout();
            this.pnlSeleccion.SuspendLayout();
            this.pnlAlgebraicas.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1100, 95);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBarraColor
            // 
            this.pnlBarraColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.pnlBarraColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
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
            this.lblSubtitulo.Size = new System.Drawing.Size(312, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Operaciones de álgebra relacional sobre las tablas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(384, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Operaciones de Base de Datos";
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrilla.BorderRadius = 14;
            this.pnlGrilla.Controls.Add(this.dgvOperaciones);
            this.pnlGrilla.FillColor = System.Drawing.Color.White;
            this.pnlGrilla.Location = new System.Drawing.Point(25, 115);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.ShadowDecoration.BorderRadius = 14;
            this.pnlGrilla.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.pnlGrilla.ShadowDecoration.Depth = 8;
            this.pnlGrilla.ShadowDecoration.Enabled = true;
            this.pnlGrilla.Size = new System.Drawing.Size(1050, 360);
            this.pnlGrilla.TabIndex = 1;
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.AllowUserToDeleteRows = false;
            this.dgvOperaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOperaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperaciones.ColumnHeadersHeight = 38;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOperaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvOperaciones.Location = new System.Drawing.Point(25, 25);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.RowHeadersVisible = false;
            this.dgvOperaciones.RowHeadersWidth = 51;
            this.dgvOperaciones.RowTemplate.Height = 32;
            this.dgvOperaciones.Size = new System.Drawing.Size(1000, 310);
            this.dgvOperaciones.TabIndex = 0;
            this.dgvOperaciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOperaciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOperaciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOperaciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOperaciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOperaciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOperaciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvOperaciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvOperaciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOperaciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dgvOperaciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.dgvOperaciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOperaciones.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvOperaciones.ThemeStyle.ReadOnly = true;
            this.dgvOperaciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOperaciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOperaciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvOperaciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvOperaciones.ThemeStyle.RowsStyle.Height = 32;
            this.dgvOperaciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvOperaciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            // 
            // pnlProyeccion
            // 
            this.pnlProyeccion.BackColor = System.Drawing.Color.Transparent;
            this.pnlProyeccion.BorderRadius = 14;
            this.pnlProyeccion.Controls.Add(this.btnJuntar);
            this.pnlProyeccion.Controls.Add(this.btnProyeccionMulti);
            this.pnlProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.pnlProyeccion.Controls.Add(this.lblProyeccion);
            this.pnlProyeccion.FillColor = System.Drawing.Color.White;
            this.pnlProyeccion.Location = new System.Drawing.Point(25, 490);
            this.pnlProyeccion.Name = "pnlProyeccion";
            this.pnlProyeccion.ShadowDecoration.BorderRadius = 14;
            this.pnlProyeccion.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.pnlProyeccion.ShadowDecoration.Depth = 8;
            this.pnlProyeccion.ShadowDecoration.Enabled = true;
            this.pnlProyeccion.Size = new System.Drawing.Size(340, 215);
            this.pnlProyeccion.TabIndex = 2;
            // 
            // btnJuntar
            // 
            this.btnJuntar.BorderRadius = 8;
            this.btnJuntar.UseTransparentBackground = true;
            this.btnJuntar.FillColor = System.Drawing.Color.White;
            this.btnJuntar.BorderThickness = 2;
            this.btnJuntar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnJuntar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnJuntar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnJuntar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnJuntar.Location = new System.Drawing.Point(20, 158);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(300, 40);
            this.btnJuntar.TabIndex = 3;
            this.btnJuntar.Text = "Juntar";
            // 
            // btnProyeccionMulti
            // 
            this.btnProyeccionMulti.BorderRadius = 8;
            this.btnProyeccionMulti.UseTransparentBackground = true;
            this.btnProyeccionMulti.FillColor = System.Drawing.Color.White;
            this.btnProyeccionMulti.BorderThickness = 2;
            this.btnProyeccionMulti.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnProyeccionMulti.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnProyeccionMulti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnProyeccionMulti.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnProyeccionMulti.Location = new System.Drawing.Point(20, 108);
            this.btnProyeccionMulti.Name = "btnProyeccionMulti";
            this.btnProyeccionMulti.Size = new System.Drawing.Size(300, 40);
            this.btnProyeccionMulti.TabIndex = 2;
            this.btnProyeccionMulti.Text = "Proyección multiatributo";
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.BorderRadius = 8;
            this.btnProyeccionSimple.UseTransparentBackground = true;
            this.btnProyeccionSimple.FillColor = System.Drawing.Color.White;
            this.btnProyeccionSimple.BorderThickness = 2;
            this.btnProyeccionSimple.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnProyeccionSimple.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnProyeccionSimple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnProyeccionSimple.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnProyeccionSimple.Location = new System.Drawing.Point(20, 58);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(300, 40);
            this.btnProyeccionSimple.TabIndex = 1;
            this.btnProyeccionSimple.Text = "Proyección simple";
            // 
            // lblProyeccion
            // 
            this.lblProyeccion.AutoSize = true;
            this.lblProyeccion.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblProyeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblProyeccion.Location = new System.Drawing.Point(18, 18);
            this.lblProyeccion.Name = "lblProyeccion";
            this.lblProyeccion.Size = new System.Drawing.Size(257, 20);
            this.lblProyeccion.TabIndex = 0;
            this.lblProyeccion.Text = "Operaciones de Proyección - SELECT";
            // 
            // pnlSeleccion
            // 
            this.pnlSeleccion.BackColor = System.Drawing.Color.Transparent;
            this.pnlSeleccion.BorderRadius = 14;
            this.pnlSeleccion.Controls.Add(this.btnSeleccionConvolucion);
            this.pnlSeleccion.Controls.Add(this.btnSeleccionMulti);
            this.pnlSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.pnlSeleccion.Controls.Add(this.lblSeleccion);
            this.pnlSeleccion.FillColor = System.Drawing.Color.White;
            this.pnlSeleccion.Location = new System.Drawing.Point(380, 490);
            this.pnlSeleccion.Name = "pnlSeleccion";
            this.pnlSeleccion.ShadowDecoration.BorderRadius = 14;
            this.pnlSeleccion.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.pnlSeleccion.ShadowDecoration.Depth = 8;
            this.pnlSeleccion.ShadowDecoration.Enabled = true;
            this.pnlSeleccion.Size = new System.Drawing.Size(340, 215);
            this.pnlSeleccion.TabIndex = 3;
            // 
            // btnSeleccionConvolucion
            // 
            this.btnSeleccionConvolucion.BorderRadius = 8;
            this.btnSeleccionConvolucion.UseTransparentBackground = true;
            this.btnSeleccionConvolucion.FillColor = System.Drawing.Color.White;
            this.btnSeleccionConvolucion.BorderThickness = 2;
            this.btnSeleccionConvolucion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnSeleccionConvolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionConvolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnSeleccionConvolucion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSeleccionConvolucion.Location = new System.Drawing.Point(20, 158);
            this.btnSeleccionConvolucion.Name = "btnSeleccionConvolucion";
            this.btnSeleccionConvolucion.Size = new System.Drawing.Size(300, 40);
            this.btnSeleccionConvolucion.TabIndex = 3;
            this.btnSeleccionConvolucion.Text = "Selección por convolución";
            // 
            // btnSeleccionMulti
            // 
            this.btnSeleccionMulti.BorderRadius = 8;
            this.btnSeleccionMulti.UseTransparentBackground = true;
            this.btnSeleccionMulti.FillColor = System.Drawing.Color.White;
            this.btnSeleccionMulti.BorderThickness = 2;
            this.btnSeleccionMulti.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnSeleccionMulti.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionMulti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnSeleccionMulti.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSeleccionMulti.Location = new System.Drawing.Point(20, 108);
            this.btnSeleccionMulti.Name = "btnSeleccionMulti";
            this.btnSeleccionMulti.Size = new System.Drawing.Size(300, 40);
            this.btnSeleccionMulti.TabIndex = 2;
            this.btnSeleccionMulti.Text = "Selección multiatributo";
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.BorderRadius = 8;
            this.btnSeleccionSimple.UseTransparentBackground = true;
            this.btnSeleccionSimple.FillColor = System.Drawing.Color.White;
            this.btnSeleccionSimple.BorderThickness = 2;
            this.btnSeleccionSimple.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnSeleccionSimple.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionSimple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnSeleccionSimple.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSeleccionSimple.Location = new System.Drawing.Point(20, 58);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(300, 40);
            this.btnSeleccionSimple.TabIndex = 1;
            this.btnSeleccionSimple.Text = "Selección simple";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSeleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSeleccion.Location = new System.Drawing.Point(18, 18);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(247, 20);
            this.lblSeleccion.TabIndex = 0;
            this.lblSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // pnlAlgebraicas
            // 
            this.pnlAlgebraicas.BackColor = System.Drawing.Color.Transparent;
            this.pnlAlgebraicas.BorderRadius = 14;
            this.pnlAlgebraicas.Controls.Add(this.btnDiferencia);
            this.pnlAlgebraicas.Controls.Add(this.btnInterseccion);
            this.pnlAlgebraicas.Controls.Add(this.btnUnion);
            this.pnlAlgebraicas.Controls.Add(this.lblAlgebraicas);
            this.pnlAlgebraicas.FillColor = System.Drawing.Color.White;
            this.pnlAlgebraicas.Location = new System.Drawing.Point(735, 490);
            this.pnlAlgebraicas.Name = "pnlAlgebraicas";
            this.pnlAlgebraicas.ShadowDecoration.BorderRadius = 14;
            this.pnlAlgebraicas.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.pnlAlgebraicas.ShadowDecoration.Depth = 8;
            this.pnlAlgebraicas.ShadowDecoration.Enabled = true;
            this.pnlAlgebraicas.Size = new System.Drawing.Size(340, 215);
            this.pnlAlgebraicas.TabIndex = 4;
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.BorderRadius = 8;
            this.btnDiferencia.UseTransparentBackground = true;
            this.btnDiferencia.FillColor = System.Drawing.Color.White;
            this.btnDiferencia.BorderThickness = 2;
            this.btnDiferencia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnDiferencia.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnDiferencia.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnDiferencia.Location = new System.Drawing.Point(20, 158);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(300, 40);
            this.btnDiferencia.TabIndex = 3;
            this.btnDiferencia.Text = "Diferencia";
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.BorderRadius = 8;
            this.btnInterseccion.UseTransparentBackground = true;
            this.btnInterseccion.FillColor = System.Drawing.Color.White;
            this.btnInterseccion.BorderThickness = 2;
            this.btnInterseccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnInterseccion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnInterseccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnInterseccion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnInterseccion.Location = new System.Drawing.Point(20, 108);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(300, 40);
            this.btnInterseccion.TabIndex = 2;
            this.btnInterseccion.Text = "Intersección";
            // 
            // btnUnion
            // 
            this.btnUnion.BorderRadius = 8;
            this.btnUnion.UseTransparentBackground = true;
            this.btnUnion.FillColor = System.Drawing.Color.White;
            this.btnUnion.BorderThickness = 2;
            this.btnUnion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnUnion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUnion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnUnion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnUnion.Location = new System.Drawing.Point(20, 58);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(300, 40);
            this.btnUnion.TabIndex = 1;
            this.btnUnion.Text = "Unión";
            // 
            // lblAlgebraicas
            // 
            this.lblAlgebraicas.AutoSize = true;
            this.lblAlgebraicas.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAlgebraicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblAlgebraicas.Location = new System.Drawing.Point(18, 18);
            this.lblAlgebraicas.Name = "lblAlgebraicas";
            this.lblAlgebraicas.Size = new System.Drawing.Size(177, 20);
            this.lblAlgebraicas.TabIndex = 0;
            this.lblAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1100, 730);
            this.Controls.Add(this.pnlAlgebraicas);
            this.Controls.Add(this.pnlSeleccion);
            this.Controls.Add(this.pnlProyeccion);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones de Base de Datos";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.pnlProyeccion.ResumeLayout(false);
            this.pnlProyeccion.PerformLayout();
            this.pnlSeleccion.ResumeLayout(false);
            this.pnlSeleccion.PerformLayout();
            this.pnlAlgebraicas.ResumeLayout(false);
            this.pnlAlgebraicas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlBarraColor;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlGrilla;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOperaciones;
        private Guna.UI2.WinForms.Guna2Panel pnlProyeccion;
        private Guna.UI2.WinForms.Guna2Button btnJuntar;
        private Guna.UI2.WinForms.Guna2Button btnProyeccionMulti;
        private Guna.UI2.WinForms.Guna2Button btnProyeccionSimple;
        private System.Windows.Forms.Label lblProyeccion;
        private Guna.UI2.WinForms.Guna2Panel pnlSeleccion;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionConvolucion;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionMulti;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionSimple;
        private System.Windows.Forms.Label lblSeleccion;
        private Guna.UI2.WinForms.Guna2Panel pnlAlgebraicas;
        private Guna.UI2.WinForms.Guna2Button btnDiferencia;
        private Guna.UI2.WinForms.Guna2Button btnInterseccion;
        private Guna.UI2.WinForms.Guna2Button btnUnion;
        private System.Windows.Forms.Label lblAlgebraicas;
    }
}
