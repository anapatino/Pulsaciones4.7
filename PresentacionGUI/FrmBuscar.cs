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
    public partial class FrmBuscar : Form
    {
        PersonaService personaService;
        public FrmBuscar()
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
            dgvTabla.Visible = false;
            dgvTabla.Rows.Clear();
            cbFiltrar.Text = null;
            txtBusqueda.Text = null;
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            ValidarFiltro();
        }

        private void ValidarFiltro()
        {
            string filtro = cbFiltrar.Text;
            if (filtro.Equals("SEXO"))
            {
                VisualizarSexo();
            }
            else if (filtro.Equals("IDENTIFICACION"))
            {
                VisualizarIdentificacion();
            }
            else if (filtro.Equals("ANIO"))
            {
                VisualizarAnio();
            }
            else if (filtro.Equals("PALABRA"))
            {
                VisualizarPalabra();
            }

        }

        public void VisualizarIdentificacion()
        {
            string identificacion = txtBusqueda.Text;
            var (mensaje, personaBuscada) = personaService.Buscar(identificacion);
            if (mensaje.Equals($" Se encuentra Registrado {identificacion}"))
            {
                ActivarTabla(personaBuscada);
            }
            MessageBox.Show(mensaje);
        }

        public void VisualizarSexo()
        {
            PersonaConsultaResponse respuesta;
            string sexo = txtBusqueda.Text;
            respuesta = personaService.ConsultarPorSexo(sexo);
            AgregarRegistroPanel(respuesta);
        }

        public void AgregarRegistroPanel(PersonaConsultaResponse respuesta)
        {
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvTabla.Visible = true;
                foreach (var item in respuesta.Personas)
                {
                    dgvTabla.Rows.Add(item.Identificacion, item.Nombre, item.Edad, item.Sexo, item.Pulsacion, item.FechaNacimiento.Year);
                }

            }
        }

        public void VisualizarPalabra()
        {
            PersonaConsultaResponse respuesta;
            string palabra = txtBusqueda.Text;
            respuesta = personaService.ConsultarPorPalabra(palabra);
            AgregarRegistroPanel(respuesta);
        }

        public void VisualizarAnio()
        {
            PersonaConsultaResponse respuesta;
            int year = int.Parse(txtBusqueda.Text);
            respuesta = personaService.ConsultarPorAnio(year);
            AgregarRegistroPanel(respuesta);
        }
        public void ActivarTabla(Persona personaBuscada)
        {
            dgvTabla.Visible = true;
            dgvTabla.Rows.Add(personaBuscada.Identificacion, personaBuscada.Nombre, personaBuscada.Edad, personaBuscada.Sexo, personaBuscada.Pulsacion, personaBuscada.FechaNacimiento.Year);
        }


    }
}
