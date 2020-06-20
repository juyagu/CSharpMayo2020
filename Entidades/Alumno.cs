using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        public int Id_Alumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Materia { get; set; }

       // public int Regular { get; set; }


        public Alumno() { }

        /*public Alumno(int id, string n, string a, string m)
        {
            Id_Alumno = id;
            Nombre = n;
            Apellido = a;
            Materia = m;
        }*/

    }
}
