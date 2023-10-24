using Ejercicio1ParImpar.Servicios;

namespace Ejercicio1ParImpar.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            int numeroPedido;
            bool esPar;
            PreguntaInterfaz pi = new PreguntaImplementacion();

            numeroPedido = pi.pedirNumero();
            esPar = numeroPedido % 2 == 0;
            if (esPar)

                Console.WriteLine("Es un nuemro par ");

            else
                Console.WriteLine("Es un nuemro impar ");
            

        }

    }

}
