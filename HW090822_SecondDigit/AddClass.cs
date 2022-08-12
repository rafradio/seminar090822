using System;

namespace SecondDigit
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

    }
}