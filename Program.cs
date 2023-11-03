using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2_3.EJERCICIO_3;

namespace T2_3
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int opcion = MenuConsola.MenuPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = MenuConsola.MenuPrincipal();
                        break;
                    case 1:
                        opcion = MenuConsola.sumar();
                        break;
                    case 2:
                        opcion = MenuConsola.restar();
                        break;
                    case 3:
                        opcion = MenuConsola.multiplicar();
                        break;
                    case 4:
                        opcion = MenuConsola.dividir();
                        break;
                }
            } while (opcion != 5);
        }
    }
}