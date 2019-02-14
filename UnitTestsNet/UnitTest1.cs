using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetConsoleApp1;

namespace AspNetConsoleApp1
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {

            TestContext.WriteLine("HELLO");
            System.Console.WriteLine("TEST");
            Model1 model1 = new Model1()
            {
                Id = 1,
                Name = "Karel"
            };

            Assert.AreEqual("Karel", model1.Name);
            Assert.IsTrue(model1.Id > 0);
        }
    }
}
