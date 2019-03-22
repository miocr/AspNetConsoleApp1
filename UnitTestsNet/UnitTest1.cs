using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetConsoleApp1;

namespace AspNetConsoleApp1
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInit()
        {
            TestContext.WriteLine("HELLO");
        }

        [TestMethod]
        public void TestMethod1()
        {
            System.Console.WriteLine("TEST");
            Model1 model1 = new Model1()
            {
                Id = 1,
                Name = "Josef"
            };

            Assert.AreEqual("Josef", model1.Name);
            Assert.IsTrue(model1.Id > 0);
            Assert.IsTrue(model1.Name.Length > 0);
        }
    }
}
