using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GuiaEjercicioFechas
{
    internal class E24
    {

        /* Solicite el ingreso de una fecha al usuario utilizando, estrictamente, el formato dd/MM/yyyy*/
        public void Ej24()
        {
            bool flag = false;
            do
            {
                Console.Write("Por favor ingrese una fecha con el formato 'dd/MM/yyyy':  ");
                string fecha = Console.ReadLine();
                DateTime salida = DateTime.Now;

                flag = ValidarFecha(fecha, ref salida);

                if(flag==true)
                {
                    Console.WriteLine($"La fecha ingresada fue: {salida.ToShortDateString()} ");
                }

            } while (flag == false);
        }

        private bool ValidarFecha(string ingreso, ref DateTime salida)
        {
            bool validar = false;
            var dateTimeFormat = CultureInfo.InvariantCulture.DateTimeFormat;
           
            if (!DateTime.TryParseExact(ingreso, "dd/MM/yyyy", dateTimeFormat, DateTimeStyles.None, out salida))
            {
                Console.WriteLine("La fecha ingresada debe tener el siguiente formato: 'dd/MM/yyyy'. ");
            }
            else
            {
                validar = true;
            }
            return validar;
        }
    }
}
