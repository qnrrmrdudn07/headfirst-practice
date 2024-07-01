using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace practice_console
{
    internal class CardPicker
    {
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();

            }   
            return pickedCards;
        }
        static readonly Random random = new();
        private static string RandomSuit()
        {
            int value = random.Next(1, 5); // 1 ~ 4 중 하나를 받음
            if (value == 0) return "Spades"; // 1이면 스페이드를 받음
            if (value == 1) return "Hearts"; // 2이면 하트를 받음
            if (value == 2) return "Clubs"; // 3이면 클로버를 받음
            return "Diamonds"; // 일치하지않으면 다이아몬드 받음
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
       

    }
       
}
