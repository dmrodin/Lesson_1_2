using System;

namespace Lesson_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рассчет коммунальной платы за электричество: ");
            Console.Write("Введите тариф за квт/ч: ");

            float rate;
            float expend;

            try
            {
                rate = float.Parse(Console.ReadLine());

                Console.Write("Введите расход электроэнергии: ");

                expend = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Введено не корректное значение!");
                Console.ReadKey();
                throw;
            }

            double result = Math.Round(rate * expend, 2, MidpointRounding.ToEven);

            Console.WriteLine("Коммунальная плата составляет " + result + " р.");
            Console.ReadKey();
        }
    }
}
