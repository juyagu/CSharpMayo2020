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
        
        public Instructor(int id,string nombre, string apellido): base(nombre, apellido)
        {
            Id_Instructor = id;            
        }
    }
}
