using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCD.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void ValidateEmail()
        {
            //if the user requested a receipt
            //get the customer data
            //ensure a valid email address was provided
            //if not,
            //request an email address from the user
        }
    }
}
