
namespace PresentacionGUI
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnCentral = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnIzquierdo = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnConsulta = new Bunifu.UI.WinForms.BunifuPanel();
            this.bnConsulta = new Guna.UI2.WinForms.Guna2Button();
            this.pnEspacio2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bnRegistro = new Guna.UI2.WinForms.Guna2Button();
            this.pnIzquierdoInferior = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnSalir = new Bunifu.UI.WinForms.BunifuPanel();
            this.btSalir = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnEspacio = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnInicio = new Bunifu.UI.WinForms.BunifuPanel();
            this.bnInicio = new Guna.UI2.WinForms.Guna2Button();
            this.pnInquierdoSuperior = new Bunifu.UI.WinForms.BunifuPanel();
            this.pcInicio = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnIzquierdo.SuspendLayout();
            this.bunifuPanel4.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.pnConsulta.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.pnIzquierdoInferior.SuspendLayout();
            this.pnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSalir)).BeginInit();
            this.pnInicio.SuspendLayout();
            this.pnInquierdoSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnCentral
            // 
            this.pnCentral.BackgroundColor = System.Drawing.SystemColors.Window;
            this.pnCentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnCentral.BackgroundImage")));
            this.pnCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnCentral.BorderColor = System.Drawing.Color.Transparent;
            this.pnCentral.BorderRadius = 30;
            this.pnCentral.BorderThickness = 1;
            this.pnCentral.Location = new System.Drawing.Point(145, 12);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.ShowBorders = true;
            this.pnCentral.Size = new System.Drawing.Size(716, 542);
            this.pnCentral.TabIndex = 1;
            // 
            // pnIzquierdo
            // 
            this.pnIzquierdo.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnIzquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnIzquierdo.BackgroundImage")));
            this.pnIzquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnIzquierdo.BorderColor = System.Drawing.Color.Transparent;
            this.pnIzquierdo.BorderRadius = 3;
            this.pnIzquierdo.BorderThickness = 1;
            this.pnIzquierdo.Controls.Add(this.bunifuPanel4);
            this.pnIzquierdo.Controls.Add(this.bunifuPanel5);
            this.pnIzquierdo.Controls.Add(this.bunifuPanel2);
            this.pnIzquierdo.Controls.Add(this.bunifuPanel3);
            this.pnIzquierdo.Controls.Add(this.pnConsulta);
            this.pnIzquierdo.Controls.Add(this.pnEspacio2);
            this.pnIzquierdo.Controls.Add(this.bunifuPanel1);
            this.pnIzquierdo.Controls.Add(this.pnIzquierdoInferior);
            this.pnIzquierdo.Controls.Add(this.pnEspacio);
            this.pnIzquierdo.Controls.Add(this.pnInicio);
            this.pnIzquierdo.Controls.Add(this.pnInquierdoSuperior);
            this.pnIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnIzquierdo.Name = "pnIzquierdo";
            this.pnIzquierdo.ShowBorders = true;
            this.pnIzquierdo.Size = new System.Drawing.Size(164, 566);
            this.pnIzquierdo.TabIndex = 2;
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BorderRadius = 3;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.bnEliminar);
            this.bunifuPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel4.Location = new System.Drawing.Point(0, 378);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(164, 37);
            this.bunifuPanel4.TabIndex = 11;
            // 
            // bnEliminar
            // 
            this.bnEliminar.Animated = true;
            this.bnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.bnEliminar.BorderColor = System.Drawing.Color.Transparent;
            this.bnEliminar.BorderRadius = 20;
            this.bnEliminar.CheckedState.Parent = this.bnEliminar;
            this.bnEliminar.CustomImages.Parent = this.bnEliminar;
            this.bnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnEliminar.FillColor = System.Drawing.Color.Transparent;
            this.bnEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnEliminar.ForeColor = System.Drawing.Color.White;
            this.bnEliminar.HoverState.Parent = this.bnEliminar;
            this.bnEliminar.Image = global::PresentacionGUI.Properties.Resources.contenedor_de_basura;
            this.bnEliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnEliminar.Location = new System.Drawing.Point(23, 0);
            this.bnEliminar.Name = "bnEliminar";
            this.bnEliminar.ShadowDecoration.Parent = this.bnEliminar;
            this.bnEliminar.Size = new System.Drawing.Size(141, 37);
            this.bnEliminar.TabIndex = 1;
            this.bnEliminar.Text = "Eliminar";
            this.bnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnEliminar.Click += new System.EventHandler(this.bnEliminar_Click);
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BorderRadius = 3;
            this.bunifuPanel5.BorderThickness = 1;
            this.bunifuPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel5.Location = new System.Drawing.Point(0, 361);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(164, 17);
            this.bunifuPanel5.TabIndex = 10;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bnBuscar);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 324);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(164, 37);
            this.bunifuPanel2.TabIndex = 9;
            // 
            // bnBuscar
            // 
            this.bnBuscar.Animated = true;
            this.bnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.bnBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.bnBuscar.BorderRadius = 20;
            this.bnBuscar.CheckedState.Parent = this.bnBuscar;
            this.bnBuscar.CustomImages.Parent = this.bnBuscar;
            this.bnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnBuscar.FillColor = System.Drawing.Color.Transparent;
            this.bnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBuscar.ForeColor = System.Drawing.Color.White;
            this.bnBuscar.HoverState.Parent = this.bnBuscar;
            this.bnBuscar.Image = global::PresentacionGUI.Properties.Resources.buscar;
            this.bnBuscar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnBuscar.Location = new System.Drawing.Point(23, 0);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.ShadowDecoration.Parent = this.bnBuscar;
            this.bnBuscar.Size = new System.Drawing.Size(141, 37);
            this.bnBuscar.TabIndex = 1;
            this.bnBuscar.Text = "Buscar";
            this.bnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel3.Location = new System.Drawing.Point(0, 307);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(164, 17);
            this.bunifuPanel3.TabIndex = 8;
            // 
            // pnConsulta
            // 
            this.pnConsulta.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnConsulta.BackgroundImage")));
            this.pnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnConsulta.BorderColor = System.Drawing.Color.Transparent;
            this.pnConsulta.BorderRadius = 3;
            this.pnConsulta.BorderThickness = 1;
            this.pnConsulta.Controls.Add(this.bnConsulta);
            this.pnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnConsulta.Location = new System.Drawing.Point(0, 270);
            this.pnConsulta.Name = "pnConsulta";
            this.pnConsulta.ShowBorders = true;
            this.pnConsulta.Size = new System.Drawing.Size(164, 37);
            this.pnConsulta.TabIndex = 7;
            // 
            // bnConsulta
            // 
            this.bnConsulta.Animated = true;
            this.bnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.bnConsulta.BorderColor = System.Drawing.Color.Transparent;
            this.bnConsulta.BorderRadius = 20;
            this.bnConsulta.CheckedState.Parent = this.bnConsulta;
            this.bnConsulta.CustomImages.Parent = this.bnConsulta;
            this.bnConsulta.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnConsulta.FillColor = System.Drawing.Color.Transparent;
            this.bnConsulta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnConsulta.ForeColor = System.Drawing.Color.White;
            this.bnConsulta.HoverState.Parent = this.bnConsulta;
            this.bnConsulta.Image = global::PresentacionGUI.Properties.Resources.navegador;
            this.bnConsulta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnConsulta.Location = new System.Drawing.Point(23, 0);
            this.bnConsulta.Name = "bnConsulta";
            this.bnConsulta.ShadowDecoration.Parent = this.bnConsulta;
            this.bnConsulta.Size = new System.Drawing.Size(141, 37);
            this.bnConsulta.TabIndex = 1;
            this.bnConsulta.Text = "Consulta";
            this.bnConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnConsulta.Click += new System.EventHandler(this.bnConsulta_Click);
            // 
            // pnEspacio2
            // 
            this.pnEspacio2.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnEspacio2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnEspacio2.BackgroundImage")));
            this.pnEspacio2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnEspacio2.BorderColor = System.Drawing.Color.Transparent;
            this.pnEspacio2.BorderRadius = 3;
            this.pnEspacio2.BorderThickness = 1;
            this.pnEspacio2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEspacio2.Location = new System.Drawing.Point(0, 253);
            this.pnEspacio2.Name = "pnEspacio2";
            this.pnEspacio2.ShowBorders = true;
            this.pnEspacio2.Size = new System.Drawing.Size(164, 17);
            this.pnEspacio2.TabIndex = 6;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bnRegistro);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 216);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(164, 37);
            this.bunifuPanel1.TabIndex = 5;
            // 
            // bnRegistro
            // 
            this.bnRegistro.Animated = true;
            this.bnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.bnRegistro.BorderColor = System.Drawing.Color.Transparent;
            this.bnRegistro.BorderRadius = 20;
            this.bnRegistro.CheckedState.Parent = this.bnRegistro;
            this.bnRegistro.CustomImages.Parent = this.bnRegistro;
            this.bnRegistro.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnRegistro.FillColor = System.Drawing.Color.Transparent;
            this.bnRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnRegistro.ForeColor = System.Drawing.Color.White;
            this.bnRegistro.HoverState.Parent = this.bnRegistro;
            this.bnRegistro.Image = global::PresentacionGUI.Properties.Resources.documento;
            this.bnRegistro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnRegistro.Location = new System.Drawing.Point(23, 0);
            this.bnRegistro.Name = "bnRegistro";
            this.bnRegistro.ShadowDecoration.Parent = this.bnRegistro;
            this.bnRegistro.Size = new System.Drawing.Size(141, 37);
            this.bnRegistro.TabIndex = 1;
            this.bnRegistro.Text = "Registro";
            this.bnRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnRegistro.Click += new System.EventHandler(this.bnRegistro_Click);
            // 
            // pnIzquierdoInferior
            // 
            this.pnIzquierdoInferior.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnIzquierdoInferior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnIzquierdoInferior.BackgroundImage")));
            this.pnIzquierdoInferior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnIzquierdoInferior.BorderColor = System.Drawing.Color.Transparent;
            this.pnIzquierdoInferior.BorderRadius = 3;
            this.pnIzquierdoInferior.BorderThickness = 1;
            this.pnIzquierdoInferior.Controls.Add(this.pnSalir);
            this.pnIzquierdoInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnIzquierdoInferior.Location = new System.Drawing.Point(0, 438);
            this.pnIzquierdoInferior.Name = "pnIzquierdoInferior";
            this.pnIzquierdoInferior.ShowBorders = true;
            this.pnIzquierdoInferior.Size = new System.Drawing.Size(164, 128);
            this.pnIzquierdoInferior.TabIndex = 4;
            // 
            // pnSalir
            // 
            this.pnSalir.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSalir.BackgroundImage")));
            this.pnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnSalir.BorderColor = System.Drawing.Color.Transparent;
            this.pnSalir.BorderRadius = 3;
            this.pnSalir.BorderThickness = 1;
            this.pnSalir.Controls.Add(this.btSalir);
            this.pnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSalir.Location = new System.Drawing.Point(0, 75);
            this.pnSalir.Name = "pnSalir";
            this.pnSalir.ShowBorders = true;
            this.pnSalir.Size = new System.Drawing.Size(164, 53);
            this.pnSalir.TabIndex = 0;
            // 
            // btSalir
            // 
            this.btSalir.Image = global::PresentacionGUI.Properties.Resources.registrarse;
            this.btSalir.Location = new System.Drawing.Point(23, 20);
            this.btSalir.Name = "btSalir";
            this.btSalir.ShadowDecoration.Parent = this.btSalir;
            this.btSalir.Size = new System.Drawing.Size(29, 21);
            this.btSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSalir.TabIndex = 1;
            this.btSalir.TabStop = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // pnEspacio
            // 
            this.pnEspacio.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnEspacio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnEspacio.BackgroundImage")));
            this.pnEspacio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnEspacio.BorderColor = System.Drawing.Color.Transparent;
            this.pnEspacio.BorderRadius = 3;
            this.pnEspacio.BorderThickness = 1;
            this.pnEspacio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEspacio.Location = new System.Drawing.Point(0, 199);
            this.pnEspacio.Name = "pnEspacio";
            this.pnEspacio.ShowBorders = true;
            this.pnEspacio.Size = new System.Drawing.Size(164, 17);
            this.pnEspacio.TabIndex = 2;
            // 
            // pnInicio
            // 
            this.pnInicio.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnInicio.BackgroundImage")));
            this.pnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnInicio.BorderColor = System.Drawing.Color.Transparent;
            this.pnInicio.BorderRadius = 3;
            this.pnInicio.BorderThickness = 1;
            this.pnInicio.Controls.Add(this.bnInicio);
            this.pnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInicio.Location = new System.Drawing.Point(0, 162);
            this.pnInicio.Name = "pnInicio";
            this.pnInicio.ShowBorders = true;
            this.pnInicio.Size = new System.Drawing.Size(164, 37);
            this.pnInicio.TabIndex = 1;
            // 
            // bnInicio
            // 
            this.bnInicio.Animated = true;
            this.bnInicio.BackColor = System.Drawing.Color.Transparent;
            this.bnInicio.BorderColor = System.Drawing.Color.Transparent;
            this.bnInicio.BorderRadius = 20;
            this.bnInicio.CheckedState.Parent = this.bnInicio;
            this.bnInicio.CustomImages.Parent = this.bnInicio;
            this.bnInicio.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnInicio.FillColor = System.Drawing.Color.Transparent;
            this.bnInicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnInicio.ForeColor = System.Drawing.Color.White;
            this.bnInicio.HoverState.Parent = this.bnInicio;
            this.bnInicio.Image = global::PresentacionGUI.Properties.Resources.pagina_de_inicio;
            this.bnInicio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnInicio.Location = new System.Drawing.Point(23, 0);
            this.bnInicio.Name = "bnInicio";
            this.bnInicio.ShadowDecoration.Parent = this.bnInicio;
            this.bnInicio.Size = new System.Drawing.Size(141, 37);
            this.bnInicio.TabIndex = 0;
            this.bnInicio.Text = "Inicio";
            this.bnInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnInicio.Click += new System.EventHandler(this.bnInicio_Click);
            // 
            // pnInquierdoSuperior
            // 
            this.pnInquierdoSuperior.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnInquierdoSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnInquierdoSuperior.BackgroundImage")));
            this.pnInquierdoSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnInquierdoSuperior.BorderColor = System.Drawing.Color.Transparent;
            this.pnInquierdoSuperior.BorderRadius = 3;
            this.pnInquierdoSuperior.BorderThickness = 1;
            this.pnInquierdoSuperior.Controls.Add(this.pcInicio);
            this.pnInquierdoSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInquierdoSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnInquierdoSuperior.Name = "pnInquierdoSuperior";
            this.pnInquierdoSuperior.ShowBorders = true;
            this.pnInquierdoSuperior.Size = new System.Drawing.Size(164, 162);
            this.pnInquierdoSuperior.TabIndex = 0;
            // 
            // pcInicio
            // 
            this.pcInicio.Image = global::PresentacionGUI.Properties.Resources.menu__1_;
            this.pcInicio.Location = new System.Drawing.Point(51, 44);
            this.pcInicio.Name = "pcInicio";
            this.pcInicio.ShadowDecoration.Parent = this.pcInicio;
            this.pcInicio.Size = new System.Drawing.Size(41, 33);
            this.pcInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcInicio.TabIndex = 0;
            this.pcInicio.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(873, 566);
            this.Controls.Add(this.pnCentral);
            this.Controls.Add(this.pnIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.pnIzquierdo.ResumeLayout(false);
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.pnConsulta.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.pnIzquierdoInferior.ResumeLayout(false);
            this.pnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btSalir)).EndInit();
            this.pnInicio.ResumeLayout(false);
            this.pnInquierdoSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel pnCentral;
        private Bunifu.UI.WinForms.BunifuPanel pnIzquierdo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel pnIzquierdoInferior;
        private Bunifu.UI.WinForms.BunifuPanel pnSalir;
        private Bunifu.UI.WinForms.BunifuPanel pnEspacio;
        private Bunifu.UI.WinForms.BunifuPanel pnInicio;
        private Guna.UI2.WinForms.Guna2Button bnInicio;
        private Bunifu.UI.WinForms.BunifuPanel pnInquierdoSuperior;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Guna.UI2.WinForms.Guna2Button bnRegistro;
        private Bunifu.UI.WinForms.BunifuPanel pnConsulta;
        private Guna.UI2.WinForms.Guna2Button bnConsulta;
        private Bunifu.UI.WinForms.BunifuPanel pnEspacio2;
        private Guna.UI2.WinForms.Guna2PictureBox pcInicio;
        private Guna.UI2.WinForms.Guna2PictureBox btSalir;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Guna.UI2.WinForms.Guna2Button bnBuscar;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Guna.UI2.WinForms.Guna2Button bnEliminar;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
    }
}

