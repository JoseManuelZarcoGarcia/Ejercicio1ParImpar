using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1ParImpar.Servicios
{
    internal class PreguntaImplementacion : PreguntaInterfaz
    {
        /// <summary>
        /// metodo que preguntara un numero
        /// jzg - 241023
        /// </summary>
        /// <returns></returns>
        public int pedirNumero()
        {
            int pedirNumero;

            Console.WriteLine("Escriba un numero entero. ");
            pedirNumero = Convert.ToInt32(Console.ReadLine());
            
            return pedirNumero;
        }


    }
}
