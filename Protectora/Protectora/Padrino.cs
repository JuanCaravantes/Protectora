using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectora
{
    public class Padrino
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public int Aportacion { get; set; }
        public string NumeroCuenta { get; set; }

        public Padrino(string dni, string nombre, string apellidos, int edad, long telefono, string email, int aportacion, string numeroCuenta)
        {
            Dni = dni;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Telefono = telefono;
            Email = email;
            Aportacion = aportacion;
            NumeroCuenta = numeroCuenta;
        }
    }
}
