using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        public int Id_Materia { get; set; }
        public string Nombre { get; set; }
        public string Programa { get; set; }

        public Materia(int id, string n, string p)
        {
            Id_Materia = id;
            Nombre = n;
            Programa = p;
        }
        public Materia(int id, string n)
        {
            Id_Materia = id;
            Nombre = n;
        }
        public Materia(string n, string p)
        {
            Nombre = n;
            Programa = p;
        }
        public Materia() { }
    }
}
