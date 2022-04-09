using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicioFechas
{
    internal class E26
    {
        /* Solicite el ingreso de una fecha al usuario y le presente: el día, el año,
         * el número y nombre del mes y el nombre y número del día de la semana.*/
        public void Ej26()
        {
            bool flag = false;
           
            do
            {
                Console.Write("Por favor ingrese una fecha: ");
                string fecha = Console.ReadLine();

                DateTime salida = DateTime.Now;
                flag = ValidarFecha(fecha);

                if (flag == true)
                {
                    int dia = salida.Day;
                    int año = salida.Year;
                    int numMes= salida.Month;
                    DayOfWeek numSemana = salida.DayOfWeek;

                    string mes = NombreMes(numMes);

                    Console.WriteLine($"El día ingresado fue: {dia}." + System.Environment.NewLine +
                       $"El año ingresado fue: {año}." + System.Environment.NewLine + $"El número del mes " +
                       $"ingresado fue: {numMes} y el nombre del mes es: {mes}." + System.Environment.NewLine+
                       $"El día de la semana ingresado fue: {numSemana}.");

                }

            } while (flag == false);
        }

        private bool ValidarFecha(string ingreso)
        {
            bool validar = false;
            if (!DateTime.TryParse(ingreso, out DateTime salida))
            {
                Console.WriteLine("El valor ingresado debe ser una fecha. ");
            }
            else
            {

                validar = true;
            }
            return validar;
        }

        private string NombreMes (int numMes)
        {
            int fila;
            string mes="";

            string[] meses = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo",
                        "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            for (fila = 0; fila < meses.GetLength(0); fila++)
            {
                if(fila == (numMes-1))
                {
                    mes = meses[fila];
                }
            }

             return mes;
        }
    }
}
