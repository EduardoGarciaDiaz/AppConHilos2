namespace AppConHilos2;

using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //Cree un hilo secundario pasando un delegado ThreadStart
        Thread workerThread = new Thread(new ThreadStart(Print));

        //Iniciar hilo secundario
        workerThread.Start();

        //Hilo principal: Imprime de 1 a 10 cada 0.2 segundos
        //El metodo Thread.Sleep es responsable de hacer que el hilo actual entre en suspensión
        //en milisegundos. Mientras duerme, un hilo no hace nada
        for (int i = 0 ; i < 10 ; i++)
        {
            Console.WriteLine($"Principal thread: {i}");
            Thread.Sleep(200);
        }

        //Este codigo es ejecutado por un hilo secundario
        static void Print() 
        {
            for (int i = 11 ; i < 20; i++) 
            {
                Console.WriteLine($"Print thread: {i} ");
                Thread.Sleep(1000);
            }
        }

    }
}
