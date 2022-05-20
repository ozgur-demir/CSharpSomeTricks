using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class Inheritance
    {
        void Main()
        {
            Customer customer = new Customer();
            customer.Name = "Ozgur";
            customer.Surname = "Demir";
            customer.City = "Istanbul";
            customer.District = "Kadikoy";
            customer.Content = "A street 7/4";
        }

        class Address
        {
            public string City { get; set; }
            public string District { get; set; }
            public string Content { get; set; }
        }
        class Customer : Address //customer class took props from Address class.It's an example for Inheritance
        {
            public string Name { get; set; }
            public string Surname { get; set; }
        }
      
    }
}
