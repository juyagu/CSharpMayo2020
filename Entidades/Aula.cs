using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        public int Codigo_Aula { get; }
        public int Capacidad { get; }

        public string Nombre_Aula { get; }

        public Aula(int codigo, int cap)
        {
            Codigo_Aula = codigo;
            Nombre_Aula = "Aula número "  + codigo;
            Capacidad = cap;
        }
    }
}
