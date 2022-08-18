using System;

namespace hello
{
    class Program1
    {
        // vai receber um array de double e imprimir no console a mmm (moda media e mediana)
        static void calculaMedia (double[] numeros){

            double media = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                media += numeros[i];
            }
            media /= numeros.Length;
            Console.WriteLine("A média dos números é: " + media);
            }
            
        static void Main(string[] args){
            double[] numeros = {123, 4234, 6345, 243};
            calculaMedia(numeros);

        }
    }
}
