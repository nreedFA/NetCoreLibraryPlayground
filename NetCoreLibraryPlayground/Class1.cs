using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetCoreLibraryPlayground
{
    [TestClass]
    public class NetCoreLibraryPlaygroundTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            throw new Exception("Failed Test!");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("TestMethod2 Pass!");
            Microsoft.VisualStudio.TestTools.UnitTesting.Logging.Logger.LogMessage("TestMethod2 Pass from VS Unit Testing Logging");
        }
    }
}
