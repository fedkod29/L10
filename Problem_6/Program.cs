using System;
using System.Reflection;
namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colorArray;
            int n = 1;

            while (true)
            {
                Console.Write("Enter colors: ");
                colorArray = Console.ReadLine().Split(" ");

                if (colorArray.Length != 0)
                    break;
            }

            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            TrafficLights[] trafficLightsArray = new TrafficLights[n];

            Type trafficType = typeof(TrafficLights);


            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < colorArray.Length; j++)
                {
                    trafficLightsArray[i] = new TrafficLights();

                    var color = trafficType.GetField("_color", BindingFlags.Instance | BindingFlags.NonPublic);

                    color?.SetValue(trafficLightsArray[i], colorArray[j]);

                    var valueColor = color?.GetValue(trafficLightsArray[i]);

                    trafficType.GetMethod("ChageColor", BindingFlags.Instance | BindingFlags.NonPublic)
                        .Invoke(trafficLightsArray[i], null);

                    valueColor = color?.GetValue(trafficLightsArray[i]);
                    colorArray[j] = (string)valueColor;

                    Console.Write(valueColor+ " ");
                }

                Console.WriteLine();
            }
        }
    }
}
