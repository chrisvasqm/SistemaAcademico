using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Menu
    {
        public void UserMenu()
        {
            Operations ObjOperations = new Operations();

            int o;
            double a, b;

            Console.WriteLine("Elige una opcion: \n 1)Sumar \n 2)Restar \n 3)Multiplicar \n 4)Dividir");
            o = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Inserte primer numero:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserte segundo numero:");
            b = Convert.ToDouble(Console.ReadLine());

            switch (o)
            {
                case 1:
                    Console.WriteLine(ObjOperations.SumValues(a, b));
                    break;
                case 2:
                    Console.WriteLine(ObjOperations.ResValues(a, b));
                    break;
                case 3:
                    Console.WriteLine(ObjOperations.MulValues(a, b));
                    break;
                case 4:
                    Console.WriteLine(ObjOperations.DivValues(a, b));
                    break;
                default:
                    Console.WriteLine("Por favor introduca datos validos");
                    break;
            }
        }
    }
}
    