using System;
using System.Threading;

namespace kamen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // SETTINGS

            int pc_body = 0;
            int ja_body = 0;
            string verze = "1.0.1";

        Start:

            Console.WriteLine("==========================");
            Console.WriteLine("Kámen Núžky Papír | " + verze);
            Console.WriteLine("==========================");
            Console.WriteLine();
            Console.WriteLine("Body PC: "+pc_body);
            Console.WriteLine("Body JÁ: "+ja_body);
            Console.WriteLine();
            Console.WriteLine("[SYSTÉM] Pro spuštění hry stiskněte klávesu c/C.");

            char klavesa = Console.ReadKey(true).KeyChar;

            if (klavesa.ToString() == "c")
            {
                Console.WriteLine("[SYSTÉM] Spouštím hru...");
                Thread.Sleep(2000);
                Console.Clear();
                goto Hra;
            }
            else if (klavesa.ToString() == "C")
            {
                Console.WriteLine("[SYSTÉM] Spouštím hru...");
                Thread.Sleep(2000);
                Console.Clear();
                goto Hra;
            }
            else
            {
                Console.WriteLine("[SYSTÉM] Co si dovoluješ zmáčnout jinou klávesu!");
                Thread.Sleep(2000);
                Console.Clear();
                goto Start;
            }

        Hra:

            Console.WriteLine("==========================");
            Console.WriteLine("Kámen Núžky Papír | " + verze);
            Console.WriteLine("==========================");
            Console.WriteLine();

            string[] volby = { "K", "N", "P" };

            Console.WriteLine("[SYSTÉM] Vyber si volbu K,N,P");
            char input = Console.ReadKey(true).KeyChar;
            Random random = new Random();
            int start2 = random.Next(0, volby.Length);
            Console.Write("[SYSTÉM] PC Vybral: " + volby[start2]);

            if (volby[start2] == input.ToString().ToUpper())

            {
                Console.WriteLine("\n[SYSTÉM] Remíza");
                Thread.Sleep(3000);
                Console.Clear();
                goto Start;
            }
            else if (volby[start2] == "K" && input.ToString().ToUpper() == "N")
            {
                Console.WriteLine("\n[SYSTÉM] Kámen vyhrává nad Nůžkami");
                pc_body++;
                Thread.Sleep(3000);
                Console.Clear();
                goto Start;
            }
            else if (volby[start2] == "N" && input.ToString().ToUpper() == "P")
            {
                Console.WriteLine("\n[SYSTÉM] Nůžky vyhrávjí nad Papírem");
                pc_body++;
                Thread.Sleep(3000);
                Console.Clear();
                goto Start;
            }
            else if (volby[start2] == "P" && input.ToString().ToUpper() == "K")
            {
                Console.WriteLine("\n[SYSTÉM] Papír vyhrává nad Kamenem");
                pc_body++;
                Thread.Sleep(3000);
                Console.Clear();
                goto Start;
            }
            else
            {
                Console.WriteLine("\n[SYSTÉM] Vyhrál jste!");
                ja_body++;
                Thread.Sleep(3000);
                Console.Clear();
                goto Start;



            }
      


            
            
           
            Console.ReadKey();
        }
    }
}