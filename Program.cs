using System;

namespace Zadacha
{
    class Program
    {
        static void Main()
        {
            var curs = 80;
            var tryparse = false;
            var value = 0;
            while (!tryparse)
            {
                Console.Write("Доллары:");
                var dollar = Console.ReadLine();
                tryparse = int.TryParse(dollar, out value);
            }
            var rubli = value * curs;
            Console.WriteLine("Курс: 1 доллар = {0} рублей", curs);
            if(value<500)
            {
                Console.WriteLine("Учитывая комиссию 8 рублей, у вас "+(rubli - 8));
            }
            else
            {
                Console.WriteLine("Учитывая комиссию 3%, у вас " + (rubli - ((rubli * 3) / 100)));
            }
        }
    }
}
