using System;
using System.Text;
using System.Threading.Tasks;
using HomeWork4InterfacesAbstractsDemo.Abstracts;
using HomeWork4InterfacesAbstractsDemo.Adaptors;
using HomeWork4InterfacesAbstractsDemo.Conrete;

namespace HomeWork4InterfacesAbstractsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager manager = new StarBucksCustomerManager(new MernisServiceAdaptor());
            
            manager.Save(new Customer { NationalityId = "TCNO", FirstName = "Cengiz Han", LastName = "Uyar", DateOfBirth = new DateTime(1994),Id=1 });
        }
    }
}
