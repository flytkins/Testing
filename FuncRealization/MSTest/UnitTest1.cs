using FuncRealization;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(double.PositiveInfinity, Program.func(0, 10, 7));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(double.PositiveInfinity, Program.func(4, 10, 15));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(double.NaN, Program.func(1.5, -5, -20));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(double.NaN, Program.func(1.3, 55, 0));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(double.NaN, Program.func(1.7, 10, 0));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(1, Program.func(-5, 11, 0), 0.0001);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(2.44903E-38, Program.func(0.5, 9.99, 1), 0.001);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(27.56714845, Program.func(0.9, 10.01, 0.1), 0.001);
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual(double.NaN, Program.func(1.01, 11, 1));
        }
        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(1.105722266, Program.func(0.99, 11, 1), 0.001);
        }
        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(double.NaN, Program.func(1.99, 11, 1));
        }
        [TestMethod]
        public void TestMethod12()
        {
            Assert.AreEqual(1.105722266, Program.func(2.01, 11, 1), 0.001);
        }
    }
}