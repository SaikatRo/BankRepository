using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankLibrary;

namespace BankLibrary.Tests
{
    [TestClass]
    public class CalcInterestTests
    {
        [TestMethod]
        public void Calculate_AcceptsPNR_ReturnsSI()
        {
            int ExpectedResult = 1000;
            ICalcInterest calc = new CalcInterest();
            int ActualResult = calc.Calculate(10000, 10, 1);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
