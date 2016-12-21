using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods;

namespace ExtensionMethodsTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestISO8601WeekDates()
        {
            // According to wikipedia
            // Monday 29 December 2008 is week 1
            // Sunday 3 January 2010 is written week 53

            // Ready 
            DateTime dt1 = new DateTime(2008, 12, 29);
            DateTime dt2 = new DateTime(2010, 1, 3);

            // Set
            int week4dt1 = dt1.WeekOfYearISO8601();
            int week4dt2 = dt2.WeekOfYearISO8601();

            // Go
            Assert.AreEqual(1, week4dt1);
            Assert.AreEqual(53, week4dt2);
        }
    }
}
