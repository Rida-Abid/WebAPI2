using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAPI2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var uut = new Demo();
            var result = uut.Call();
            Assert.IsNotNull(result);
        }
    }
}