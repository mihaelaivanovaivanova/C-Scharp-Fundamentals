using System;


namespace Problem02
{
    class Program
    {
        static void Main()
        {
            long c = int.Parse(Console.ReadLine());
            double speedCarInFront =  double .Parse (Console .ReadLine());
            double sumSpeed = 0;
            double maxSumSpeed=0;
            long counter = 1;
            long maxCounter=0;
            for (int i=0; i< c-1;i++)
            {
                double s = double.Parse (Console.ReadLine());
                if(speedCarInFront <s)
                {
                    speedCarInFront =Math.Min(speedCarInFront , s);
                    sumSpeed += s;
                    counter++;
                }
                else
                {
                    if ( i==0)
                    {
                        //speedCarInFront = Math.Min(s, speedCarInFront);
                        maxSumSpeed = speedCarInFront;
                        counter = 1;
                        sumSpeed = speedCarInFront;
                    }
                     else if (maxCounter == counter)
                    {
                        speedCarInFront = Math.Min(s, speedCarInFront);
                        maxSumSpeed = Math.Max(maxSumSpeed, sumSpeed);
                        counter = 1;
                        sumSpeed = speedCarInFront;
                    }
                    else if(maxCounter <counter)
                    {
                        speedCarInFront = Math.Min(s, speedCarInFront);
                        maxCounter = counter;
                        maxSumSpeed = sumSpeed;
                        counter = 1;
                        sumSpeed = speedCarInFront ;
                    }
                    else
                    {

                        counter = 1;
                        sumSpeed = speedCarInFront  ;
                    }
                }
                
            }
            Console.WriteLine(Math.Max (maxSumSpeed,sumSpeed));
        }
    }
}
