using System;
    class PrintCompanyInformation
    {
        static void Main()
        {
            string nameCompany = Console.ReadLine();
            string addressCompany = Console.ReadLine();
            string phone = Console.ReadLine();
            string fax = Console.ReadLine();
            string site = Console.ReadLine();
            string firstNameManager = Console.ReadLine();
            string secondNameManager = Console.ReadLine();
            int ageManager = int.Parse(Console.ReadLine());
            string phoneManager = Console.ReadLine();
            Console.WriteLine(@"{0}
Adress: {1}
Tel.{2}
Fax:{3}
Web site:{4}
Manager: {5} {6} (age: {7},tel. {8}",nameCompany,addressCompany,phone,fax,site,firstNameManager,secondNameManager,ageManager,phoneManager);



            
        }
    }
