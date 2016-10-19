using System;


namespace Problem05_2
{
    class Program
    {
        static void Main()
        {
            string p = Convert.ToString(int.Parse(Console.ReadLine()), 2);
            
            int m =int.Parse( Console.ReadLine());
            int[] newNumbers = new int[m];
            string number = string.Empty;
            bool IsMatch = true;
            for (int i=0;i< m;i++)
            {
                 number = Convert.ToString(int.Parse(Console.ReadLine()), 2);
                for (int j=number .Length-p.Length ;j>=0 ;j--)
                {
                    IsMatch = true;
                    for (int k=0; k<p.Length;k++)
                    {
                        if (number [j+k]!=p[k])
                        {
                            IsMatch = false;
                            break;
                        }
                    }
                    if (IsMatch )
                    {
                        for (int k = 0; k < p.Length; k++)
                        {
                            char[] array= number .ToCharArray ();
                            array[j + k] = '0';
                            number = new string(array);

                        }
                    }
                }
                newNumbers[i] =Convert.ToInt32 (number,2);
            }
            for (int i =0; i< m;i++)
            {
                Console.WriteLine(newNumbers [i]);
            }
        }
    }
}
