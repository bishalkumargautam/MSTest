using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Library;

namespace UnitTestModule
{
    [TestClass]  
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange Section- we initialize variables and set its values.
            int expectedResult = 24;
            int num1 = 20;
            int num2 = 4;

            //Act Section- We invoke the method we want to test.
            int actualResult = CalculationOperation.Add(num1, num2);

            //Assert Section- we verify the method that we want to verify if the emthod behaves as per expected
            Assert.AreEqual(expectedResult, actualResult);
            Console.WriteLine("This is the test method for addition");

        }

        [TestMethod]
        public void Subtraction_test()
        {
            //Arrange Section- we initialize variables and set its values.
            int expectedResult = 20;
            int num1 = 24;
            int num2 = 4;

            //Act Section- We invoke the method we want to test.
            int actualResult = CalculationOperation.Substract(num1, num2);

            //Assert Section- we verify the method that we want to verify if the emthod behaves as per expected
            Assert.AreEqual(expectedResult, actualResult);
            Console.WriteLine("This is the test method for subtraction");

        }
        [TestMethod]
        public void Division_test()
        {
            //Arrange Section- we initialize variables and set its values.
            int expectedResult = 4;
            int num1 = 24;
            int num2 = 6;

            //Act Section- We invoke the method we want to test.
            int actualResult = CalculationOperation.Divide(num1, num2);

            //Assert Section- we verify the method that we want to verify if the emthod behaves as per expected
            Assert.AreEqual(expectedResult, actualResult);
            Console.WriteLine("This is the test method for Division test");

        }
        [TestMethod]
        public void Multiply_test()
        {
            //Arrange Section- we initialize variables and set its values.
            int expectedResult = 24;
            int num1 = 6;
            int num2 = 4;

            //Act Section- We invoke the method we want to test.
            int actualResult = CalculationOperation.Multiply(num1, num2);

            //Assert Section- we verify the method that we want to verify if the emthod behaves as per expected
            Assert.AreEqual(expectedResult, actualResult);
            Console.WriteLine("This is the test method for addition");

        }
    }
}
