using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicioFechas
{
    internal class E25
    {
        /* Le solicite al usuario el ingreso de tres números y determine si conforman una fecha 
         * válida interpretados como día / mes / año.*/
        public void Ej25()
        {
            bool flag = false;
            string guardar = "";
            do
            {
                
                Console.Write("Por favor ingrese un número:  ");
                string ingresoA = Console.ReadLine();

                flag = ValidadNumero(ingresoA);

                if(flag ==true)
                {
                    guardar=ingresoA +"-";
                }

            } while (flag == false);

            

            do
            {

                Console.Write("Por favor ingrese otro número:  ");
                string ingresoB = Console.ReadLine();

                flag = ValidadNumero(ingresoB);

                guardar = guardar + ingresoB + "-";

            } while (flag == false);

            

            do
            {
                Console.Write("Por favor ingrese un número nuevamente:  ");
                string ingresoC = Console.ReadLine();

                flag = ValidadNumero(ingresoC);

                guardar = guardar + ingresoC;

            } while (flag == false);

          

            flag = ValidarFecha(guardar);

            if(flag ==true)
            {
                Console.Write($"Los números ingresados conforman la siguiente fecha válida: {guardar}");
            }
            
        }

        private bool ValidadNumero(string ingreso)
        {
            bool flag=false;
            if(!int.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("El valor ingresado debe ser un dato numérico.");
            }
            else if(salida<0)
            {
                Console.WriteLine("El valor ingresado no debe ser un número negativo.");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private bool ValidarFecha(string ingreso)
        {
            bool validar = false;
            if (!DateTime.TryParse(ingreso, out DateTime salida))
            {
                Console.Write($"Los números ingresados no conforman una fecha válida");
            }
            else
            {

                validar = true;
            }
            return validar;
        }
    }
}
