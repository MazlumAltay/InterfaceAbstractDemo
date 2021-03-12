using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.save(new Customer {DateOfBrith = new DateTime(1985,1,6), FirstName = "Engin", LastName = "Altay", NationalityId = "288614" });

        }
    }
}
