using System;
using System.Data.SQLite;
using BookingSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolution
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FailAuthendication()
        {
            DatabaseManager.GenerateDataBase();
            if (DatabaseManager.Authenticate("none","123") == true)
            {
                Assert.Fail();
            }else
            {
                Assert.IsFalse(DatabaseManager.Authenticate("none", "123"));
            }

        }
    }
}
