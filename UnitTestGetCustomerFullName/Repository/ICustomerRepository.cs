using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestGetCustomerFullName.ODT;

namespace UnitTestGetCustomerFullName.Repository
{
    public interface ICustomerRepository
    {
        Customer GetCustomerData(string customerId);
    }
}
