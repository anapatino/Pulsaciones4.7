using Entidad;
using Logica;
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
    public partial class FrmEliminar : Form
    {
        PersonaService personaService;
        public FrmEliminar()
        {
            InitializeComponent();
            personaService = new PersonaService(ConfigConnectionString.ConnectionString);
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            Visualizar();
        }

        public void Visualizar()
        {
            Persona persona = new Persona();
            string identificacion = txtBusqueda.Text;
            var (mensaje, personaEliminada) = personaService.Eliminar(identificacion);
            if (mensaje.Equals($"Se Eliminó el registro de la persona con identificacion {identificacion}"))
            {
                ActivarTabla(personaEliminada);
            }
            MessageBox.Show(mensaje);
            LimpiarComponentes();
        }
        public void ActivarTabla(Persona personaEliminada)
        {
            dgvTabla.Visible = true;
            dgvTabla.Rows.Add(personaEliminada.Identificacion, personaEliminada.Nombre, personaEliminada.Edad, personaEliminada.Sexo, personaEliminada.Pulsacion,personaEliminada.FechaNacimiento.Year);
        }


        public void LimpiarComponentes()
        {
            dgvTabla.Rows.Clear();
            dgvTabla.Visible = false;
            txtBusqueda.Text = null;
        }
    }
}
