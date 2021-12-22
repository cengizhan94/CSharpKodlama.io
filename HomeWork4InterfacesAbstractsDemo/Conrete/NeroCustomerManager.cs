using System;
using System.Collections.Generic;
using System.Text;
using HomeWork4InterfacesAbstractsDemo.Abstracts;

namespace HomeWork4InterfacesAbstractsDemo.Conrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }
    }
}
