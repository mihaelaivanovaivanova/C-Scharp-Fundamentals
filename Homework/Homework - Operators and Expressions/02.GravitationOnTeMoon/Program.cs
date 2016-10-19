using System;


namespace _02.GravitationOnTeMoon
{
    class Program
    {
        static void Main()
        {
            double weightEarth = Double.Parse(Console.ReadLine());
            double weightMoon = 0.17 * weightEarth;
  
            // Console.WriteLine(weightMoon .ToString("#.000"));
            Console.WriteLine("{0:F3}",weightMoon );
        }
    }
}
