using System;


namespace Problem03
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int newn = n;
            int[] a = new int[11] { 1024,512,256,128,64,32,16,8,4,2,1 };
            string[] output = new string[11];
            for (int i=0;i<a.Length;i++)
            {   if(newn<=0)
                {
                    break;
                }
                if (newn - a[i] < 0)
                {
                    if(i==10)
                    {
                        output[i] = "A10";
                    }
                    else
                    { output[i] = "A" + i;
                    }
                    //Console.WriteLine("A{0}", i);
                }
                else if (newn - a[i] >= 0)
                {
                    newn -= a[i];
                    output[i] = "0";
                }
            }

            for (int i = output.Length - 1; i >= 0; i--)
            {
                if (output[i] != "0")
                {
                    Console.WriteLine(output[i]);
                }

            }
        }
    }
}
