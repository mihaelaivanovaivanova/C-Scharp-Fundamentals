using System;


namespace _10.EmployeeData
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            ulong idNum = ulong.Parse(Console.ReadLine());
            ulong employeeNum = ulong.Parse(Console.ReadLine());
            Console.WriteLine("First Name: {0}",firstName );
            Console.WriteLine("Last Name: {0}", lastName );
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID Number: {0}", idNum );
            Console.WriteLine("Unique employee number: {0}", employeeNum );
        }
    }
}
