using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanei_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int g = 0;
                int m = 0;
                int s = 0;
                Console.Write("Введите градусы,минуты,секунды через пробел:");
                string input = Console.ReadLine();
                string[] str = input.Split();
                if (str.Length > 0) { g = Convert.ToInt32(str[0]); }
                if (str.Length > 1) { m = Convert.ToInt32(str[1]); }
                if (str.Length > 2) { s = Convert.ToInt32(str[2]); }
                Angle angle = new Angle(g, m, s);
                double rad = angle.ToRadians();
                Console.WriteLine("{0}°{1}'{2}'' = {3} радиан", g, m, s, rad);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка,не верный формат ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка,не правильное число ");
            }

            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            set
            {
                if (value >= 0 )
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Ошибка градусы должны быть больше 0");
                }
            }
            get { return gradus; }
        }
        public int Min
        {
            set
            {
                if (value >= 0 )
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Ошибка минуты должны быть больше 0");
                }
            }
            get { return Min; }
        }
        public int Sec
        {
            set
            {
                if (value >= 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Ошибка секунды должны быть больше 0");
                }
            }
            get { return Sec; }
        }
        public Angle(int gradus, int min = 0, int sec = 0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public double ToRadians()
        {
            double r = ((gradus * 3600 + min * 60 + sec) * Math.PI) / 648000;
            return r;
        }
    }
}
