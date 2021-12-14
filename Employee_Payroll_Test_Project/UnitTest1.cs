using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee_Payroll_Service;
using System;

namespace Employee_Payroll_Test_Project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();
            employee.EmployeeName = "Mohan";
            employee.Department = "Tech1";
            employee.PhoneNumber = "6302907678";
            employee.Address = "02-Patna";
            employee.Gender = 'M';
            employee.BasicPay = 10000.00M;
            employee.Deductions = 1500.00M;
            employee.TaxablePay = 125.00M;
            employee.Tax = 1700.00M;
            employee.NetPay = 7000.00M;
            employee.StartDate = Convert.ToDateTime("2020-11-03");
            //Mock<EmployeeRepo> mockObj = new Mock<EmployeeRepo>();
            //mockObj.Setup(t=>t.AddEmployee(It.IsIn<EmployeeModel>)).return (true);
            var result = repo.AddEmployee(employee);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void GetAllEmployeeShouldReturnListOfFRecords()
        {
            EmployeeRepo repo = new EmployeeRepo();
            var result = repo.GetAllEmployee();
            Assert.IsTrue(result);
        }


    }
}






