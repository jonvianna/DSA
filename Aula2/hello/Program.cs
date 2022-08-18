﻿using System;

namespace hello
{
    class Program
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

            Console.WriteLine("Quantos números?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            double[] numeros = new double[quantidade];
            Console.WriteLine("Digite os números:");
            for(int i = 0; i < quantidade; i++)
            {
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            calculaMedia(numeros);

        }
    }
}
