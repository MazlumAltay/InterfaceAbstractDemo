using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntitiy
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBrith { get; set; }
        public string NationalityId { get; set; }
    }
}
