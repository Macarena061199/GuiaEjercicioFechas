using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicioFechas
{
    internal class E29
    {
        /* Solicite el ingreso de una fecha al usuario y presente la fecha correspondiente al 
         * primero de mes inmediato anterior.*/
        public void Ej29()
        {
            bool flag = false;

            do
            {
                Console.Write("Por favor ingrese una fecha: ");
                string fecha = Console.ReadLine();

                DateTime salida = DateTime.Now;
                flag = ValidarFecha(fecha, ref salida);

                if (flag == true)
                {
                    Console.WriteLine($"La fecha del mes anterior es: {salida.AddMonths(-1).ToShortDateString()}.");
                }

            } while (flag == false);

        }

        private bool ValidarFecha(string ingreso, ref DateTime salida)
        {
            bool validar = false;
            if (!DateTime.TryParse(ingreso, out salida))
            {
                Console.WriteLine("El valor ingresado debe ser una fecha. ");
            }
            else
            {

                validar = true;
            }
            return validar;
        }
    }
}
