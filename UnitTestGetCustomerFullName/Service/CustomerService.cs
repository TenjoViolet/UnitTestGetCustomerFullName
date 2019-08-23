using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestGetCustomerFullName.ODT;
using UnitTestGetCustomerFullName.Repository;

namespace UnitTestGetCustomerFullName.Service
{
    public class CustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        /// <summary>
        /// 傳入顧客帳號回傳顧客全名
        /// </summary>
        /// <param name="customerId">傳入顧客帳號</param>
        /// <returns>回傳顧客全名</returns>
        public string GetFullName(string customerId)
        {
            Customer customer = this._customerRepository.GetCustomerData(customerId);
            return string.Format("{0} {1}", customer.firstName, customer.lastName);
        }
    }
}
