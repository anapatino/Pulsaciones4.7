using System;
using System.Collections.Generic;
using Entidad;
using System.IO;
using System.Linq;
using System.Data.Common;
using System.Data.SqlClient;

namespace Datos
{
    public class PersonaRepository
    {
        public string ruta = "ListaPersonas.txt";
        DbConnection _connection;
        public PersonaRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public void Guardar(Persona persona)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into persona (identificacion,nombre,edad,sexo,pulsacion,fecha)" +
                    " values (@identificacion,@nombre,@edad,@sexo,@pulsacion,@fecha)";
                command.Parameters.Add(new SqlParameter("@identificacion", persona.Identificacion));
                command.Parameters.Add(new SqlParameter("@nombre",persona.Nombre));
                command.Parameters.Add(new SqlParameter("@edad", persona.Edad));
                command.Parameters.Add(new SqlParameter("@sexo", persona.Sexo));
                command.Parameters.Add(new SqlParameter("@pulsacion",persona.Pulsacion));
                command.Parameters.Add(new SqlParameter("@fecha",persona.FechaNacimiento));
                int fila = command.ExecuteNonQuery();
            }
        }

        public List<Persona> Consultar()
        {
            List<Persona> personas = new List<Persona>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT *FROM persona;";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Persona persona = new Persona();
                        persona.Identificacion = reader.GetString(0);
                        persona.Nombre = reader.GetString(1);
                        persona.Edad = reader.GetInt32(2);
                        persona.Sexo = reader.GetString(3);
                        persona.Pulsacion = reader.GetDecimal(4);
                        persona.FechaNacimiento = reader.GetDateTime(5);
                        personas.Add(persona);
                    }
                    reader.Close();
                }
            }
            return personas;
        }

        public void Modificar(string identificacion, Persona personaNuevo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update persona set nombre=@nombre, edad=@edad,sexo=@sexo, pulsacion=@pulsacion fecha=@fecha where identificacion=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                command.Parameters.Add(new SqlParameter("@nombre", personaNuevo.Nombre));
                command.Parameters.Add(new SqlParameter("@edad", personaNuevo.Edad));
                command.Parameters.Add(new SqlParameter("@sexo", personaNuevo.Sexo));
                command.Parameters.Add(new SqlParameter("@pulsacion", personaNuevo.Pulsacion));
                command.Parameters.Add(new SqlParameter("@fecha", personaNuevo.FechaNacimiento));
                int fila = command.ExecuteNonQuery();
            }
        }

        public void Eliminar(string identificacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "delete From persona where identificacion=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                int fila = command.ExecuteNonQuery();
            }
        }

        public List<Persona> FiltrarPorSexoVersionLarga(string sexo)
        {
            List<Persona> personasFiltrada = new List<Persona>();
            foreach (var item in Consultar())
            {
                if (item.Sexo.Equals(sexo))
                {
                    personasFiltrada.Add(item);
                }
            }
            return personasFiltrada;
        }

        public List<Persona> FiltrarPorSexoConsulta(string sexo)
        {
            return (from p in Consultar()
                    where p.Sexo.Equals(sexo)
                    orderby p.Nombre ascending
                    select p).ToList();
        }

        public List<Persona> FiltrarPorSexoMetodo(string sexo)
        {
            return Consultar().Where(p => p.Sexo.Equals(sexo)).ToList();
        }

        public Persona Buscar(string identificacion)
        {
            return (Persona) Consultar().FirstOrDefault(p => p.Identificacion.Equals(identificacion));
        }


        public int ContarPorSexorMetodo(string sexo)
        {
            return Consultar().Count(p => p.Sexo.Equals(sexo));
            // Otra forma
            // return Consultar().Where(p => p.Sexo.Equals(sexo)).Count();
        }

        public double PromediarPorEdadMetodo()
        {
            return Consultar().Average(p => p.Edad);
        }

        public decimal SumarPorPulsacionesMetodo()
        {
            return Consultar().Sum(p => p.Pulsacion);
        }

        public List<Persona> FiltrarPorAnio(int year)
        {
            return Consultar().Where(p => p.FechaNacimiento.Year == year).ToList();
        }

        public List<Persona> FiltrarPorPalabraConsulta(string palabra)
        {
            return (from p in Consultar()
                    where p.Nombre.ToLower().Contains(palabra.ToLower())
                    select p).ToList();
        }
    }
}
