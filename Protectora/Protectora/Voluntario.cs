using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectora
{
    class Voluntario
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public int Edad { get; set; }
        public long Telefono { get; set; }
        public string Horario { get; set; }
        public bool ConocimientosVeterinarios { get; set; }
        public bool Festivos { get; set; }
        public Uri Image { get; set; }

        public Voluntario(string nombre, string apellidos, string dni, int edad, long telefono, string horario, bool conocimientosVeterinarios, bool festivos, Uri image)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
            Edad = edad;
            Telefono = telefono;
            Horario = horario;
            ConocimientosVeterinarios = conocimientosVeterinarios;
            Festivos = festivos;
            Image = image;
        }
    }
}
