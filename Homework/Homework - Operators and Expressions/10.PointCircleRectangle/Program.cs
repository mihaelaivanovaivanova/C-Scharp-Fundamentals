using System;


namespace _10.PointCircleRectangle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string isInCircle;
            string isInRectangle;
            bool circle = ((Math.Sqrt ((x-1)*(x-1)+(y-1)*( y-1)))<=1.5);
            bool rectangle = (x <= 5 && x >= -1 && y <= 1 && y >= -1);
            if (circle == true)
                isInCircle = "inside circle";
            else
                isInCircle = "outside circle";
            if (rectangle == true)
                isInRectangle = "inside rectangle";
            else
                isInRectangle = "outside rectangle";
            Console.WriteLine("{0} {1}", isInCircle , isInRectangle );

            //if (circle==true && rectangle == true)
            //{
            //    Console.WriteLine("inside circle inside rectangle");
            //}
            //else if (circle == true && rectangle == false)
            //{
            //    Console.WriteLine("inside circle outside rectangle");
            //}
            //else if (circle == false && rectangle == true)
            //{
            //    Console.WriteLine("outside circle intside rectangle");
            //}
            //else
            //{
            //    Console.WriteLine("outside circle outside rectangle");
            //}
        }
    }
}
