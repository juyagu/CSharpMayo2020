using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Instructor : Persona
    {
        public int Id_Instructor { get; }
        public int Id_Usuario { get; }
        
        public Instructor(int id,string nombre, string apellido): base(nombre, apellido)
        {
            Id_Instructor = id;            
        }
        public Instructor(int id, int id_usuario, string nombre, string apellido) : base(nombre, apellido)
        {
            Id_Instructor = id;
            Id_Usuario = id_usuario;
        }
    }
}
