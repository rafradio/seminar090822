using System;

namespace ThirdDigit
{
    class MainModule 
    {
        static void Main(string[] args)
        {
            RandMethod numberRand = new RandMethod();
            int third;
            // Ввод числа через случайный выбор, через метод
            int number = numberRand.randExecute(10, 100);
            // Определяем количество десятков, через метод
            int number1 = numberRand.findDigit(number);
            if (number1 > 1)
            {
                // Опеределяем третью цифру через метод
                third = numberRand.findThird(number, number1);
                Console.WriteLine("Третья цифра в числе: " + number + " ,равна: " + third);
            }
            else 
            {
                Console.WriteLine("Третьей цифры в числе: " + number + " нет.");
            }
            

        }

    }

}