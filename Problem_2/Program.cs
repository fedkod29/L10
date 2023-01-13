using System;
using System.Reflection;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type BlackBoxintType = typeof(BlackBoxInt);
            BlackBoxInt blackBoxInt = (BlackBoxInt) Activator.CreateInstance(BlackBoxintType);

            string input = "";

            while(input != "END")
            {
                Console.Write("Enter your command: ");
                input = Console.ReadLine();

                string[] inputArray = input.Split("_");

                if(inputArray.Length != 2)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                BlackBoxintType.GetMethod(inputArray[0], BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(blackBoxInt, new object[] { Int32.Parse(inputArray[1]) });

                int result = Convert.ToInt32(BlackBoxintType.GetField("_value", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(blackBoxInt));

                Console.WriteLine($"Result: {result}");
            }


        }
    }
}
