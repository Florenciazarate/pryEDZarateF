namespace pryEDZarateF
{
    partial class frmListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDoble));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBarraColor = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlNuevo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGrabar = new Guna.UI2.WinForms.Guna2Button();
            this.txtTramite = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNuevoTitulo = new System.Windows.Forms.Label();
            this.pnlEliminar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbCodigo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblEliminado = new System.Windows.Forms.Label();
            this.pnlOrden = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDescendenteTxt = new System.Windows.Forms.Label();
            this.lblAscendenteTxt = new System.Windows.Forms.Label();
            this.radioDescendente = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.radioAscendente = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.lblOrdenSub = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.pnlListado = new Guna.UI2.WinForms.Guna2Panel();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.dgvElementos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListadoSub = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlNuevo.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            this.pnlOrden.SuspendLayout();
            this.pnlListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).BeginInit();
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
            this.pnlBarraColor.BackColor = ColoresApp.Violeta;
            this.pnlBarraColor.FillColor = ColoresApp.Violeta;
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
            this.lblSubtitulo.Size = new System.Drawing.Size(205, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Estructura doblemente enlazada";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = ColoresApp.TextoTitulo;
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista Doble";
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.BackColor = System.Drawing.Color.Transparent;
            this.pnlNuevo.BorderRadius = 14;
            this.pnlNuevo.Controls.Add(this.btnGrabar);
            this.pnlNuevo.Controls.Add(this.txtTramite);
            this.pnlNuevo.Controls.Add(this.txtNombre);
            this.pnlNuevo.Controls.Add(this.txtCodigo);
            this.pnlNuevo.Controls.Add(this.lblTramite);
            this.pnlNuevo.Controls.Add(this.lblNombre);
            this.pnlNuevo.Controls.Add(this.lblCodigo);
            this.pnlNuevo.Controls.Add(this.lblNuevoTitulo);
            this.pnlNuevo.FillColor = System.Drawing.Color.White;
            this.pnlNuevo.Location = new System.Drawing.Point(25, 115);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.ShadowDecoration.BorderRadius = 14;
            this.pnlNuevo.ShadowDecoration.Color = ColoresApp.SombraPanel;
            this.pnlNuevo.ShadowDecoration.Depth = 8;
            this.pnlNuevo.ShadowDecoration.Enabled = true;
            this.pnlNuevo.Size = new System.Drawing.Size(380, 400);
            this.pnlNuevo.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BorderRadius = 8;
            this.btnGrabar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrabar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrabar.DisabledState.FillColor = ColoresApp.BordeSuave;
            this.btnGrabar.DisabledState.ForeColor = ColoresApp.TextoBotonDisabled;
            this.btnGrabar.FillColor = ColoresApp.Violeta;
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.HoverState.FillColor = ColoresApp.VioletaHover;
            this.btnGrabar.Location = new System.Drawing.Point(24, 301);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(330, 45);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Agregar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.BorderColor = ColoresApp.BordeSuave;
            this.txtTramite.BorderRadius = 8;
            this.txtTramite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTramite.DefaultText = "";
            this.txtTramite.DisabledState.BorderColor = ColoresApp.BordeDisabled;
            this.txtTramite.DisabledState.FillColor = ColoresApp.FondoTextDisabled;
            this.txtTramite.DisabledState.ForeColor = ColoresApp.TextoDisabled;
            this.txtTramite.DisabledState.PlaceholderForeColor = ColoresApp.TextoDisabled;
            this.txtTramite.FocusedState.BorderColor = ColoresApp.Violeta;
            this.txtTramite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTramite.HoverState.BorderColor = ColoresApp.VioletaBordeHover;
            this.txtTramite.Location = new System.Drawing.Point(25, 227);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.PlaceholderText = "Tipo de trámite";
            this.txtTramite.SelectedText = "";
            this.txtTramite.Size = new System.Drawing.Size(330, 40);
            this.txtTramite.TabIndex = 6;
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
            this.txtNombre.FocusedState.BorderColor = ColoresApp.Violeta;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.HoverState.BorderColor = ColoresApp.VioletaBordeHover;
            this.txtNombre.Location = new System.Drawing.Point(25, 155);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre completo";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(330, 40);
            this.txtNombre.TabIndex = 5;
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
            this.txtCodigo.FocusedState.BorderColor = ColoresApp.Violeta;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigo.HoverState.BorderColor = ColoresApp.VioletaBordeHover;
            this.txtCodigo.Location = new System.Drawing.Point(25, 83);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PlaceholderText = "Ej: 1001";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(330, 40);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTramite.ForeColor = ColoresApp.TextoEtiqueta;
            this.lblTramite.Location = new System.Drawing.Point(25, 207);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(58, 15);
            this.lblTramite.TabIndex = 3;
            this.lblTramite.Text = "TRÁMITE";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = ColoresApp.TextoEtiqueta;
            this.lblNombre.Location = new System.Drawing.Point(25, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = ColoresApp.TextoEtiqueta;
            this.lblCodigo.Location = new System.Drawing.Point(25, 63);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 15);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // lblNuevoTitulo
            // 
            this.lblNuevoTitulo.AutoSize = true;
            this.lblNuevoTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblNuevoTitulo.ForeColor = ColoresApp.TextoTitulo;
            this.lblNuevoTitulo.Location = new System.Drawing.Point(22, 25);
            this.lblNuevoTitulo.Name = "lblNuevoTitulo";
            this.lblNuevoTitulo.Size = new System.Drawing.Size(155, 25);
            this.lblNuevoTitulo.TabIndex = 0;
            this.lblNuevoTitulo.Text = "Nuevo elemento";
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.BackColor = System.Drawing.Color.Transparent;
            this.pnlEliminar.BorderRadius = 14;
            this.pnlEliminar.Controls.Add(this.btnEliminar);
            this.pnlEliminar.Controls.Add(this.cmbCodigo);
            this.pnlEliminar.Controls.Add(this.lblCodigo2);
            this.pnlEliminar.Controls.Add(this.lblEliminado);
            this.pnlEliminar.FillColor = System.Drawing.Color.White;
            this.pnlEliminar.Location = new System.Drawing.Point(25, 530);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.ShadowDecoration.BorderRadius = 14;
            this.pnlEliminar.ShadowDecoration.Color = ColoresApp.SombraPanel;
            this.pnlEliminar.ShadowDecoration.Depth = 8;
            this.pnlEliminar.ShadowDecoration.Enabled = true;
            this.pnlEliminar.Size = new System.Drawing.Size(380, 165);
            this.pnlEliminar.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 8;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = ColoresApp.BordeSuave;
            this.btnEliminar.DisabledState.ForeColor = ColoresApp.TextoBotonDisabled;
            this.btnEliminar.FillColor = ColoresApp.RojoEliminar;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.FillColor = ColoresApp.RojoEliminarHover;
            this.btnEliminar.Location = new System.Drawing.Point(245, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.cmbCodigo.BorderColor = ColoresApp.BordeSuave;
            this.cmbCodigo.BorderRadius = 8;
            this.cmbCodigo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FocusedColor = ColoresApp.Violeta;
            this.cmbCodigo.FocusedState.BorderColor = ColoresApp.Violeta;
            this.cmbCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCodigo.ForeColor = ColoresApp.TextoCombo;
            this.cmbCodigo.ItemHeight = 30;
            this.cmbCodigo.Location = new System.Drawing.Point(25, 90);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(210, 36);
            this.cmbCodigo.TabIndex = 2;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigo2.ForeColor = ColoresApp.TextoEtiqueta;
            this.lblCodigo2.Location = new System.Drawing.Point(25, 70);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(124, 15);
            this.lblCodigo2.TabIndex = 1;
            this.lblCodigo2.Text = "CÓDIGO A ELIMINAR";
            // 
            // lblEliminado
            // 
            this.lblEliminado.AutoSize = true;
            this.lblEliminado.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblEliminado.ForeColor = ColoresApp.TextoTitulo;
            this.lblEliminado.Location = new System.Drawing.Point(22, 25);
            this.lblEliminado.Name = "lblEliminado";
            this.lblEliminado.Size = new System.Drawing.Size(168, 25);
            this.lblEliminado.TabIndex = 0;
            this.lblEliminado.Text = "Eliminar elemento";
            // 
            // pnlOrden
            // 
            this.pnlOrden.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrden.BorderRadius = 14;
            this.pnlOrden.Controls.Add(this.lblDescendenteTxt);
            this.pnlOrden.Controls.Add(this.lblAscendenteTxt);
            this.pnlOrden.Controls.Add(this.radioDescendente);
            this.pnlOrden.Controls.Add(this.radioAscendente);
            this.pnlOrden.Controls.Add(this.lblOrdenSub);
            this.pnlOrden.Controls.Add(this.lblOrden);
            this.pnlOrden.FillColor = System.Drawing.Color.White;
            this.pnlOrden.Location = new System.Drawing.Point(425, 540);
            this.pnlOrden.Name = "pnlOrden";
            this.pnlOrden.ShadowDecoration.BorderRadius = 14;
            this.pnlOrden.ShadowDecoration.Color = ColoresApp.SombraPanel;
            this.pnlOrden.ShadowDecoration.Depth = 8;
            this.pnlOrden.ShadowDecoration.Enabled = true;
            this.pnlOrden.Size = new System.Drawing.Size(650, 155);
            this.pnlOrden.TabIndex = 4;
            // 
            // lblDescendenteTxt
            // 
            this.lblDescendenteTxt.AutoSize = true;
            this.lblDescendenteTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescendenteTxt.ForeColor = ColoresApp.TextoGrilla;
            this.lblDescendenteTxt.Location = new System.Drawing.Point(249, 101);
            this.lblDescendenteTxt.Name = "lblDescendenteTxt";
            this.lblDescendenteTxt.Size = new System.Drawing.Size(88, 19);
            this.lblDescendenteTxt.TabIndex = 5;
            this.lblDescendenteTxt.Text = "Descendente";
            // 
            // lblAscendenteTxt
            // 
            this.lblAscendenteTxt.AutoSize = true;
            this.lblAscendenteTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAscendenteTxt.ForeColor = ColoresApp.TextoGrilla;
            this.lblAscendenteTxt.Location = new System.Drawing.Point(60, 101);
            this.lblAscendenteTxt.Name = "lblAscendenteTxt";
            this.lblAscendenteTxt.Size = new System.Drawing.Size(80, 19);
            this.lblAscendenteTxt.TabIndex = 4;
            this.lblAscendenteTxt.Text = "Ascendente";
            // 
            // radioDescendente
            // 
            this.radioDescendente.Animated = true;
            this.radioDescendente.CheckedState.BorderColor = ColoresApp.Violeta;
            this.radioDescendente.CheckedState.BorderThickness = 0;
            this.radioDescendente.CheckedState.FillColor = ColoresApp.Violeta;
            this.radioDescendente.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioDescendente.CheckedState.InnerOffset = -4;
            this.radioDescendente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioDescendente.ForeColor = ColoresApp.TextoGrilla;
            this.radioDescendente.Location = new System.Drawing.Point(171, 99);
            this.radioDescendente.Name = "radioDescendente";
            this.radioDescendente.Size = new System.Drawing.Size(118, 23);
            this.radioDescendente.TabIndex = 3;
            this.radioDescendente.Text = "Descendente";
            this.radioDescendente.UncheckedState.BorderColor = ColoresApp.BordeRadio;
            this.radioDescendente.UncheckedState.BorderThickness = 2;
            this.radioDescendente.UncheckedState.FillColor = System.Drawing.Color.White;
            this.radioDescendente.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // radioAscendente
            // 
            this.radioAscendente.Animated = true;
            this.radioAscendente.CheckedState.BorderColor = ColoresApp.Violeta;
            this.radioAscendente.CheckedState.BorderThickness = 0;
            this.radioAscendente.CheckedState.FillColor = ColoresApp.Violeta;
            this.radioAscendente.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioAscendente.CheckedState.InnerOffset = -4;
            this.radioAscendente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioAscendente.ForeColor = ColoresApp.TextoGrilla;
            this.radioAscendente.Location = new System.Drawing.Point(0, 99);
            this.radioAscendente.Name = "radioAscendente";
            this.radioAscendente.Size = new System.Drawing.Size(89, 23);
            this.radioAscendente.TabIndex = 2;
            this.radioAscendente.Text = "Ascendente";
            this.radioAscendente.UncheckedState.BorderColor = ColoresApp.BordeRadio;
            this.radioAscendente.UncheckedState.BorderThickness = 2;
            this.radioAscendente.UncheckedState.FillColor = System.Drawing.Color.White;
            this.radioAscendente.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.radioAscendente.CheckedChanged += new System.EventHandler(this.radioAscendente_CheckedChanged);
            // 
            // lblOrdenSub
            // 
            this.lblOrdenSub.AutoSize = true;
            this.lblOrdenSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrdenSub.ForeColor = ColoresApp.TextoSubtitulo;
            this.lblOrdenSub.Location = new System.Drawing.Point(25, 60);
            this.lblOrdenSub.Name = "lblOrdenSub";
            this.lblOrdenSub.Size = new System.Drawing.Size(258, 15);
            this.lblOrdenSub.TabIndex = 1;
            this.lblOrdenSub.Text = "Cambiá el orden de visualización en grilla y lista";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblOrden.ForeColor = ColoresApp.TextoTitulo;
            this.lblOrden.Location = new System.Drawing.Point(22, 25);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(153, 25);
            this.lblOrden.TabIndex = 0;
            this.lblOrden.Text = "Orden de listado";
            // 
            // pnlListado
            // 
            this.pnlListado.BackColor = System.Drawing.Color.Transparent;
            this.pnlListado.BorderRadius = 14;
            this.pnlListado.Controls.Add(this.lstElementos);
            this.pnlListado.Controls.Add(this.dgvElementos);
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
            this.pnlListado.TabIndex = 3;
            // 
            // lstElementos
            // 
            this.lstElementos.BackColor = ColoresApp.FondoListBox;
            this.lstElementos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstElementos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstElementos.ForeColor = ColoresApp.TextoGrilla;
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.IntegralHeight = false;
            this.lstElementos.ItemHeight = 17;
            this.lstElementos.Location = new System.Drawing.Point(25, 280);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(600, 110);
            this.lstElementos.TabIndex = 3;
            // 
            // dgvElementos
            // 
            this.dgvElementos.AllowUserToAddRows = false;
            this.dgvElementos.AllowUserToDeleteRows = false;
            this.dgvElementos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvElementos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = ColoresApp.VioletaFondoSuave;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = ColoresApp.Violeta;
            dataGridViewCellStyle2.SelectionBackColor = ColoresApp.VioletaFondoSuave;
            dataGridViewCellStyle2.SelectionForeColor = ColoresApp.Violeta;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvElementos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvElementos.ColumnHeadersHeight = 38;
            this.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvElementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = ColoresApp.TextoGrilla;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = ColoresApp.VioletaFondoSuave;
            dataGridViewCellStyle3.SelectionForeColor = ColoresApp.TextoGrilla;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvElementos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvElementos.GridColor = ColoresApp.BordeSuave;
            this.dgvElementos.Location = new System.Drawing.Point(25, 95);
            this.dgvElementos.Name = "dgvElementos";
            this.dgvElementos.ReadOnly = true;
            this.dgvElementos.RowHeadersVisible = false;
            this.dgvElementos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = ColoresApp.TextoGrilla;
            dataGridViewCellStyle4.SelectionBackColor = ColoresApp.VioletaFondoSuave;
            dataGridViewCellStyle4.SelectionForeColor = ColoresApp.TextoGrilla;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvElementos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvElementos.RowTemplate.Height = 32;
            this.dgvElementos.Size = new System.Drawing.Size(600, 170);
            this.dgvElementos.TabIndex = 2;
            this.dgvElementos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvElementos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvElementos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvElementos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvElementos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvElementos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvElementos.ThemeStyle.GridColor = ColoresApp.BordeSuave;
            this.dgvElementos.ThemeStyle.HeaderStyle.BackColor = ColoresApp.VioletaFondoSuave;
            this.dgvElementos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvElementos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dgvElementos.ThemeStyle.HeaderStyle.ForeColor = ColoresApp.Violeta;
            this.dgvElementos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvElementos.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvElementos.ThemeStyle.ReadOnly = true;
            this.dgvElementos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvElementos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvElementos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvElementos.ThemeStyle.RowsStyle.ForeColor = ColoresApp.TextoGrilla;
            this.dgvElementos.ThemeStyle.RowsStyle.Height = 32;
            this.dgvElementos.ThemeStyle.RowsStyle.SelectionBackColor = ColoresApp.VioletaFondoSuave;
            this.dgvElementos.ThemeStyle.RowsStyle.SelectionForeColor = ColoresApp.TextoGrilla;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.MinimumWidth = 6;
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmTramite
            // 
            this.clmTramite.HeaderText = "Trámite";
            this.clmTramite.MinimumWidth = 6;
            this.clmTramite.Name = "clmTramite";
            this.clmTramite.ReadOnly = true;
            // 
            // lblListadoSub
            // 
            this.lblListadoSub.AutoSize = true;
            this.lblListadoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblListadoSub.ForeColor = ColoresApp.TextoSubtitulo;
            this.lblListadoSub.Location = new System.Drawing.Point(25, 60);
            this.lblListadoSub.Name = "lblListadoSub";
            this.lblListadoSub.Size = new System.Drawing.Size(126, 15);
            this.lblListadoSub.TabIndex = 1;
            this.lblListadoSub.Text = "Vista en grilla y en lista";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblListado.ForeColor = ColoresApp.TextoTitulo;
            this.lblListado.Location = new System.Drawing.Point(22, 25);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(193, 25);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Listado de elementos";
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = ColoresApp.FondoForm;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.pnlOrden);
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.pnlEliminar);
            this.Controls.Add(this.pnlNuevo);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Doble";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNuevo.ResumeLayout(false);
            this.pnlNuevo.PerformLayout();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            this.pnlOrden.ResumeLayout(false);
            this.pnlOrden.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            this.pnlListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlBarraColor;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlNuevo;
        private Guna.UI2.WinForms.Guna2Button btnGrabar;
        private Guna.UI2.WinForms.Guna2TextBox txtTramite;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNuevoTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlEliminar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblEliminado;
        private Guna.UI2.WinForms.Guna2Panel pnlOrden;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioDescendente;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioAscendente;
        private System.Windows.Forms.Label lblAscendenteTxt;
        private System.Windows.Forms.Label lblDescendenteTxt;
        private System.Windows.Forms.Label lblOrdenSub;
        private System.Windows.Forms.Label lblOrden;
        private Guna.UI2.WinForms.Guna2Panel pnlListado;
        private System.Windows.Forms.ListBox lstElementos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvElementos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.Label lblListadoSub;
        private System.Windows.Forms.Label lblListado;
    }
}
