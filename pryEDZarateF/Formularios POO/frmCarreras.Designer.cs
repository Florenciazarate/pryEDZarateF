namespace pryEDZarateF
{
    partial class frmCarreras
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
            this.pnlNueva = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGrabar = new Guna.UI2.WinForms.Guna2Button();
            this.txtNombreCarrera = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNuevoSub = new System.Windows.Forms.Label();
            this.lblNuevoTitulo = new System.Windows.Forms.Label();
            this.pnlListado = new Guna.UI2.WinForms.Guna2Panel();
            this.lstCarreras = new System.Windows.Forms.ListBox();
            this.lblListadoSub = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlNueva.SuspendLayout();
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
            this.pnlBarraColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlBarraColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
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
            this.lblSubtitulo.Size = new System.Drawing.Size(200, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Gestión de carreras académicas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Carreras";
            // 
            // pnlNueva
            // 
            this.pnlNueva.BackColor = System.Drawing.Color.Transparent;
            this.pnlNueva.BorderRadius = 14;
            this.pnlNueva.Controls.Add(this.btnGrabar);
            this.pnlNueva.Controls.Add(this.txtNombreCarrera);
            this.pnlNueva.Controls.Add(this.lblNuevoSub);
            this.pnlNueva.Controls.Add(this.lblNuevoTitulo);
            this.pnlNueva.FillColor = System.Drawing.Color.White;
            this.pnlNueva.Location = new System.Drawing.Point(25, 115);
            this.pnlNueva.Name = "pnlNueva";
            this.pnlNueva.ShadowDecoration.BorderRadius = 14;
            this.pnlNueva.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.pnlNueva.ShadowDecoration.Depth = 8;
            this.pnlNueva.ShadowDecoration.Enabled = true;
            this.pnlNueva.Size = new System.Drawing.Size(380, 249);
            this.pnlNueva.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BorderRadius = 8;
            this.btnGrabar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrabar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrabar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnGrabar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnGrabar.Location = new System.Drawing.Point(32, 141);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(330, 45);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.txtNombreCarrera.BorderRadius = 8;
            this.txtNombreCarrera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCarrera.DefaultText = "";
            this.txtNombreCarrera.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreCarrera.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreCarrera.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCarrera.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCarrera.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.txtNombreCarrera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreCarrera.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
            this.txtNombreCarrera.Location = new System.Drawing.Point(32, 86);
            this.txtNombreCarrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.PlaceholderText = "Ej: Ingeniería en Sistemas";
            this.txtNombreCarrera.SelectedText = "";
            this.txtNombreCarrera.Size = new System.Drawing.Size(330, 40);
            this.txtNombreCarrera.TabIndex = 3;
            this.txtNombreCarrera.TextChanged += new System.EventHandler(this.txtNombreCarrera_TextChanged);
            // 
            // lblNuevoSub
            // 
            this.lblNuevoSub.AutoSize = true;
            this.lblNuevoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNuevoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNuevoSub.Location = new System.Drawing.Point(30, 60);
            this.lblNuevoSub.Name = "lblNuevoSub";
            this.lblNuevoSub.Size = new System.Drawing.Size(251, 15);
            this.lblNuevoSub.TabIndex = 1;
            this.lblNuevoSub.Text = "Cargá una nueva carrera al sistema académico";
            // 
            // lblNuevoTitulo
            // 
            this.lblNuevoTitulo.AutoSize = true;
            this.lblNuevoTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblNuevoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblNuevoTitulo.Location = new System.Drawing.Point(27, 31);
            this.lblNuevoTitulo.Name = "lblNuevoTitulo";
            this.lblNuevoTitulo.Size = new System.Drawing.Size(133, 25);
            this.lblNuevoTitulo.TabIndex = 0;
            this.lblNuevoTitulo.Text = "Nueva carrera";
            // 
            // pnlListado
            // 
            this.pnlListado.BackColor = System.Drawing.Color.Transparent;
            this.pnlListado.BorderRadius = 14;
            this.pnlListado.Controls.Add(this.lstCarreras);
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
            // lstCarreras
            // 
            this.lstCarreras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lstCarreras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCarreras.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstCarreras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.IntegralHeight = false;
            this.lstCarreras.ItemHeight = 17;
            this.lstCarreras.Location = new System.Drawing.Point(25, 95);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(400, 240);
            this.lstCarreras.TabIndex = 2;
            // 
            // lblListadoSub
            // 
            this.lblListadoSub.AutoSize = true;
            this.lblListadoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblListadoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblListadoSub.Location = new System.Drawing.Point(25, 55);
            this.lblListadoSub.Name = "lblListadoSub";
            this.lblListadoSub.Size = new System.Drawing.Size(171, 15);
            this.lblListadoSub.TabIndex = 1;
            this.lblListadoSub.Text = "Carreras cargadas en el sistema";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblListado.Location = new System.Drawing.Point(22, 25);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(172, 25);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Listado de carreras";
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.pnlNueva);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreras";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNueva.ResumeLayout(false);
            this.pnlNueva.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            this.pnlListado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlBarraColor;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlNueva;
        private Guna.UI2.WinForms.Guna2Button btnGrabar;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreCarrera;
        private System.Windows.Forms.Label lblNuevoTitulo;
        private System.Windows.Forms.Label lblNuevoSub;
        private Guna.UI2.WinForms.Guna2Panel pnlListado;
        private System.Windows.Forms.ListBox lstCarreras;
        private System.Windows.Forms.Label lblListadoSub;
        private System.Windows.Forms.Label lblListado;
    }
}
