using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        private double _usd;
        private double _eur;
        private double _rub;
        private void Checker(string message, bool fork, int value)
        {
            Console.WriteLine("What currency do you want  to " + message + " usd/eur/rub ");
            string choise = Console.ReadLine().ToLower();

            switch (choise)
            {
                case "usd":
                    if (fork)
                    {
                        Console.WriteLine($"Your result from USD to UAH  = {_usd * value}");
                        break;
                    }
                    Console.WriteLine($"Your result from USD to UAH  = {value / _usd}");
                    break;

                case "eur":
                    if (fork)
                    {
                        Console.WriteLine($"Your result from USD to UAH  = {_eur * value}");
                        break;
                    }
                    Console.WriteLine($"Your result from USD to UAH  = {value / _eur}");
                    break;

                case "rub":
                    if (fork)
                    {
                        Console.WriteLine($"Your result from USD to UAH  = {_rub * value}");
                        break;
                    }
                    Console.WriteLine($"Your result from USD to UAH  = {value / _rub}");
                    break;

                default:
                    throw new Exception("Wrong currency");
            }
        }
        public void ConvertToUah(int Yourcurency)
        {
            Checker("Echenge", true, Yourcurency);

        }
        public void ConvertFromUah(int Yourcurency)
        {
            Checker("Get", false, Yourcurency);
        }
    }
    internal class Program2
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.70, 37.10, 0.65);
            Console.WriteLine("Write value of UAH");
            converter.ConvertFromUah(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Write value any other currency");
            converter.ConvertToUah(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}