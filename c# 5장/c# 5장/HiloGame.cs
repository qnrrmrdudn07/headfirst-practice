using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__5장
{
    static class HiloGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int nextNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;
        public static int GetPot() { return pot; }

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM +1);
            if ((higher &&  nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("\nRight");
                pot++;
            }
            else
            {
                Console.WriteLine("\nWrong");
                pot--;
            }
            currentNumber = nextNumber;
            Console.WriteLine($"number is {currentNumber}");
        }
        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
                Console.WriteLine($"number is {currentNumber} , next is at least {half}");
                else Console.WriteLine($"number is {currentNumber} , next is at most {half}");
            pot--;           
        }        
    }
}
