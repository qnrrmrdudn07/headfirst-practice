using System;

 public class Elephant
{
    public int EarSize;
    public string? Name;
    public void WhoAmI()
    {
        Console.WriteLine("My name is " + Name + ".");
        Console.WriteLine("My earsize is " + EarSize + ".");

    }
    static void Main(string[] args)
    {
        Elephant luc = new Elephant() { Name = "luc", EarSize = 33 };
        Elephant llo = new Elephant() { Name = "llo", EarSize = 44 };
        while (true)
        {
            char input = Console.ReadKey(true).KeyChar;
            if (input == '1')
            {
                Console.WriteLine("calling who am i(luc)");
                luc.WhoAmI();
            }
            else if (input == '2')
            {
                Console.WriteLine("calling who am i (llo)");
                llo.WhoAmI();
            }
            else if (input == '3')
            {
                Console.WriteLine("swapping");
                Elephant tmp;
                tmp = llo;
                llo = luc;
                luc = tmp;


            }
            else if (input == '4')
            {
                llo = luc;
                llo.EarSize = 4444;
                llo.WhoAmI();
            }
            else
            {
                return;
            }
            Console.WriteLine();
        }
    }
}

