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
    public partial class FrmRegistro : Form
    {
        PersonaService personaService;
        public FrmRegistro()
        {
            InitializeComponent();
            personaService = new PersonaService(ConfigConnectionString.ConnectionString);
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }
        public void LimpiarComponentes()
        {
            txtIdentificacion.Text = null;
            txtNombre.Text = null;
            txtEdad.Text = null;
            cbFiltrar.Text = null;
            txtPulsacion.Text = null;
        }

        private void bnRegistrar_Click(object sender, EventArgs e)
        {
            var persona = RegistrarDatos();
            string mensaje = personaService.Guarda(persona);
            MessageBox.Show(mensaje);
            LimpiarComponentes();
        }

        public Persona RegistrarDatos()
        {
            Persona persona = new Persona();
            persona.Identificacion = txtIdentificacion.Text;
            persona.Nombre = txtNombre.Text;
            persona.Edad = int.Parse(txtEdad.Text);
            persona.Sexo = cbFiltrar.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;
            persona.CalcularPulsacion();
            txtPulsacion.Text = persona.Pulsacion.ToString();
            return persona;
           
        }
    }
}
