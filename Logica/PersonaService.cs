using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class PersonaService
    {
        PersonaRepository personaRepository;
        ConnectionManager connectionManager;

        public PersonaService(string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            personaRepository = new PersonaRepository(connectionManager.Connection);
        }

        public string Guarda(Persona persona)
        {
            try
            {
                connectionManager.Open();
                if (personaRepository.Buscar(persona.Identificacion) == null)
                {
                    personaRepository.Guardar(persona);
                    return "Se ha Guardado los Datos Correctamente";
                }
                return $"No fue posible Guardar la información, porque ya existe un registro con la identificaion  {persona.Identificacion}";
            }
            catch (Exception e)
            {
                return "Error al Guardar :" + e.Message;
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public PersonaConsultaResponse Consultar()
        {
            try
            {
                connectionManager.Open();
                return new PersonaConsultaResponse(personaRepository.Consultar());
            }
            catch (Exception e)
            {
                return new PersonaConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public (string mensaje, Persona persona) Eliminar(string identificacion)
        {
            try
            {
                connectionManager.Open();
                var persona = personaRepository.Buscar(identificacion);
                if (persona != null)
                {
                    personaRepository.Eliminar(identificacion);
                    return ($"Se Eliminó el registro de la persona con identificacion {identificacion}", persona);
                }
                return ($"No fue posible eliminar el registro, porque no existe la persona con la identificacion {identificacion}", persona);
            }
            catch (Exception e)
            {
                return ($"Error inesperado al Eliminar: {e.Message}", null);
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public (string mensaje, Persona persona) Buscar(string identificacion)
        {
            try
            {
                connectionManager.Open();
                var persona = personaRepository.Buscar(identificacion);
                if (persona == null)
                {
                    return ("No se encontró un registro con la identificacion Solicitada", persona);
                }
                return ($" Se encuentra Registrado {identificacion}", persona);
            }
            catch (Exception e)
            {
                return ($"Error inesperado al Buscar: {e.Message}", null);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string Modificiar(string identificacion, Persona personaNew)
        {
            try
            {
                connectionManager.Open();
                if (personaRepository.Buscar(identificacion) == null)
                {
                    return $"No es posible realizar la Modificación, la persona con Identificacion {identificacion} no existe";
                }
                if (personaRepository.Buscar(personaNew.Identificacion) != null)
                {
                    return $"No es posible realizar la Modificación, La Nueva Identificación {personaNew.Identificacion} ya se encuentra asignada a otra persona";
                }
                personaRepository.Modificar(identificacion, personaNew);
                return "Se realizó la Modificación Satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Modificar: {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public PersonaConsultaResponse ConsultarPorSexo(string sexo)
        {
            try
            {
                connectionManager.Open();
                return new PersonaConsultaResponse(personaRepository.FiltrarPorSexoConsulta(sexo));
            }
            catch (Exception e)
            {
                return new PersonaConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public PersonaConsultaResponse ConsultarPorPalabra(string palabra)
        {
            try
            {
                connectionManager.Open();
                return new PersonaConsultaResponse(personaRepository.FiltrarPorPalabraConsulta(palabra));
            }
            catch (Exception e)
            {
                return new PersonaConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public PersonaConsultaResponse ConsultarPorAnio(int year)
        {
            try
            {
                connectionManager.Open();
                return new PersonaConsultaResponse(personaRepository.FiltrarPorAnio(year));
            }
            catch (Exception e)
            {
                return new PersonaConsultaResponse("Se presento el siguiente: " + e.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
    }
}
