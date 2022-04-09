using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicioFechas
{
    internal class E28
    {
        /* Solicite el ingreso de un número al usuario y determine si corresponde a un año bisiesto.*/
        public void Ej28()
        {
            bool flag = false;

            do
            {
                Console.Write("Por favor ingrese un número de cuatro dígitos:  ");
                string ingreso = Console.ReadLine();

                flag = ValidarDigitos(ingreso);

                if(flag ==true)
                {
                    int salida = 0;
                    flag = ValidadNumero(ingreso, ref salida);

                    if (flag == true)
                    {
                        bool añoBisiesto = DateTime.IsLeapYear(salida);
                        if (añoBisiesto == true)
                        {
                            Console.WriteLine($"El año ingresado {salida} fue, es o será año bisiesto.");
                        }
                        else
                        {
                            Console.WriteLine($"El año ingresado {salida} no fue, es o será año bisiesto.");
                        }

                    }
                }
                
                
            } while (flag==false);
        }
        private bool ValidarDigitos(string ingreso)
        {
            bool flag = false;
            int log = ingreso.Length;

            if (log!=4)
            {
                Console.WriteLine("El valor ingresado debe contener 4 dígitos.");
            }
            else
            {
                flag = true;
            }
            return flag;
        }


        private bool ValidadNumero(string ingreso, ref int salida)
        {
            bool flag = false;
            if (!int.TryParse(ingreso, out salida))
            {
                Console.WriteLine("El valor ingresado debe ser un dato numérico.");
            }
            else if (salida<0)
            {
                Console.WriteLine("El valor ingresado no debe ser un número negativo.");
            }
            else
            {
                flag = true;
            }
             return flag;
        }

       
    }
}
