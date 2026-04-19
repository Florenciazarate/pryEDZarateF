namespace pryEDZarateF
{
    partial class frmAlumnos
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.groupAlumnos = new System.Windows.Forms.GroupBox();
            this.groupBienvenido = new System.Windows.Forms.GroupBox();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.groupAlumnos.SuspendLayout();
            this.groupBienvenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(70, 109);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 17);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCodigo.Location = new System.Drawing.Point(135, 108);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 22);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCampos_TextChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGrabar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(204, 172);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(79, 32);
            this.btnGrabar.TabIndex = 16;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(70, 157);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 17);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNombre.Location = new System.Drawing.Point(135, 154);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtCampos_TextChanged);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(70, 203);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(52, 17);
            this.lblCarrera.TabIndex = 24;
            this.lblCarrera.Text = "Carrera";
            // 
            // dgvAlumnos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmCarrera});
            this.dgvAlumnos.Location = new System.Drawing.Point(375, 46);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(341, 240);
            this.dgvAlumnos.TabIndex = 25;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCarrera.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(134, 200);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(200, 21);
            this.cmbCarrera.TabIndex = 26;
            // 
            // groupAlumnos
            // 
            this.groupAlumnos.Controls.Add(this.btnGrabar);
            this.groupAlumnos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAlumnos.Location = new System.Drawing.Point(28, 46);
            this.groupAlumnos.Name = "groupAlumnos";
            this.groupAlumnos.Size = new System.Drawing.Size(326, 240);
            this.groupAlumnos.TabIndex = 27;
            this.groupAlumnos.TabStop = false;
            this.groupAlumnos.Text = "Ingresar datos del alumno";
            // 
            // groupBienvenido
            // 
            this.groupBienvenido.Controls.Add(this.groupAlumnos);
            this.groupBienvenido.Controls.Add(this.dgvAlumnos);
            this.groupBienvenido.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBienvenido.Location = new System.Drawing.Point(22, 12);
            this.groupBienvenido.Name = "groupBienvenido";
            this.groupBienvenido.Size = new System.Drawing.Size(766, 316);
            this.groupBienvenido.TabIndex = 28;
            this.groupBienvenido.TabStop = false;
            this.groupBienvenido.Text = "Bienvenido a la sección alumnos";
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
            // clmCarrera
            // 
            this.clmCarrera.HeaderText = "Carrera";
            this.clmCarrera.Name = "clmCarrera";
            this.clmCarrera.ReadOnly = true;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(813, 356);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.groupBienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.groupAlumnos.ResumeLayout(false);
            this.groupBienvenido.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.GroupBox groupAlumnos;
        private System.Windows.Forms.GroupBox groupBienvenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCarrera;
    }
}
