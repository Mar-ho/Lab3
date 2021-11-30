using System;
using System.Collections.Generic;


namespace MarcinHoffmannLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> zgadywaneSlowo = new List<char>();               // lista liter tworząca zgadywane słowo
            List<char> podaneLitery = new List<char>();                 // lista liter wpisanych przez odgadującego
            int iloscLiter = 0;                                         // ilość liter zgadywanego słowa
            int iloscProb = 2;                                          // maksymalna ilość prób będzie = ilości liter zgadywanego słowa + 2
            int odgadniete = 0;                                         // ilość odgadniętych liter w słowie

            Console.WriteLine("Podaj wyraz do odgadnięcia dla gracza.");
            string wyraz = (Console.ReadLine());
            foreach (char litera in wyraz)
            {
                zgadywaneSlowo.Add(litera);
                iloscLiter ++;
            }
            
            iloscProb += iloscLiter;

            Console.Clear();
            Console.WriteLine($"Maksymalna ilość prób: {iloscProb}"); 

            for (int i=1; i <= iloscProb; i++ )
            {
                Console.WriteLine($"\nPróba {i}. Podaj literę.");
                char podanaLitera = Char.Parse(Console.ReadLine());
                podaneLitery.Add(podanaLitera);
                odgadniete = 0;

                foreach (char litera in zgadywaneSlowo)
                {
                    if (podaneLitery.Contains(litera))
                    {
                        Console.Write(litera);
                        odgadniete++;
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");

                if (odgadniete == iloscLiter)
                {
                    break;
                }
                    
            }

            if (odgadniete == iloscLiter)
            {
                Console.WriteLine("\nBrawo, zgadłeś !!!");
            }
            else
            {
                Console.WriteLine("\nOstatnia szansa. Podaj zgadywany wyraz.");
                string zgadywany = (Console.ReadLine());

                if (zgadywany == wyraz)
                {
                    Console.WriteLine("\nBrawo, zgadłeś !!!");
                }
                else
                {
                    Console.WriteLine("\nNiestety, wisisz :( ");
                    Console.WriteLine($"Poprawna odpowiedź to: {wyraz}");
                }

            }

            Console.ReadKey();
        }
    }
}
