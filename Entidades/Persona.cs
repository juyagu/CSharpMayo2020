using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona() { }

        public Persona(string n, string a)
        {
            Nombre = n;
            Apellido = a;
        }
    }
}
