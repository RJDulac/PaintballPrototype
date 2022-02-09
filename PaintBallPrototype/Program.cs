using System;

namespace PaintBallPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = ReadInt(20, "Number of balls");
            int magaZineSize = ReadInt(16, "Magazine Size");

            Console.Write("Enter false to load or true if it's loaded:  ");
            bool.TryParse(Console.ReadLine(), out bool isLoaded);

            PaintballGun gun = new PaintballGun(numberOfBalls, magaZineSize, isLoaded);

            while (true)
            {
                Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
                if (gun.IsEmpty()) { Console.WriteLine("WARNING: you're out of ammo"); }
                Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
                Char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') { Console.WriteLine($"Shooting returned {gun.Shoot()}"); }
                else if (key == 'r') { gun.Reload(); }
                else if (key == '+') { gun.Balls += gun.MagazineSize; }
                else if (key == 'q') { return; }
            }
        }
        /// <summary>
        ///Writes a prompt and reads an int value from the console 
        /// </summary>
        /// <param name="lastValueUsed">The default value</param>
        /// <param name="prompt">PromtsPrompt to print to the console</param>
        /// <returns>The int value read, or the default value if unable to parse</returns>
        /// <exception cref="NotImplementedException"></exception>
        private static int ReadInt(int lastValueUsed, string prompt)
        {
            Console.Write($"{prompt} [{lastValueUsed}]:  ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine($"Using value {value}");
                return value;
            }
            else
            {
                Console.WriteLine($"Using default value {lastValueUsed}");
                return lastValueUsed;
            }
        }
    }
}
