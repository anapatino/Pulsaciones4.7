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
    public partial class FrmConsultar : Form
    {
        PersonaService personaService;
        public FrmConsultar()
        {
            InitializeComponent();
            personaService = new PersonaService(ConfigConnectionString.ConnectionString);
        }

        private void bnVisualizar_Click(object sender, EventArgs e)
        {
            VisualizarTabla();
        }

        public void VisualizarTabla()
        {
            var respuesta = personaService.Consultar();
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                foreach (var item in respuesta.Personas)
                {
                    dgvTabla.Rows.Add(item.Identificacion, item.Nombre, item.Edad, item.Sexo, item.Pulsacion, item.FechaNacimiento.Year);
                }
            }
        }
    }
}
