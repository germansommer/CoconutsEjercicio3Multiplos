using System;

namespace CocoMultiplos03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables.
            int i = 0, numM = 0, cuenta = 0;
            //Ingreso y control del numero.
            Console.WriteLine("Ingrese un numero: ");
            do
            {
                try
                {
                    numM = int.Parse(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (numM < 1);            
            Console.WriteLine("**************");
            Console.WriteLine("Imprimiendo los primeros " + numM + " multiplos de 3 (sin multiplos de 5)");
            Console.WriteLine("**************");
            //Loop de Suma e impresion.
            while (i < numM)
            {
                //Control de multiplos.
                if (((cuenta + 3)%5) !=0)
                {
                    cuenta += 3;
                    Console.WriteLine(cuenta);
                    i++;
                }
                else
                {
                    cuenta += 3;
                }
            }
        }
    }
}
