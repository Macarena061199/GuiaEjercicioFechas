using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GuiaEjercicioFechas
{
    internal class E30
    {
        /* Solicite el ingreso de una fecha al usuario y muestre sólo la hora.*/
        public void Ej30()
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
                    
                    Console.WriteLine($"La hora ingresada fue: {salida.ToShortTimeString()}.");
                }

            } while (flag == false);

        }

        private bool ValidarFecha(string ingreso, ref DateTime salida)
        {
            bool validar = false;
            var dateTimeFormat = CultureInfo.InvariantCulture.DateTimeFormat;

            if (!DateTime.TryParseExact(ingreso, "dd/MM/yyyy/HH/mm", dateTimeFormat, DateTimeStyles.None, out salida))
            {
                Console.WriteLine("La fecha ingresada debe tener el siguiente formato: 'dd/MM/yyyy/HH/mm'. ");
            }
            else
            {
                validar = true;
            }
            return validar;
        }
    }
}
