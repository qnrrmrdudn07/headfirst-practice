
using practice_console;
using System;

class Program
{
    static void Main(string[] arg)
    {

        Console.Write("Enter the number of cards to pick: ");
        string line = Console.ReadLine();
        if (int.TryParse(line, out int numberOfCards))
        {
            // line을 int로 변환될 수 있으면  numberOfCards 변수에 저장
            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            // 변환 불가할 때 실행
            Console.WriteLine("Please enter a valid number");
        }
    }

}
