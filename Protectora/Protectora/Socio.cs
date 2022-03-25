using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectora
{
    class Socio
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public int Edad { get; set; }
        public long Telefono { get; set; }
        public string CuentaBancaria { get; set; }
        public int Cuantia { get; set; }
        public Uri Image { get; set; }

        public Socio(string nombre, string apellidos, string dni, int edad, long telefono, string cuentaBancaria, int cuantia, Uri image)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
            Edad = edad;
            Telefono = telefono;
            CuentaBancaria = cuentaBancaria;
            Cuantia = cuantia;
            Image = image;
        }
    }
}
