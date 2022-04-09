using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicioFechas
{
    internal class E23
    {

        /* Solicite el ingreso de una fecha al usuario y determine si es un ingreso válido*/
        public void Ej23()
        {
            bool flag = false;
            do
            {
                Console.Write("Por favor ingrese una fecha: ");
                string fecha = Console.ReadLine();

                DateTime salida = DateTime.Now;
                flag = ValidarFecha(fecha, ref salida);

                if (flag==true)
                {
                    Console.WriteLine($"La fecha ingresada fue {salida.ToShortDateString()}. ");
                }
            } while (flag == false);


        }

        private bool ValidarFecha (string ingreso, ref DateTime salida)
        {
            bool validar = false;
            if(!DateTime.TryParse(ingreso, out salida))
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
