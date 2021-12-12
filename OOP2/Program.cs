using System;

namespace OOP2
{

    class Program
    {
        static void Main(string[] args)
        {
            //SOLID prensibi

            //Cengiz Han Uyar
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNumber = 1;
            customer1.FirstName = "Cengiz Han";
            customer1.LastName = "Uyar";
            customer1.NationalIdentity = "12345678910";
            customer1.PlaceOfRecidenceAdress = "Doğukent Mahallesi";

            LegalEntity customer2 = new LegalEntity();
            customer2.CustomerId = 2;
            customer2.CustomerNumber = 2;
            customer2.CompanyName = "RNK";
            customer2.CompanyAdress = "TOKAT MERKEZ";

            
        }
    }
}
