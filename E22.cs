using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicioFechas
{
    internal class E22
    {
        /* Presente al usuario la fecha actual con el siguiente formato: dd/MM/yyyy*/
        public void Ej22()
        {
            DateTime hoy = DateTime.Now;
            Console.WriteLine($"Buenos días, hoy es: {hoy.ToShortDateString()}.");
        }
    }
}
