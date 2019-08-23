using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestGetCustomerFullName.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using UnitTestGetCustomerFullName.Repository;
using UnitTestGetCustomerFullName.ODT;

namespace UnitTestGetCustomerFullName.Service.Tests
{
    [TestClass()]
    public class CustomerServiceTests
    {
        [TestMethod()]
        public void GetFullNameTest_傳入顧客帳號_回傳顧客全名()
        {
            //arrange準備受測物件、參數、預期結果
            ICustomerRepository customerRepository = Substitute.For<ICustomerRepository>();
            customerRepository.GetCustomerData("1").Returns(new Customer() { firstName = "John", lastName = "Smith" });
            string expected = "John Smith";

            //act執行受測方法
            CustomerService customerService = new CustomerService(customerRepository);

            string fullName = customerService.GetFullName("1");

            //assert驗證執行結果與預測結果是否一致
            Assert.AreEqual(expected, fullName);
        }
    }
}