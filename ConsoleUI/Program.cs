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

           // customerManager.Add(new Customer { DateOfBirth = new DateTime(1995, 05, 22), FirstName = "Özcan", LastName = "Gülgün", NationaltyIdentity = "3458875498" }) ;

           
                foreach (var customer in  customerManager.GetAll().Data)
                            {
                                Console.WriteLine(customer.FirstName+"/"+customer.LastName);
                            }
            
         


            
           
        }
    }
}
