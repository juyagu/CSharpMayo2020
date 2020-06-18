using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Errores
    {
        public static void Generar()
        {
            Random objRandom = new Random();
            switch(objRandom.Next(4))
            {
                case 0:
                    int[] vector = new int[9];
                    for(int i = 0; i < 10; i++)
                    {
                        vector[i] = i;
                    }
                    break;
                case 1:
                    DateTime fecha = Convert.ToDateTime("Fecha invalida");
                    break;
                case 2:
                    int a = 0;
                    int b = 0;
                    a = a / b;
                    break;
                case 3:
                    byte variable = 0;
                    variable = Convert.ToByte(300);
                    break;
                default:
                    throw new Exception("Fuera de rango");
            }
        }
    }
}
