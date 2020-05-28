using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Social.Networking.Kata.BusinessService.Services;

namespace Social.Networking.Kata.BusinessService.Test
{
    [TestClass]
    public class TimeFormatterUnitTest
    {
        [TestMethod]
        public void Test_Elapsed_Zero_Minutes()
        {
            var timeformatter = new TimeFormatter();
            var actual = timeformatter.elapsedMinutes(DateTime.Now);
            var expected = "0";
            Assert.AreEqual(actual, expected);
        }
    }
}
