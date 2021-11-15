using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Pulsaciones_prueba;Integrated Security=True";
            DbConnection connection = new SqlConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT *FROM persona;";
            DbDataReader reader = command.ExecuteReader();
            List<Persona> personas = new List<Persona>();

            while (reader.Read())
            {
                Persona persona = new Persona();
                persona.Identificacion = reader.GetString(0);
                persona.Nombre = reader.GetString(1);
                persona.Edad = reader.GetInt32(2);
                persona.Sexo = reader.GetString(3);
                persona.Pulsacion = reader.GetDecimal(4);
                personas.Add(persona);
            }
            reader.Close();

            foreach (var item in personas)
            {
                Console.WriteLine($"{ item.Identificacion};{item.Nombre};{item.Edad};{item.Sexo};{item.Pulsacion}");
            }

            Console.WriteLine(connection.State);
            connection.Close();
            Console.ReadKey();

        }
    }
}
