using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protectora
{
    public class Perro
    {
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public string Raza { get; set; }
        public double Tamaño { get; set; }
        public int Edad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public bool Cachorro { get; set; }
        public bool Ppp { get; set; }
        public bool Vacunado { get; set; }
        public bool Esterilizado { get; set; }
        public string Padrino { get; set; }
        public Uri Foto { get; set; }

        public Perro(string nombre, string sexo, string raza, double tamaño, int edad, DateTime fechaEntrada, bool cachorro, bool ppp, bool vacunado, bool esterilizado, string padrino, Uri foto)
        {
            Nombre = nombre;
            Sexo = sexo;
            Raza = raza;
            Tamaño = tamaño;
            Edad = edad;
            FechaEntrada = fechaEntrada;
            Cachorro = cachorro;
            Ppp = ppp;
            Vacunado = vacunado;
            Esterilizado = esterilizado;
            Padrino = padrino;
            Foto = foto;
        }
    }
}
