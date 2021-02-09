using Business.Abstract;
using Business.Adapters;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           StarbucksCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter(), new EfCustomerDal());

            customerManager.Add(new Customer { DateOfBirth = new DateTime(1996, 12, 23), FirstName = "sfsg", LastName = "fsf", NationaltyIdentity = "34356" }) ;
        }
    }
}
