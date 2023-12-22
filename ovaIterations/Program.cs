using System.Collections.Generic;
using System;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization.Formatters;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualBasic;

namespace ovaIterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Övning 5: Skriv en konsolapplikation för att ange siffror och bestämma summan av siffror från 1
            //till av det angivna numret och numrets fakultet.
            //Console.WriteLine("Detta är ett omvandlingsprogram");
            //string val = "";
            //int n, sum = 0;
            //int fact = 1;

            //Console.WriteLine("Ange numret som tillägget görs till");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++) 
            //{
            //    sum += i;
            //    fact *= i;
            //}

            //Console.WriteLine($"Summan av talen från 1 till {n} är {sum}");
            //Console.WriteLine("Fakultet är " + fact);


            //Övning 6: Menyprogram med while: Skapa ett menyprogram som innehåller följande alternativ:
            //Välj ett av följande alternativ.
            //1.Omvandla meter till kilometer
            //2.Omvandla kilometer till meter
            //3.Avsluta programmet
            //while (val != "3")
            //{

            //    Console.WriteLine("Välj ett av föjande alternativ");
            //    Console.WriteLine("1. Omvandla meter till kilometer");
            //    Console.WriteLine("2. Omvandla kilometer till meter");
            //    Console.WriteLine("3. Avsluta programmet");

            //    val = Console.ReadLine();

            //    switch (val)
            //    {
            //        case "1":
            //            Console.WriteLine("Skriv in en längd i meter");
            //            double antalMeter = double.Parse(Console.ReadLine());
            //            Console.WriteLine($"Längden du skrev in är detsamma som {antalMeter / 1000}km");
            //            break;
            //        case "2":
            //            Console.WriteLine("Skriv in en läng i km");
            //            double antalKm = double.Parse(Console.ReadLine());
            //            Console.WriteLine($"Längden du skrev in är detsamma som {antalKm * 1000}meter");
            //            break;
            //        case "3":
            //            Console.WriteLine("Programmet avslutas....");
            //            break;
            //        default:
            //            Console.WriteLine("Du valde inte ett giltigt alternativ!");
            //            break;
            //         }
            //    }
            // }

            //Övning 7: Skriv en konsolapplikation för att beräkna antalet år tills en specifik bankinsats ska
            //växa.
            //Console.WriteLine("Hur stor är insats i banken?");
            //double insats = double.Parse(Console.ReadLine());
            //Console.WriteLine("Vad ör räntan (i %) ?");
            //double ränta = 1 + double.Parse(Console.ReadLine()) / 100.0;

            //Console.WriteLine("Vilket insatsvärde vill du nå?");
            //double mål = double.Parse(Console.ReadLine());

            //int år = 0;

            //do
            //{
            //    insats *= ränta;
            //    ++år;
            //}
            //while (insats < mål);

            //Console.WriteLine($"I {år} år insatsvärde kommer att vara {insats}kr.");
            //Console.ReadKey();


            //Övning 8: Skapa ett program där användaren får svara på frågan ”Vilket är Europas folkrikaste
            //land ?”. Användaren får maximalt 5 chanser på sig att svara.När användaren svarar rätt så ska
            //programmet skriva ut att rätt svar angavs, därefter ska det avslutas. Utnyttja ett break
            //någonstans i din loop.

            //Console.WriteLine("Vilket är Europas folkrikaste land?");
            //string svar = Console.ReadLine().ToLower();
            //int antalGissningar = 1;

            //while (svar != "Ryssland")
            //{

            //    if (antalGissningar >= 5)
            //    {
            //        Console.WriteLine("Du har inga gissningar kvar!");
            //        break;
            //    }

            //    Console.WriteLine("Fel svar, försök igen..");
            //    svar = Console.ReadLine();
            //    antalGissningar++;

            //    if (svar == "Ryssland")
            //    {
            //        Console.WriteLine("Rätt svar!");
            //    }
            //}

            //Console.WriteLine("Skriv in rektangels bredd");
            //int bredd = int.Parse(Console.ReadLine());
            //Console.WriteLine("Skriv in rektangels höjd");
            //int höjd = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 0; i < höjd; i++)
            //{
            //    for (int j = 0; j < bredd; j++)
            //    {
            //        if (i == 0 || i == höjd - 1 || j == 0 || j == bredd - 1)
            //        {
            //            Console.Write("X");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();

            //}


            //Console.WriteLine("Programmet startar");
            //Thread.Sleep(1000);
            //Console.WriteLine("Programmet börjar..");
            //Thread.Sleep(1000);
            //Console.WriteLine("Programmet avslutas...");

            //Övning 11: Skapa ett program där användaren ska få skriva in en lista över alla sporter som hen
            //har testat.Fråga först användaren hur många sporter hen vill skriva in. Därefter ska sporterna
            //skrivas in, en efter en, på var sin rad.Slutligen ska programmet skriva ut namnen på alla
            //sporterna som användaren skrev in.

            //Console.WriteLine("Hur många sporter har du testat?");
            //int antal = int.Parse(Console.ReadLine());
            //string[] sport = new string[antal];
            //for (int i = 0; i < antal; i++)
            //{
            //    Console.WriteLine("Skriv en sport:");
            //    sport[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < antal; i++)
            //{
            //    Console.WriteLine(sport[i]);
            //}

            //Övning 12: Skapa ett program som innehåller en array med minst 5 heltal.Beräkna summan av
            //alla heltal i arrayen med hjälp av en foreach-loop.

            //int[] myArray = new int[] { 1, 2, 3, 4, 5 };
            //int summa = 0;

            //foreach (int tal in myArray)
            //{
            //    summa += tal;
            //    Console.WriteLine(summa);
            //}

            //Övning 13
            //Skapa ett program som innehåller en tvådimensionell string-array med följande information som
            //symboliserar vad som skulle kunna finnas på en karta.Be användaren skriva in en X-koordinat och en Y - koordinat.
            //Programmet ska därefter berätta vad
            //som finns på rutan med dessa koordinater.

            //string[,] xyKoordinat =
            //{
            //    {"ö", "Hav", "Skog" },
            //    {"Skog", "ö", "hav" },

            //};

            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(xyKoordinat[i,j]);
            //    }
            //}

            //string[,] karta = new string[4, 2];
            //karta[0, 0] = "ö";
            //karta[1, 0] = "hav";
            //karta[2, 0] = "hav";
            //karta[3, 0] = "skog";
            //karta[0, 1] = "hav";
            //karta[1, 1] = "hav";
            //karta[2, 1] = "skog";
            //karta[3, 1] = "skog";

            //Console.WriteLine("skriv in en x-koordinat (0 - 3)");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("skriv in en y-koordinat (0 - 1");
            //int y = int.Parse(Console.ReadLine());

            //Console.WriteLine($"på denna ruta finns {karta[x, y]}");


            string[] minArray = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv något:");
                string input = Console.ReadLine();
                minArray[i] = input;
            }
            Console.WriteLine("/nDu matade in följande: ");
            foreach (string input in minArray)
            {
                Console.WriteLine(input);
            }


        }
    }
}