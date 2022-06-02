using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //meta per a que s'executi
        public void TestMethod1()
        {
            string result = DemoTesting.Program.MetodeQualsevol();
            Assert.AreEqual("Algun text", result);
        }

        [TestMethod]
        public void TestLoginTrue()
        {
            bool result = DemoTesting.Program.Login("JAUME", "1234");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestLoginFalse()
        {
            bool result = DemoTesting.Program.Login("JAUME", "123456");
            Assert.AreEqual(false, result);
        }
    }
}
