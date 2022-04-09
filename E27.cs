using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicioFechas
{
    internal class E27
    {
        /* 27.	Solicite el ingreso de una fecha al usuario y presente las fechas 30, 60, 90 y 180 días 
         * posteriores a la ingresada.*/
        public void Ej27()
        {
            bool flag = false;
            
            do
            {
                Console.Write("Por favor ingrese una fecha: ");
                string fecha = Console.ReadLine();

                DateTime salida = DateTime.Now;
                flag = ValidarFecha(fecha, ref salida);

                if(flag==true)
                {
                    Console.WriteLine($"según la fecha ingresada {fecha}: " + System.Environment.NewLine +
                        $"Dentro de 30 días será: {salida.AddDays(30).ToShortDateString()}."+
                        System.Environment.NewLine+ $"Dentro de 60 días será: {salida.AddDays(60).ToShortDateString()}." +
                        System.Environment.NewLine + $"Dentro de 90 días será: {salida.AddDays(90).ToShortDateString()}." +
                        System.Environment.NewLine + $"Dentro de 180 días será: {salida.AddDays(180).ToShortDateString()}.");
                }


            } while(flag==false);
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
