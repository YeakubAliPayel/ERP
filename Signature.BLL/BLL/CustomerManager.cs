using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Signature.Model.Model;
using Signature.Repository.Repository;

namespace Signature.BLL.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Add(Customer customer)
        {

            return _customerRepository.Add(customer);
        }

        public bool Delete(int id)
        {
            return _customerRepository.Delete(id);
        }

        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetById(id);
        }
    }
}
