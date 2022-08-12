using System;

namespace ThirdDigit
{
    class RandMethod 
    {
        public int randExecute(int firstNum, int upperNum)
        {
            int number = new Random().Next(firstNum, upperNum);
            return number;
        }
        public int findDigit(int number)
        {
            int counter = 0;
            while (number / Math.Pow(10, counter + 1) > 1)
            {
                counter++;
            }
            return counter;

        }
        public int findThird(int number1, int counter)
        {
            double number3 = Math.Floor(number1 / Math.Pow(10, counter - 2));
            int deg = Convert.ToInt32(number3) % 10;
            return deg;

        }

    }
}