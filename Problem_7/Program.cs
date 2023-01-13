using System;

namespace Problem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon;
            string input = "";
            string[] arr;

            Console.Write("Enter your command:  ");
            input = Console.ReadLine();

            Console.WriteLine("Enter name, type, rarity");
            arr = Console.ReadLine().Split(";");
            weapon = new Weapon(arr[0], arr[1], arr[2]);

            while (input != "END")
            {
                Console.Write("Enter your command:  ");
                input = Console.ReadLine();

                switch (input) 
                {
                    case "Add":
                        Console.WriteLine("Enter index, clarity and type: ");
                        arr = Console.ReadLine().Split(";");
                        weapon.AddGem(Convert.ToInt32(arr[0]), arr[1], arr[2]);
                        break;

                    case "Remove":
                        Console.WriteLine("Enter index");
                        input = Console.ReadLine();
                        weapon.RemoveGem(Convert.ToInt32(input));
                        break;

                    case "Print":
                        Console.WriteLine(weapon.ToString());
                        break;

                    default:
                        Console.WriteLine("Inccoret input");
                        break;
                }

            }
        }
    }
}
