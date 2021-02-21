using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.FluentValidation;
using Core.Utilities.Results;
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


        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                _customerDal.Add(customer);
                return new ErrorResult("Ekleme basarılı");
                
            }
            return new ErrorResult("EKLEME BAŞARISIZ");
        }

        public IResult Delete(int Id)
        {
            
            _customerDal.Delete(p=>p.Id==Id);
            return new SuccessResult("Silme işlemi Basarılı");
        }

        public IDataResult<Customer> Get(int Id)
        {
            
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.Id == Id));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IResult Update(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                _customerDal.Update(customer);
                return new SuccessResult("Güncelleme basarılı");
                
            }
            return new ErrorResult("Güncelleme BAŞARISIZ");
        }

       
    }

    }

