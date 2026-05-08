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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBarraColor = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlNuevo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnListar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGrabar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbMeses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNuevoSub = new System.Windows.Forms.Label();
            this.lblNuevoTitulo = new System.Windows.Forms.Label();
            this.pnlListado = new Guna.UI2.WinForms.Guna2Panel();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.lblListadoSub = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlNuevo.SuspendLayout();
            this.pnlListado.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(900, 95);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBarraColor
            // 
            this.pnlBarraColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlBarraColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
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
            this.lblSubtitulo.Size = new System.Drawing.Size(213, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Selección de meses del calendario";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(94, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Meses";
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.BackColor = System.Drawing.Color.Transparent;
            this.pnlNuevo.BorderRadius = 14;
            this.pnlNuevo.Controls.Add(this.btnListar);
            this.pnlNuevo.Controls.Add(this.btnGrabar);
            this.pnlNuevo.Controls.Add(this.cmbMeses);
            this.pnlNuevo.Controls.Add(this.lblNuevoSub);
            this.pnlNuevo.Controls.Add(this.lblNuevoTitulo);
            this.pnlNuevo.FillColor = System.Drawing.Color.White;
            this.pnlNuevo.Location = new System.Drawing.Point(25, 115);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.ShadowDecoration.BorderRadius = 14;
            this.pnlNuevo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.pnlNuevo.ShadowDecoration.Depth = 8;
            this.pnlNuevo.ShadowDecoration.Enabled = true;
            this.pnlNuevo.Size = new System.Drawing.Size(380, 242);
            this.pnlNuevo.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.BorderRadius = 8;
            this.btnListar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnListar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnListar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.btnListar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnListar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(138)))));
            this.btnListar.Location = new System.Drawing.Point(32, 151);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(150, 45);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click_1);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BorderRadius = 8;
            this.btnGrabar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrabar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrabar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnGrabar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnGrabar.Location = new System.Drawing.Point(202, 151);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(160, 45);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cmbMeses
            // 
            this.cmbMeses.BackColor = System.Drawing.Color.Transparent;
            this.cmbMeses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.cmbMeses.BorderRadius = 8;
            this.cmbMeses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.cmbMeses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.cmbMeses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMeses.ItemHeight = 30;
            this.cmbMeses.Location = new System.Drawing.Point(32, 96);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(330, 36);
            this.cmbMeses.TabIndex = 3;
            this.cmbMeses.SelectedIndexChanged += new System.EventHandler(this.cmbMeses_SelectedIndexChanged);
            // 
            // lblNuevoSub
            // 
            this.lblNuevoSub.AutoSize = true;
            this.lblNuevoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNuevoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNuevoSub.Location = new System.Drawing.Point(30, 61);
            this.lblNuevoSub.Name = "lblNuevoSub";
            this.lblNuevoSub.Size = new System.Drawing.Size(164, 15);
            this.lblNuevoSub.TabIndex = 1;
            this.lblNuevoSub.Text = "Seleccioná un mes y guardalo";
            // 
            // lblNuevoTitulo
            // 
            this.lblNuevoTitulo.AutoSize = true;
            this.lblNuevoTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblNuevoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblNuevoTitulo.Location = new System.Drawing.Point(27, 30);
            this.lblNuevoTitulo.Name = "lblNuevoTitulo";
            this.lblNuevoTitulo.Size = new System.Drawing.Size(109, 25);
            this.lblNuevoTitulo.TabIndex = 0;
            this.lblNuevoTitulo.Text = "Nuevo mes";
            // 
            // pnlListado
            // 
            this.pnlListado.BackColor = System.Drawing.Color.Transparent;
            this.pnlListado.BorderRadius = 14;
            this.pnlListado.Controls.Add(this.lstMeses);
            this.pnlListado.Controls.Add(this.lblListadoSub);
            this.pnlListado.Controls.Add(this.lblListado);
            this.pnlListado.FillColor = System.Drawing.Color.White;
            this.pnlListado.Location = new System.Drawing.Point(425, 115);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.ShadowDecoration.BorderRadius = 14;
            this.pnlListado.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.pnlListado.ShadowDecoration.Depth = 8;
            this.pnlListado.ShadowDecoration.Enabled = true;
            this.pnlListado.Size = new System.Drawing.Size(450, 360);
            this.pnlListado.TabIndex = 2;
            // 
            // lstMeses
            // 
            this.lstMeses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lstMeses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMeses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstMeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.IntegralHeight = false;
            this.lstMeses.ItemHeight = 17;
            this.lstMeses.Location = new System.Drawing.Point(25, 95);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(400, 240);
            this.lstMeses.TabIndex = 2;
            // 
            // lblListadoSub
            // 
            this.lblListadoSub.AutoSize = true;
            this.lblListadoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblListadoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblListadoSub.Location = new System.Drawing.Point(25, 55);
            this.lblListadoSub.Name = "lblListadoSub";
            this.lblListadoSub.Size = new System.Drawing.Size(162, 15);
            this.lblListadoSub.TabIndex = 1;
            this.lblListadoSub.Text = "Meses cargados en el sistema";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblListado.Location = new System.Drawing.Point(22, 25);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(157, 25);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Listado de meses";
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.pnlNuevo);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meses";
            this.Load += new System.EventHandler(this.frmMeses_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNuevo.ResumeLayout(false);
            this.pnlNuevo.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            this.pnlListado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlBarraColor;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlNuevo;
        private Guna.UI2.WinForms.Guna2Button btnListar;
        private Guna.UI2.WinForms.Guna2Button btnGrabar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMeses;
        private System.Windows.Forms.Label lblNuevoSub;
        private System.Windows.Forms.Label lblNuevoTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlListado;
        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Label lblListadoSub;
        private System.Windows.Forms.Label lblListado;
    }
}
