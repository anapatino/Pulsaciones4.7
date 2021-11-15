
namespace PresentacionGUI
{
    partial class FrmEliminar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.bnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.bnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbEliminar = new System.Windows.Forms.Label();
            this.pcImagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.dgvTabla = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cnIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnPulsacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.BorderRadius = 15;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.DefaultText = "";
            this.txtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.DisabledState.Parent = this.txtBusqueda;
            this.txtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.FocusedState.Parent = this.txtBusqueda;
            this.txtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.HoverState.Parent = this.txtBusqueda;
            this.txtBusqueda.Location = new System.Drawing.Point(229, 183);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.PlaceholderText = "";
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.ShadowDecoration.Parent = this.txtBusqueda;
            this.txtBusqueda.Size = new System.Drawing.Size(257, 36);
            this.txtBusqueda.TabIndex = 17;
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.Animated = true;
            this.bnLimpiar.BorderRadius = 15;
            this.bnLimpiar.CheckedState.Parent = this.bnLimpiar;
            this.bnLimpiar.CustomImages.Parent = this.bnLimpiar;
            this.bnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(238)))));
            this.bnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLimpiar.ForeColor = System.Drawing.Color.White;
            this.bnLimpiar.HoverState.Parent = this.bnLimpiar;
            this.bnLimpiar.Location = new System.Drawing.Point(540, 448);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.ShadowDecoration.Parent = this.bnLimpiar;
            this.bnLimpiar.Size = new System.Drawing.Size(91, 31);
            this.bnLimpiar.TabIndex = 14;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // bnBuscar
            // 
            this.bnBuscar.Animated = true;
            this.bnBuscar.BorderRadius = 15;
            this.bnBuscar.CheckedState.Parent = this.bnBuscar;
            this.bnBuscar.CustomImages.Parent = this.bnBuscar;
            this.bnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(238)))));
            this.bnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBuscar.ForeColor = System.Drawing.Color.White;
            this.bnBuscar.HoverState.Parent = this.bnBuscar;
            this.bnBuscar.Image = global::PresentacionGUI.Properties.Resources.edit_find_symbolic_362052;
            this.bnBuscar.Location = new System.Drawing.Point(502, 188);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.ShadowDecoration.Parent = this.bnBuscar;
            this.bnBuscar.Size = new System.Drawing.Size(37, 31);
            this.bnBuscar.TabIndex = 19;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(68)))), ((int)(((byte)(225)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lbEliminar);
            this.bunifuPanel1.Controls.Add(this.pcImagen);
            this.bunifuPanel1.Location = new System.Drawing.Point(39, 23);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(429, 116);
            this.bunifuPanel1.TabIndex = 6;
            // 
            // lbEliminar
            // 
            this.lbEliminar.AutoSize = true;
            this.lbEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lbEliminar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbEliminar.Location = new System.Drawing.Point(157, 32);
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(159, 44);
            this.lbEliminar.TabIndex = 2;
            this.lbEliminar.Text = "Eliminar";
            // 
            // pcImagen
            // 
            this.pcImagen.BackColor = System.Drawing.Color.Transparent;
            this.pcImagen.Image = global::PresentacionGUI.Properties.Resources.Add_files_Customizable_Isometric_Illustrations___Amico_Style;
            this.pcImagen.Location = new System.Drawing.Point(2, -2);
            this.pcImagen.Name = "pcImagen";
            this.pcImagen.ShadowDecoration.Parent = this.pcImagen;
            this.pcImagen.Size = new System.Drawing.Size(182, 126);
            this.pcImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImagen.TabIndex = 1;
            this.pcImagen.TabStop = false;
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltrar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbFiltrar.Location = new System.Drawing.Point(77, 188);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(146, 19);
            this.lbFiltrar.TabIndex = 16;
            this.lbFiltrar.Text = "Nro Identificacion";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(162)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabla.ColumnHeadersHeight = 22;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnIdentificacion,
            this.cnNombre,
            this.cnEdad,
            this.cnSexo,
            this.cnPulsacion,
            this.cnFecha});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTabla.EnableHeadersVisualStyles = false;
            this.dgvTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTabla.Location = new System.Drawing.Point(53, 245);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Thistle;
            this.dgvTabla.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(578, 180);
            this.dgvTabla.TabIndex = 20;
            this.dgvTabla.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvTabla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTabla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTabla.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgvTabla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTabla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTabla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTabla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTabla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTabla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTabla.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvTabla.ThemeStyle.ReadOnly = true;
            this.dgvTabla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTabla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTabla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTabla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTabla.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTabla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTabla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cnIdentificacion
            // 
            this.cnIdentificacion.HeaderText = "Identificacion";
            this.cnIdentificacion.Name = "cnIdentificacion";
            this.cnIdentificacion.ReadOnly = true;
            // 
            // cnNombre
            // 
            this.cnNombre.HeaderText = "Nombre";
            this.cnNombre.Name = "cnNombre";
            this.cnNombre.ReadOnly = true;
            // 
            // cnEdad
            // 
            this.cnEdad.HeaderText = "Edad";
            this.cnEdad.Name = "cnEdad";
            this.cnEdad.ReadOnly = true;
            // 
            // cnSexo
            // 
            this.cnSexo.HeaderText = "Sexo";
            this.cnSexo.Name = "cnSexo";
            this.cnSexo.ReadOnly = true;
            // 
            // cnPulsacion
            // 
            this.cnPulsacion.HeaderText = "Pulsacion";
            this.cnPulsacion.Name = "cnPulsacion";
            this.cnPulsacion.ReadOnly = true;
            // 
            // cnFecha
            // 
            this.cnFecha.HeaderText = "Fecha Nacimiento";
            this.cnFecha.Name = "cnFecha";
            this.cnFecha.ReadOnly = true;
            // 
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 503);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminar";
            this.Text = "FrmEliminar";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label lbEliminar;
        private Guna.UI2.WinForms.Guna2PictureBox pcImagen;
        private Guna.UI2.WinForms.Guna2Button bnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtBusqueda;
        private Guna.UI2.WinForms.Guna2Button bnLimpiar;
        private System.Windows.Forms.Label lbFiltrar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnPulsacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnFecha;
    }
}