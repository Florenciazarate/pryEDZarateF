namespace pryEDZarateF
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBarraColor = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlNuevo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGrabar = new Guna.UI2.WinForms.Guna2Button();
            this.txtDeuda = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNuevoSub = new System.Windows.Forms.Label();
            this.lblNuevoTitulo = new System.Windows.Forms.Label();
            this.pnlListado = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListadoSub = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlNuevo.SuspendLayout();
            this.pnlListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
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
            this.pnlBarraColor.BackColor = ColoresApp.Naranja;
            this.pnlBarraColor.FillColor = ColoresApp.Naranja;
            this.pnlBarraColor.Location = new System.Drawing.Point(35, 25);
            this.pnlBarraColor.Name = "pnlBarraColor";
            this.pnlBarraColor.Size = new System.Drawing.Size(5, 50);
            this.pnlBarraColor.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = ColoresApp.TextoSubtitulo;
            this.lblSubtitulo.Location = new System.Drawing.Point(54, 56);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(183, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Gestión de clientes y deudas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = ColoresApp.TextoTitulo;
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Clientes";
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.BackColor = System.Drawing.Color.Transparent;
            this.pnlNuevo.BorderRadius = 14;
            this.pnlNuevo.Controls.Add(this.btnGrabar);
            this.pnlNuevo.Controls.Add(this.txtDeuda);
            this.pnlNuevo.Controls.Add(this.txtNombre);
            this.pnlNuevo.Controls.Add(this.txtCodigo);
            this.pnlNuevo.Controls.Add(this.lblDeuda);
            this.pnlNuevo.Controls.Add(this.lblNombre);
            this.pnlNuevo.Controls.Add(this.lblCodigo);
            this.pnlNuevo.Controls.Add(this.lblNuevoSub);
            this.pnlNuevo.Controls.Add(this.lblNuevoTitulo);
            this.pnlNuevo.FillColor = System.Drawing.Color.White;
            this.pnlNuevo.Location = new System.Drawing.Point(25, 115);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.ShadowDecoration.BorderRadius = 14;
            this.pnlNuevo.ShadowDecoration.Color = ColoresApp.SombraPanel;
            this.pnlNuevo.ShadowDecoration.Depth = 8;
            this.pnlNuevo.ShadowDecoration.Enabled = true;
            this.pnlNuevo.Size = new System.Drawing.Size(380, 410);
            this.pnlNuevo.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BorderRadius = 8;
            this.btnGrabar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrabar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrabar.DisabledState.FillColor = ColoresApp.BordeSuave;
            this.btnGrabar.DisabledState.ForeColor = ColoresApp.TextoBotonDisabled;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FillColor = ColoresApp.Naranja;
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.HoverState.FillColor = ColoresApp.NaranjaHover;
            this.btnGrabar.Location = new System.Drawing.Point(27, 322);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(330, 45);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Grabar cliente";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtDeuda
            // 
            this.txtDeuda.BorderColor = ColoresApp.BordeSuave;
            this.txtDeuda.BorderRadius = 8;
            this.txtDeuda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeuda.DefaultText = "";
            this.txtDeuda.DisabledState.BorderColor = ColoresApp.BordeDisabled;
            this.txtDeuda.DisabledState.FillColor = ColoresApp.FondoTextDisabled;
            this.txtDeuda.DisabledState.ForeColor = ColoresApp.TextoDisabled;
            this.txtDeuda.DisabledState.PlaceholderForeColor = ColoresApp.TextoDisabled;
            this.txtDeuda.FocusedState.BorderColor = ColoresApp.Naranja;
            this.txtDeuda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeuda.HoverState.BorderColor = ColoresApp.NaranjaBordeHover;
            this.txtDeuda.Location = new System.Drawing.Point(27, 262);
            this.txtDeuda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.PlaceholderText = "0,00";
            this.txtDeuda.SelectedText = "";
            this.txtDeuda.Size = new System.Drawing.Size(330, 40);
            this.txtDeuda.TabIndex = 7;
            this.txtDeuda.TextChanged += new System.EventHandler(this.txtCampos_TextChanged);
            this.txtDeuda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeuda_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = ColoresApp.BordeSuave;
            this.txtNombre.BorderRadius = 8;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = ColoresApp.BordeDisabled;
            this.txtNombre.DisabledState.FillColor = ColoresApp.FondoTextDisabled;
            this.txtNombre.DisabledState.ForeColor = ColoresApp.TextoDisabled;
            this.txtNombre.DisabledState.PlaceholderForeColor = ColoresApp.TextoDisabled;
            this.txtNombre.FocusedState.BorderColor = ColoresApp.Naranja;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.HoverState.BorderColor = ColoresApp.NaranjaBordeHover;
            this.txtNombre.Location = new System.Drawing.Point(27, 177);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre completo";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(330, 40);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtCampos_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderColor = ColoresApp.BordeSuave;
            this.txtCodigo.BorderRadius = 8;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = ColoresApp.BordeDisabled;
            this.txtCodigo.DisabledState.FillColor = ColoresApp.FondoTextDisabled;
            this.txtCodigo.DisabledState.ForeColor = ColoresApp.TextoDisabled;
            this.txtCodigo.DisabledState.PlaceholderForeColor = ColoresApp.TextoDisabled;
            this.txtCodigo.FocusedState.BorderColor = ColoresApp.Naranja;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigo.HoverState.BorderColor = ColoresApp.NaranjaBordeHover;
            this.txtCodigo.Location = new System.Drawing.Point(27, 107);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PlaceholderText = "Ej: 1001";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(330, 40);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCampos_TextChanged);
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeuda.ForeColor = ColoresApp.TextoEtiqueta;
            this.lblDeuda.Location = new System.Drawing.Point(27, 242);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(48, 15);
            this.lblDeuda.TabIndex = 4;
            this.lblDeuda.Text = "Deuda";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = ColoresApp.TextoEtiqueta;
            this.lblNombre.Location = new System.Drawing.Point(27, 157);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = ColoresApp.TextoEtiqueta;
            this.lblCodigo.Location = new System.Drawing.Point(27, 87);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 15);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // lblNuevoSub
            // 
            this.lblNuevoSub.AutoSize = true;
            this.lblNuevoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNuevoSub.ForeColor = ColoresApp.TextoSubtitulo;
            this.lblNuevoSub.Location = new System.Drawing.Point(25, 56);
            this.lblNuevoSub.Name = "lblNuevoSub";
            this.lblNuevoSub.Size = new System.Drawing.Size(238, 15);
            this.lblNuevoSub.TabIndex = 1;
            this.lblNuevoSub.Text = "Cargá un nuevo cliente con su deuda actual";
            // 
            // lblNuevoTitulo
            // 
            this.lblNuevoTitulo.AutoSize = true;
            this.lblNuevoTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblNuevoTitulo.ForeColor = ColoresApp.TextoTitulo;
            this.lblNuevoTitulo.Location = new System.Drawing.Point(22, 25);
            this.lblNuevoTitulo.Name = "lblNuevoTitulo";
            this.lblNuevoTitulo.Size = new System.Drawing.Size(131, 25);
            this.lblNuevoTitulo.TabIndex = 0;
            this.lblNuevoTitulo.Text = "Nuevo cliente";
            // 
            // pnlListado
            // 
            this.pnlListado.BackColor = System.Drawing.Color.Transparent;
            this.pnlListado.BorderRadius = 14;
            this.pnlListado.Controls.Add(this.dgvClientes);
            this.pnlListado.Controls.Add(this.lblListadoSub);
            this.pnlListado.Controls.Add(this.lblListado);
            this.pnlListado.FillColor = System.Drawing.Color.White;
            this.pnlListado.Location = new System.Drawing.Point(425, 115);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.ShadowDecoration.BorderRadius = 14;
            this.pnlListado.ShadowDecoration.Color = ColoresApp.SombraPanel;
            this.pnlListado.ShadowDecoration.Depth = 8;
            this.pnlListado.ShadowDecoration.Enabled = true;
            this.pnlListado.Size = new System.Drawing.Size(650, 410);
            this.pnlListado.TabIndex = 2;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = ColoresApp.NaranjaFondoSuave;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = ColoresApp.Naranja;
            dataGridViewCellStyle2.SelectionBackColor = ColoresApp.NaranjaFondoSuave;
            dataGridViewCellStyle2.SelectionForeColor = ColoresApp.Naranja;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeight = 38;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.ClmNombre,
            this.clmDeuda});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = ColoresApp.TextoGrilla;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = ColoresApp.NaranjaFondoSuave;
            dataGridViewCellStyle3.SelectionForeColor = ColoresApp.TextoGrilla;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.GridColor = ColoresApp.BordeSuave;
            this.dgvClientes.Location = new System.Drawing.Point(25, 95);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = ColoresApp.TextoGrilla;
            dataGridViewCellStyle4.SelectionBackColor = ColoresApp.NaranjaFondoSuave;
            dataGridViewCellStyle4.SelectionForeColor = ColoresApp.TextoGrilla;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.RowTemplate.Height = 32;
            this.dgvClientes.Size = new System.Drawing.Size(600, 290);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.GridColor = ColoresApp.BordeSuave;
            this.dgvClientes.ThemeStyle.HeaderStyle.BackColor = ColoresApp.NaranjaFondoSuave;
            this.dgvClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dgvClientes.ThemeStyle.HeaderStyle.ForeColor = ColoresApp.Naranja;
            this.dgvClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClientes.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvClientes.ThemeStyle.ReadOnly = true;
            this.dgvClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvClientes.ThemeStyle.RowsStyle.ForeColor = ColoresApp.TextoGrilla;
            this.dgvClientes.ThemeStyle.RowsStyle.Height = 32;
            this.dgvClientes.ThemeStyle.RowsStyle.SelectionBackColor = ColoresApp.NaranjaFondoSuave;
            this.dgvClientes.ThemeStyle.RowsStyle.SelectionForeColor = ColoresApp.TextoGrilla;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.MinimumWidth = 6;
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // ClmNombre
            // 
            this.ClmNombre.HeaderText = "Nombre";
            this.ClmNombre.MinimumWidth = 6;
            this.ClmNombre.Name = "ClmNombre";
            this.ClmNombre.ReadOnly = true;
            // 
            // clmDeuda
            // 
            this.clmDeuda.HeaderText = "Deuda";
            this.clmDeuda.MinimumWidth = 6;
            this.clmDeuda.Name = "clmDeuda";
            this.clmDeuda.ReadOnly = true;
            // 
            // lblListadoSub
            // 
            this.lblListadoSub.AutoSize = true;
            this.lblListadoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblListadoSub.ForeColor = ColoresApp.TextoSubtitulo;
            this.lblListadoSub.Location = new System.Drawing.Point(25, 55);
            this.lblListadoSub.Name = "lblListadoSub";
            this.lblListadoSub.Size = new System.Drawing.Size(171, 15);
            this.lblListadoSub.TabIndex = 1;
            this.lblListadoSub.Text = "Clientes cargados en el sistema";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblListado.ForeColor = ColoresApp.TextoTitulo;
            this.lblListado.Location = new System.Drawing.Point(22, 25);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(169, 25);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Listado de clientes";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = ColoresApp.FondoForm;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.pnlNuevo);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNuevo.ResumeLayout(false);
            this.pnlNuevo.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            this.pnlListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlBarraColor;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlNuevo;
        private Guna.UI2.WinForms.Guna2Button btnGrabar;
        private Guna.UI2.WinForms.Guna2TextBox txtDeuda;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNuevoSub;
        private System.Windows.Forms.Label lblNuevoTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlListado;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeuda;
        private System.Windows.Forms.Label lblListadoSub;
        private System.Windows.Forms.Label lblListado;
    }
}
