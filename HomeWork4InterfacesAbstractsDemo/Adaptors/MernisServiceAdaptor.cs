using System;
using System.Collections.Generic;
using System.Text;
using HomeWork4InterfacesAbstractsDemo.Abstracts;
using MernisServiceReference;

namespace HomeWork4InterfacesAbstractsDemo.Adaptors
{
    public class MernisServiceAdaptor : ICustomerCheckService
    {
        public bool ChefkIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
