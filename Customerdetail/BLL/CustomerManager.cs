using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customerdetail.Model;
using Customerdetail.Repository;

namespace Customerdetail.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository=new CustomerRepository();

        public bool Exitcode(CustomerModel customerModel)
        {
            return _customerRepository.Exitcode(customerModel);
        }

        public bool Exitcontact(CustomerModel customerModel)
        {
            return _customerRepository.Exitcontact(customerModel);
        }

        public bool Addcustomer(CustomerModel customerModel)
        {
            return _customerRepository.Addcustomer(customerModel);
        }
    }
}
