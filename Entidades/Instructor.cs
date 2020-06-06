using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Instructor : Persona
    {
        public List<Materia> Materias { get; set; }

        public Instructor() { }

        public Instructor(string nombre, string apellido, List<Materia> mat): base(nombre, apellido)
        {
            Materias = mat;
        }
    }
}
