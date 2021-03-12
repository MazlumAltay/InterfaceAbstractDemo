using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager

    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.save(customer);
            }
            
        }
    }
}
