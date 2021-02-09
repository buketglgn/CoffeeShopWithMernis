using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        //deneme 
        public bool CheckIfRealPerson(Customer customer)
        {
           
            return true;
        }
    }
}
