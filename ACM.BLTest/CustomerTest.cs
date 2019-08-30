using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Mbulelo";
            customer.LastName = "Mpofu";

            string expected = "Mpofu, Mbulelo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Mpofu";
            string expected = "Mpofu";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Mbulelo";
            string expected = "Mbulelo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Mbulelo";
            Customer.InstanceCount++;

            var c2 = new Customer();
            c2.FirstName = "Vuyolwethu";
            Customer.InstanceCount++;

            var c3 = new Customer();
            c3.FirstName = "Brandon";
            Customer.InstanceCount++;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);

        }
    }
}
