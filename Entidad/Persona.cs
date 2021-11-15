﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {
        public Persona()
        {

        }
        public Persona(string identificacion, string nombre, string sexo, int edad)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
        }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public decimal Pulsacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public void CalcularPulsacion()
        {
            if (Sexo.ToUpper().Equals("M"))
            {
                Pulsacion = (210 - Edad) / 10;
            }
            else if (Sexo.ToUpper().Equals("F"))
            {
                Pulsacion = (220 - Edad) / 10;
            }
            else
            {
                Pulsacion = 0;
            }
        }

        public string Escribir()
        {
            return $"{Identificacion};{Nombre};{Sexo};{Edad};{Pulsacion};{FechaNacimiento}";
        }

        public override string ToString()
        {
            return $"Identificacion: {Identificacion} Nombre: {Nombre} Edad:{Edad} Sexo:{Sexo} Pulsación:{Pulsacion} FN: {FechaNacimiento}"; 
        }
    }
}
