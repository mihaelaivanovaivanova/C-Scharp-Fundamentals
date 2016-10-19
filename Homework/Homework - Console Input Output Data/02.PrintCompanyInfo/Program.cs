using System;


namespace _02.PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main()
        {
            //Console.WriteLine("Company name: ");
            string comapnyName = Console.ReadLine();
           // Console.WriteLine("Company address: ");
            string comapnyAddress = Console.ReadLine();
           // Console.WriteLine("Phone number: ");
            string phoneNumber = Console.ReadLine();
           // Console.WriteLine("Fax number: ");
            string faxNumber = Console.ReadLine();
            //Console.WriteLine("Web site: ");
            string webSite = Console.ReadLine();
            //Console.WriteLine("Manager first name: ");
            string managerFirstName = Console.ReadLine();
           // Console.WriteLine("Manager last name: ");
            string managerLastName = Console.ReadLine();
            //Console.WriteLine("Manager age: ");
            int managerAge =Int32 .Parse (Console.ReadLine());
           // Console.WriteLine("Manager phone: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine(comapnyName);
            {
                if ( comapnyAddress.Length==0)
                    Console.WriteLine("Address: (No address)");
                else Console.WriteLine("Address: {0}", comapnyAddress );
            }
            { 
                if( phoneNumber .Length ==0)
                    Console.WriteLine("Tel. (no number)");
                else Console.WriteLine("Tel. {0}", phoneNumber );
            }
            {
                if (faxNumber.Length==0)
                    Console.WriteLine("Fax: (no fax)");
                else
                    Console.WriteLine("Fax: {0}", faxNumber );
            }
            {
                if (webSite.Length == 0)
                    Console.WriteLine("Web site: (no web site)");
                else
                    Console.WriteLine("Web site: {0}", webSite );
            }
            
                Console.Write("Manager: {0} {1} (age: {2},", managerFirstName ,managerLastName ,managerAge );
           {
                    if (managerPhone.Length == 0)
                        Console.WriteLine(" tel. (no number))");
                    else
                        Console.WriteLine(" tel. {0})", managerPhone);
           }
        }
    }
}
