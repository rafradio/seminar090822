using System;

namespace WeekDay
{
    class MainModule 
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string[] weekDays = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
            Console.Write("Введите пожалуйста число (от 1 до 7): ");
            string number1 = Console.ReadLine();
            // проверяем на ввод "абракадабры"
            if (int.TryParse(number1, out int output))
            {
                if (output > 0 && output < 8)
                {
                    if (output > 5 && output < 8)
                    {
                    Console.WriteLine("Вы ввели выходный день - " + weekDays[output - 1]);
                    }
                    else 
                    {
                        Console.WriteLine("Вы ввели не выходный день - " + weekDays[output - 1]);
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не день недели - " + output);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не число - " + number1);
            }
        }
    }

}