using System;

namespace SecondDigit
{
    class MainModule 
    {
        static void Main(string[] args)
        {
            RandMethod numberRand = new RandMethod();
            // Ввод трехзначного числа через случайный выбор, через метод
            int number = numberRand.randExecute(100, 1000);
            int second = (number / 10) % 10;
            Console.WriteLine("Вторая цифра в числе: " + number + " ,равна: " + second);

        }

    }

}
