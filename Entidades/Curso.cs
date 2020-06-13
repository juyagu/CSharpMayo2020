using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        public int Id_Curso { get; }
        public Instructor Instructor { get; set; } 

        Materia Materia { get; set; }

        public Aula Aula { get; set; }

        public Curso(int id, Instructor ins, Aula a, Materia m)
        {
            Id_Curso = id;
            Instructor = ins;
            Aula = a;
            Materia = m;
        }
        public Curso(Instructor ins, Aula a, Materia m)
        {
            Instructor = ins;
            Aula = a;
            Materia = m;
        }

    }
}
