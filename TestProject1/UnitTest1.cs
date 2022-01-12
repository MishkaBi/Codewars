using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] a = { { 10, 0 }, { 3, 5 }, { 5, 8 } };
            int expected = 5;

            int actual = Number_of_People_in_the_Bus.Program.Number(a);

            Assert.AreEqual(expected, actual);

        }
    }
}
