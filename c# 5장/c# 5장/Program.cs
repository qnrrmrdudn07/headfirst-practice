using c__5장;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"guess number between 1 and {HiloGame.MAXIMUM}.");
        //HiloGame.Hint(); 이거 왜하는거지?
        while (HiloGame.GetPot() > 0)
        {
            Console.WriteLine($"Press h for higher, l for lower, ? to buy a hint or any key to quit with {HiloGame.GetPot()} points");
            

            char key = Console.ReadKey().KeyChar;
            if (key == 'h') HiloGame.Guess(true);
            else if (key == 'l') HiloGame.Guess(false);
            else if (key == '?') HiloGame.Hint();
            else return;
        }
        Console.WriteLine("\n You ran out of money");
        
    }
}
