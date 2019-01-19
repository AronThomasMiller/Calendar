using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый год: ");
            int firstYear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите первый месяц: ");
            int firstMonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите первый день: ");
            int firstDay = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй год: ");
            int secondYear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй месяц: ");
            int secondMonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй день: ");
            int secondDay = Int32.Parse(Console.ReadLine());
            int countOfDaysBetween2000And2019 = 0;
            int countOfDaysBetweenJanuaryAndSecondMonth2019 = 0;
            int countOfDaysBetweenFirstDayAndLastDayOfFirstMonth = 0;
            int countOfDays = 0; ;
            // рахуємо кількість днів між нашим першим числом і самим останнім числом цього ж місяця
            if (firstMonth == 2 && firstYear % 4 == 0)
            {
                countOfDaysBetweenFirstDayAndLastDayOfFirstMonth = 29 - firstDay;
            }
            else if (firstMonth == 2 && firstYear % 4 != 0)
            {
                countOfDaysBetweenFirstDayAndLastDayOfFirstMonth = 28 - firstDay;
            }
            else if (firstMonth == 1 || firstMonth == 3 || firstMonth == 5 || firstMonth == 7 || firstMonth == 8 || firstMonth == 10 || firstMonth == 12)
            {
                countOfDaysBetweenFirstDayAndLastDayOfFirstMonth = 31 - firstDay;
            }
            else if (firstMonth == 4 || firstMonth == 6 || firstMonth == 9 || firstMonth == 11)
            {
                countOfDaysBetweenFirstDayAndLastDayOfFirstMonth = 30 - firstDay;
            }
            //рахуэмо кількість днів між першим числом першого місяця + 1 і першим числом останнього місяця цього року
            for (int i = firstMonth + 1; i <= 12; i++)
            {
                if (i == 2 && firstYear % 4 == 0)
                {
                    countOfDays += 29;
                }
                else if (i == 2 && firstYear % 4 != 0)
                {
                    countOfDays += 28;
                }
                else if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                {
                    countOfDays += 31;
                }
                else if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    countOfDays += 30;
                }
            }
            //Кількість днів між першим і 31 числом 12тоо місяця
            int countOfDaysInDecember = 31 - 1;
            // Кількість днів між першим роком + 1 і secondYear
            for (int i = firstYear + 1; i < secondYear; i++)
            {
                if (i % 4 == 0)
                {
                    countOfDaysBetween2000And2019 += 366;
                }
                else if (i % 4 != 0)
                {
                    countOfDaysBetween2000And2019 += 365;
                }
            }
            //Кількість днів між першим числом другого року і остаточною датою
            for (int j = 1; j < secondMonth; j++)
            {
                if (j == 2 && secondYear % 4 == 0)
                {
                    countOfDaysBetweenJanuaryAndSecondMonth2019 += 29;
                }
                else if (j == 2 && secondYear % 4 != 0)
                {
                    countOfDaysBetweenJanuaryAndSecondMonth2019 += 28;
                }
                else if (j == 1 || j == 3 || j == 5 || j == 7 || j == 8 || j == 10 || j == 12)
                {
                    countOfDaysBetweenJanuaryAndSecondMonth2019 += 31;
                }
                else if (j == 4 || j == 6 || j == 9 || j == 11)
                {
                    countOfDaysBetweenJanuaryAndSecondMonth2019 += 30;
                }
            }
            int result = countOfDays + countOfDaysBetween2000And2019 + countOfDaysBetweenFirstDayAndLastDayOfFirstMonth + countOfDaysBetweenJanuaryAndSecondMonth2019 + countOfDaysInDecember;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
