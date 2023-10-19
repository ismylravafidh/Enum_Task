using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            double AZNAmount;
            double ConvertedAmount;
            do
            {
                Console.WriteLine("-----------------MENU-----------------");
                Console.WriteLine("1. USD");
                Console.WriteLine("2. EURO");
                Console.WriteLine("3. RUB");
                Console.WriteLine("4. TRY");
                Console.WriteLine("0. EXIT");
                Console.Write("Menudan Secim Edin :");
                string Currency = Console.ReadLine().ToLower();
                if(Currency == "0")
                {
                    Console.WriteLine("Proqram Dayandirildi");
                    return;
                }
                Console.Write("AZN deyerini daxil et : ");
                AZNAmount = Convert.ToDouble(Console.ReadLine());
                if (Currency == EnumCurrency.USD.ToString().ToLower() || Currency == "1")
                {
                    ConvertedAmount = AZNAmount / 1.7;
                    Console.WriteLine("Converted USD : " + ConvertedAmount);
                }
                else if (Currency == EnumCurrency.EURO.ToString().ToLower() || Currency == "2")
                {
                    ConvertedAmount = AZNAmount / 1.79;
                    Console.WriteLine("Converted EURO : " + ConvertedAmount);
                }
                else if (Currency == EnumCurrency.RUB.ToString().ToLower() || Currency == "3")
                {
                    ConvertedAmount = AZNAmount / 0.0175;
                    Console.WriteLine("Converted RUB : " + ConvertedAmount);
                }
                else if (Currency == EnumCurrency.TRY.ToString().ToLower() || Currency == "4")
                {
                    ConvertedAmount = AZNAmount / 0.06;
                    Console.WriteLine("Converted TRY : " + ConvertedAmount);
                }
                else
                {
                    Console.WriteLine("Mezenneni duzgun secin!!!!");
                    Console.Beep();
                }
                Console.WriteLine("");
                Console.WriteLine("");
            } while (true);
        }
    }
}