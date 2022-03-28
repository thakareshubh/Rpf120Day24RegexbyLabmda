using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uc1EnterValidFirstName;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = "SAD ";
            var actual = new Uc1EnterValidFirstName.MoodAnalyser("Sad");
            Assert.AreEqual(expected, actual);

        }
    }
}
