using System;
using System.Collections.Generic;
using System.Text;
using HomeWork4InterfacesAbstractsDemo.Abstracts;

namespace HomeWork4InterfacesAbstractsDemo.Conrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool ChefkIfRealPerson(Customer customer)
        {
            return  true;
        }
    }


}
