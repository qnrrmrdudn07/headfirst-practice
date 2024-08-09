using headfirst_PaintBallGun;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args) // 여기엔 왜 public 안붙음?
    {
        PaintBallGun gun = new PaintBallGun();
        while (true)
        {
            Console.WriteLine($"{gun.GetBalls()} balls, {gun.GetBallsLoaded()} loaded");
            if (gun.IsEmpty()) Console.WriteLine("WARNING");
            Console.WriteLine("space to shoot, r to reload, + to add ammo, q to quit");
            char key = Console.ReadKey(true).KeyChar;
            
            if (key == ' ') Console.WriteLine($"returned {gun.Shoot()}");
            else if (key == 'r') gun.Reload();
            else if (key == '+') gun.SetBalls(gun.GetBalls() + PaintBallGun.MAGAZINE_SIZE);
            else if (key == 'q') return;
        }

    }
}