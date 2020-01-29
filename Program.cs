using System;
using System.Collections.Generic;

namespace Ruleta
{
    class Program
    {
        static void Main(string[] args)
        {
            var ruleta = new Ruleta();
            int numero = 0, numWin, winners, losers;
            while (numero >= 0 && numero <= 36)
            {
                Console.Write("Ingresar el numero al que desea apostar: ");
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0 && numero <= 36)
                {
                    ruleta.addBets(numero);
                }
            }
            numWin = ruleta.getNumberWin();
            winners = ruleta.getResults(numWin);
            losers = ruleta.getAllBets().Count - winners;
            Console.WriteLine("El numero ganador es el " + numWin.ToString());
            Console.WriteLine("La cantidad de ganadores es de: " + ruleta.getResults(numWin).ToString());
            Console.WriteLine("La cantidad de perdedores es de: " + losers.ToString());

            Console.ReadKey();
        }
    }
}
