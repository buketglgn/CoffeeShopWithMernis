using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
  public class StarbucksCustomerManager :  ICustomerService
    {
        private ICustomerCheckService _customerCheckService;
        private ICustomerDal _customerDal;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService, ICustomerDal customerDal)
        {
            _customerCheckService = customerCheckService;
            _customerDal = customerDal;
        }


        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                _customerDal.Add(customer);
            }
            else
            {
                Console.WriteLine("Not a Valid Person");
            }
        }

        public void Update(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                _customerDal.Update(customer);
            }
            else
            {
                Console.WriteLine("Not a Valid Person");
            }
        }
    }
    }

