using System;


namespace Problem01_
{
    class Program
    {
        static void Main()
        {
            double px1 = double.Parse(Console.ReadLine());
            double py1 = double.Parse(Console.ReadLine());
            double px2 = double.Parse(Console.ReadLine());
            double py2 = double.Parse(Console.ReadLine());
            double fx = double.Parse(Console.ReadLine());
            double fy = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double damage = 0;
            if (d > 0)
            {
                if (((fx + d) >= px1) && ((fx + d) <= px2) && (fy >= py2) && (fy <= py1))
                {
                    damage += 100;
                    if ((fx + d + 1) <= px2)
                    {
                        damage += 75;
                    }
                    if (fy + 1 <= py1)
                    {
                        damage += 50;
                    }
                    if (fy - 1 >= py2)
                    {
                        damage += 50;
                    }
                }
                else if (((fx + d) < px1) && (fy >= py2) && (fy <= py1))
                {
                    if ((fx + d + 1) == px1)
                    {
                        damage += 75;
                    }
                }
                else if (((fx + d) >= px1) && (fx + d <= px2) && (fy < py2))
                {
                    if (fy + 1 == py2)
                    {
                        damage += 50;
                    }
                }
                else if (((fx + d) >= px1) && (fx + d <= px2) && (fy > py1))
                {
                    if (fy - 1 == py1)
                    {
                        damage += 50;
                    }
                }
                else
                {
                    damage = 0;
                }
            }
            else if (d < 0)
            {
                if (((fx + d) >= px1) && ((fx + d) <= px2) && (fy >= py2) && (fy <= py1))
                {
                    damage += 100;
                    if ((fx + d - 1) <= px1)
                    {
                        damage += 75;
                    }
                    if (fy + 1 <= py1)
                    {
                        damage += 50;
                    }
                    if (fy - 1 >= py2)
                    {
                        damage += 50;
                    }
                }
               else if (((fx + d) > px2) && (fy >= py2) && (fy <= py1))
                {
                    if ((fx + d - 1) == px2)
                    {
                        damage += 75;
                    }
                }
                else if (((fx + d) >= px1) && (fx + d <= px2) && (fy < py2))
                {
                    if (fy + 1 == py2)
                    {
                        damage += 50;
                    }
                }
                else if (((fx + d) >= px1) && (fx + d <= px2) && (fy > py1))
                {
                    if (fy - 1 == py1)
                    {
                        damage += 50;
                    }
                }
                else
                {
                    damage = 0;
                }
            }
            Console.WriteLine("{0}%", damage);


        }   
    }
}
