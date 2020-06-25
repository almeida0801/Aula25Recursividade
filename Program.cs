using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
           Recursividade rec = new Recursividade();
           System.Console.WriteLine("Gerando sequência Fibonacci");
            rec.GerarSequenciaFibonacci(0,1,20);

            System.Console.WriteLine("");
            System.Console.WriteLine("Gerando fatorial do número 5");
            System.Console.WriteLine(rec.GerarFatorial(5));

        }
    }
}
