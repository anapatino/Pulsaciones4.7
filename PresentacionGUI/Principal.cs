using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            OpenFormHijo(new Home());
        }

        private Form activeForm = null;
        private void OpenFormHijo(Form hijoForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = hijoForm;
            hijoForm.TopLevel = false;
            hijoForm.FormBorderStyle = FormBorderStyle.None;
            hijoForm.Dock = DockStyle.Fill;
            pnCentral.Controls.Add(hijoForm);
            pnCentral.Tag = hijoForm;
            hijoForm.BringToFront();
            hijoForm.Show();
        }

        private void bnInicio_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new Home());
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnRegistro_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmRegistro());
        }

        private void bnConsulta_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmConsultar());
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmBuscar());
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new FrmEliminar());
        }
    }
}
