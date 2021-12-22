using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4InterfacesAbstractsDemo.Abstracts
{
    //Abstract Görevi Görecek
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : "+customer.FirstName);
        }
    }
}
