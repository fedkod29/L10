using System;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type classType = typeof(RichSoilLand);
            string input = "";

            while(input != "HARVEST")
            {
                Console.Write("\nEnter your commands: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "private":
                        Console.WriteLine();
                        foreach (FieldInfo fieldInfo in classType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
                            if (fieldInfo.IsPrivate)
                                Console.WriteLine($"private {fieldInfo.FieldType.Name} {fieldInfo.Name}");
                        break;

                    case "protected":
                        Console.WriteLine();
                        foreach (FieldInfo fieldInfo in classType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
                            if (fieldInfo.IsFamily)
                                Console.WriteLine($"protectted {fieldInfo.FieldType.Name} {fieldInfo.Name}");
                        break;

                    case "public":
                        Console.WriteLine();
                        foreach (FieldInfo fieldInfo in classType.GetFields(BindingFlags.Public | BindingFlags.Instance))
                            Console.WriteLine($"public {fieldInfo.FieldType.Name} {fieldInfo.Name}");
                        break;

                    case "all":
                        Console.WriteLine();
                        foreach (FieldInfo fieldInfo in classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
                        {
                            if (fieldInfo.IsPrivate)
                                Console.WriteLine($"private {fieldInfo.FieldType.Name} {fieldInfo.Name}");

                            if (fieldInfo.IsFamily)
                                Console.WriteLine($"protectted {fieldInfo.FieldType.Name} {fieldInfo.Name}");

                            Console.WriteLine($"public {fieldInfo.FieldType.Name} {fieldInfo.Name}");
                        }   
                        break;
                }

            }
        }
    }
}
