using System;

namespace Aula25Recursividade
{
    public class Recursividade
    {
        public void GerarSequenciaFibonacci(int num1, int num2, int vezes){
            //Condição crucial para que a recursividade tenha fim
            if(vezes >= 0){
                Console.WriteLine(num1);
                GerarSequenciaFibonacci(num2, num1 + num2, vezes - 1);
            }


        }

        public int GerarFatorial(int numero){
            if(numero == 1){
                return 1;
            }
            else{
                return numero * GerarFatorial(numero - 1);
            }

        }
    }
}