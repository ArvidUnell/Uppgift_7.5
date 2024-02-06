using System;
namespace Uppgift_7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in dina senaste månadslöner. Skriv in 0 för att avsluta");

            List<int> löner = new List<int>();
            
            while (true)
            {
                int lön = ReadInt();
                if (lön == 0)
                {
                    break;
                }
                else
                {
                    löner.Add(lön);
                }
            }

            Console.WriteLine($"Medelvärdet av dina månadslöner är {Math.Round(Medelvärde(löner),2)}. Medianen är {Median(löner)}.");
        }
        /// <summary>
        /// Läser in ett int-tal från användaren
        /// </summary>
        /// <returns>Talet användaren skrev</returns>
        static int ReadInt()
        {
            int tal;
            while (!int.TryParse(Console.ReadLine(), out tal))
            {
                Console.WriteLine("Ogiltigt svar. Försök igen");
            }
            return tal;
        }
        /// <summary>
        /// Beräknar medelvärde av en lista
        /// </summary>
        /// <param name="värden">Listan av värden att beräkna medelvärdet av</param>
        /// <returns>Medelvärdet</returns>
        static double Medelvärde(List<int> värden)
        {
            int summa = 0;
            foreach (int värde in värden )
            {
                summa += värde;
            }

            return (double)summa/värden.Count;
        }
        /// <summary>
        /// Beräknar medianen av en lista
        /// </summary>
        /// <param name="värden">Lista med värden som metoden räknar medianen på</param>
        /// <returns>Medianen av arrayen</returns>
        static double Median(List<int> värden)
        {
            värden.Sort();
            if (värden.Count%2 == 1) //om det är ett ojämnt antal värden
            {
                return värden[värden.Count/2];
            }
            else //Jämnt antal värden.
            {
                return (värden[värden.Count / 2] + värden[(värden.Count / 2) -1 ]) / 2;
            }
        }
    }
}