
namespace PresentacionGUI
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbRegistrar = new System.Windows.Forms.Label();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.txtIdentificacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNombreEstablecimiento = new System.Windows.Forms.Label();
            this.txtEdad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTiempoFuncionamiento = new System.Windows.Forms.Label();
            this.lbTipoResponsabilidad = new System.Windows.Forms.Label();
            this.bnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.pnDerecho = new Bunifu.UI.WinForms.BunifuPanel();
            this.pcImagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.cbFiltrar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPulsacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPulsacion = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbRegistrar
            // 
            this.lbRegistrar.AutoSize = true;
            this.lbRegistrar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbRegistrar.Location = new System.Drawing.Point(55, 42);
            this.lbRegistrar.Name = "lbRegistrar";
            this.lbRegistrar.Size = new System.Drawing.Size(173, 44);
            this.lbRegistrar.TabIndex = 7;
            this.lbRegistrar.Text = "Registrar";
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentificacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbIdentificacion.Location = new System.Drawing.Point(35, 123);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(98, 16);
            this.lbIdentificacion.TabIndex = 8;
            this.lbIdentificacion.Text = "Identificacion";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdentificacion.BorderRadius = 15;
            this.txtIdentificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentificacion.DefaultText = "";
            this.txtIdentificacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdentificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdentificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentificacion.DisabledState.Parent = this.txtIdentificacion;
            this.txtIdentificacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentificacion.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdentificacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentificacion.FocusedState.Parent = this.txtIdentificacion;
            this.txtIdentificacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentificacion.HoverState.Parent = this.txtIdentificacion;
            this.txtIdentificacion.Location = new System.Drawing.Point(38, 143);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.PasswordChar = '\0';
            this.txtIdentificacion.PlaceholderText = "";
            this.txtIdentificacion.SelectedText = "";
            this.txtIdentificacion.ShadowDecoration.Parent = this.txtIdentificacion;
            this.txtIdentificacion.Size = new System.Drawing.Size(146, 30);
            this.txtIdentificacion.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderRadius = 15;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(224, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(146, 30);
            this.txtNombre.TabIndex = 11;
            // 
            // lbNombreEstablecimiento
            // 
            this.lbNombreEstablecimiento.AutoSize = true;
            this.lbNombreEstablecimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreEstablecimiento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbNombreEstablecimiento.Location = new System.Drawing.Point(221, 123);
            this.lbNombreEstablecimiento.Name = "lbNombreEstablecimiento";
            this.lbNombreEstablecimiento.Size = new System.Drawing.Size(60, 16);
            this.lbNombreEstablecimiento.TabIndex = 10;
            this.lbNombreEstablecimiento.Text = "Nombre";
            // 
            // txtEdad
            // 
            this.txtEdad.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtEdad.BorderRadius = 15;
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.DefaultText = "";
            this.txtEdad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEdad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEdad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdad.DisabledState.Parent = this.txtEdad;
            this.txtEdad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdad.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtEdad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdad.FocusedState.Parent = this.txtEdad;
            this.txtEdad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdad.HoverState.Parent = this.txtEdad;
            this.txtEdad.Location = new System.Drawing.Point(224, 236);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.PlaceholderText = "";
            this.txtEdad.SelectedText = "";
            this.txtEdad.ShadowDecoration.Parent = this.txtEdad;
            this.txtEdad.Size = new System.Drawing.Size(146, 30);
            this.txtEdad.TabIndex = 19;
            // 
            // lbTiempoFuncionamiento
            // 
            this.lbTiempoFuncionamiento.AutoSize = true;
            this.lbTiempoFuncionamiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempoFuncionamiento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbTiempoFuncionamiento.Location = new System.Drawing.Point(218, 210);
            this.lbTiempoFuncionamiento.Name = "lbTiempoFuncionamiento";
            this.lbTiempoFuncionamiento.Size = new System.Drawing.Size(42, 16);
            this.lbTiempoFuncionamiento.TabIndex = 18;
            this.lbTiempoFuncionamiento.Text = "Edad";
            // 
            // lbTipoResponsabilidad
            // 
            this.lbTipoResponsabilidad.AutoSize = true;
            this.lbTipoResponsabilidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoResponsabilidad.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbTipoResponsabilidad.Location = new System.Drawing.Point(32, 210);
            this.lbTipoResponsabilidad.Name = "lbTipoResponsabilidad";
            this.lbTipoResponsabilidad.Size = new System.Drawing.Size(38, 16);
            this.lbTipoResponsabilidad.TabIndex = 16;
            this.lbTipoResponsabilidad.Text = "Sexo";
            // 
            // bnRegistrar
            // 
            this.bnRegistrar.BorderRadius = 15;
            this.bnRegistrar.CheckedState.Parent = this.bnRegistrar;
            this.bnRegistrar.CustomImages.Parent = this.bnRegistrar;
            this.bnRegistrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(238)))));
            this.bnRegistrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnRegistrar.ForeColor = System.Drawing.Color.White;
            this.bnRegistrar.HoverState.Parent = this.bnRegistrar;
            this.bnRegistrar.Location = new System.Drawing.Point(38, 390);
            this.bnRegistrar.Name = "bnRegistrar";
            this.bnRegistrar.ShadowDecoration.Parent = this.bnRegistrar;
            this.bnRegistrar.Size = new System.Drawing.Size(329, 31);
            this.bnRegistrar.TabIndex = 20;
            this.bnRegistrar.Text = "Registrar";
            this.bnRegistrar.Click += new System.EventHandler(this.bnRegistrar_Click);
            // 
            // pnDerecho
            // 
            this.pnDerecho.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnDerecho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnDerecho.BackgroundImage")));
            this.pnDerecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnDerecho.BorderColor = System.Drawing.Color.Transparent;
            this.pnDerecho.BorderRadius = 3;
            this.pnDerecho.BorderThickness = 1;
            this.pnDerecho.Controls.Add(this.pcImagen);
            this.pnDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDerecho.Location = new System.Drawing.Point(398, 0);
            this.pnDerecho.Name = "pnDerecho";
            this.pnDerecho.ShowBorders = true;
            this.pnDerecho.Size = new System.Drawing.Size(302, 503);
            this.pnDerecho.TabIndex = 6;
            // 
            // pcImagen
            // 
            this.pcImagen.Image = global::PresentacionGUI.Properties.Resources.Creativity_Customizable_Isometric_Illustrations___Amico_Style;
            this.pcImagen.Location = new System.Drawing.Point(-12, -72);
            this.pcImagen.Name = "pcImagen";
            this.pcImagen.ShadowDecoration.Parent = this.pcImagen;
            this.pcImagen.Size = new System.Drawing.Size(314, 617);
            this.pcImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImagen.TabIndex = 0;
            this.pcImagen.TabStop = false;
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.BorderRadius = 10;
            this.bnLimpiar.CheckedState.Parent = this.bnLimpiar;
            this.bnLimpiar.CustomImages.Parent = this.bnLimpiar;
            this.bnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(162)))), ((int)(((byte)(238)))));
            this.bnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLimpiar.ForeColor = System.Drawing.Color.White;
            this.bnLimpiar.HoverState.Parent = this.bnLimpiar;
            this.bnLimpiar.Location = new System.Drawing.Point(351, 84);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.ShadowDecoration.Parent = this.bnLimpiar;
            this.bnLimpiar.Size = new System.Drawing.Size(73, 27);
            this.bnLimpiar.TabIndex = 21;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.cbFiltrar.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cbFiltrar.BorderRadius = 15;
            this.cbFiltrar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.cbFiltrar.FocusedState.Parent = this.cbFiltrar;
            this.cbFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.HoverState.Parent = this.cbFiltrar;
            this.cbFiltrar.ItemHeight = 30;
            this.cbFiltrar.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbFiltrar.ItemsAppearance.Parent = this.cbFiltrar;
            this.cbFiltrar.Location = new System.Drawing.Point(44, 230);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.ShadowDecoration.Parent = this.cbFiltrar;
            this.cbFiltrar.Size = new System.Drawing.Size(140, 36);
            this.cbFiltrar.TabIndex = 22;
            // 
            // txtPulsacion
            // 
            this.txtPulsacion.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtPulsacion.BorderRadius = 15;
            this.txtPulsacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPulsacion.DefaultText = "";
            this.txtPulsacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPulsacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPulsacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPulsacion.DisabledState.Parent = this.txtPulsacion;
            this.txtPulsacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPulsacion.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPulsacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPulsacion.FocusedState.Parent = this.txtPulsacion;
            this.txtPulsacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPulsacion.HoverState.Parent = this.txtPulsacion;
            this.txtPulsacion.Location = new System.Drawing.Point(114, 302);
            this.txtPulsacion.Name = "txtPulsacion";
            this.txtPulsacion.PasswordChar = '\0';
            this.txtPulsacion.PlaceholderText = "";
            this.txtPulsacion.SelectedText = "";
            this.txtPulsacion.ShadowDecoration.Parent = this.txtPulsacion;
            this.txtPulsacion.Size = new System.Drawing.Size(114, 30);
            this.txtPulsacion.TabIndex = 24;
            // 
            // lbPulsacion
            // 
            this.lbPulsacion.AutoSize = true;
            this.lbPulsacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPulsacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbPulsacion.Location = new System.Drawing.Point(28, 311);
            this.lbPulsacion.Name = "lbPulsacion";
            this.lbPulsacion.Size = new System.Drawing.Size(70, 16);
            this.lbPulsacion.TabIndex = 23;
            this.lbPulsacion.Text = "Pulsacion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BorderRadius = 15;
            this.dateTimePicker1.CheckedState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(162)))), ((int)(((byte)(238)))));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.HoverState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 302);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShadowDecoration.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 37);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 15, 10, 32, 49, 959);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 503);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPulsacion);
            this.Controls.Add(this.lbPulsacion);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.bnRegistrar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lbTiempoFuncionamiento);
            this.Controls.Add(this.lbTipoResponsabilidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombreEstablecimiento);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lbIdentificacion);
            this.Controls.Add(this.lbRegistrar);
            this.Controls.Add(this.pnDerecho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.pnDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel pnDerecho;
        private Guna.UI2.WinForms.Guna2PictureBox pcImagen;
        private Guna.UI2.WinForms.Guna2TextBox txtEdad;
        private System.Windows.Forms.Label lbTiempoFuncionamiento;
        private System.Windows.Forms.Label lbTipoResponsabilidad;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label lbNombreEstablecimiento;
        private Guna.UI2.WinForms.Guna2TextBox txtIdentificacion;
        private System.Windows.Forms.Label lbIdentificacion;
        private System.Windows.Forms.Label lbRegistrar;
        private Guna.UI2.WinForms.Guna2Button bnRegistrar;
        private Guna.UI2.WinForms.Guna2Button bnLimpiar;
        private Guna.UI2.WinForms.Guna2ComboBox cbFiltrar;
        private Guna.UI2.WinForms.Guna2TextBox txtPulsacion;
        private System.Windows.Forms.Label lbPulsacion;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
    }
}