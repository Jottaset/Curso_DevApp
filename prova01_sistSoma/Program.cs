using System;

namespace prova01_sistSoma
{
    class Program
    {

        static void Main(string[] args)
        {
              int num1;
              int num2;
              int num3;

            Console.WriteLine("Informe o Numero:");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Numero:");
            num2 = Int32.Parse(Console.ReadLine());

            num3 = num1 + num2;
            Console.WriteLine("Resultado: " + num3);


        }
    }
}

        //public int Calculo(int num1, int num2)
        //{
        //    Console.WriteLine("Informe o Numero:");
        //    num1 = Int32.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o Numero:");
        //    num2 = Int32.Parse(Console.ReadLine());
            
        //    num3 = num1 + num2;
        //    Console.WriteLine("Resultado:" + num3);
        //}
   