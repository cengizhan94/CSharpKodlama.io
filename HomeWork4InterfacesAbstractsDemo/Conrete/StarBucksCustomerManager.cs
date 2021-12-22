using System;
using System.Collections.Generic;
using System.Text;
using HomeWork4InterfacesAbstractsDemo.Abstracts;

namespace HomeWork4InterfacesAbstractsDemo.Conrete
{
    public class StarBucksCustomerManager : BaseCustomerManager 
    {

        private ICustomerCheckService customerCheckService;

        public StarBucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (customerCheckService.ChefkIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
           
        }

       
    }
}
