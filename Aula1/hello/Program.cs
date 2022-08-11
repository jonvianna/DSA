using System;

namespace hello
{
    class Program
    {
        static double CalculoArea(double largura, double altura){
            return largura * altura;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite uma largura:");
           double largura = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Digite uma altura:");
           double altura = Convert.ToDouble(Console.ReadLine());
           
            double area = CalculoArea(largura, altura);
            Console.Write("A area é: ");
            Console.WriteLine(area);
            }
            catch (Exception excecao)
            {
                Console.WriteLine(excecao.Message);
            }
            
       }
    }
}
