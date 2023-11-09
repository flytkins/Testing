using F_from_x;

namespace TestProjectMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(-19.15284937, (Program.Func(1, -4, 3)), 0.0001);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-21.94696702, (Program.Func(1, -4, 2)), 0.0001);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(-19.15284937, (Program.Func(1, 24, 3)), 0.0001);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(-21.94696702, (Program.Func(1, 24, 2)), 0.0001);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(double.NaN, (Program.Func(0, 0, 0)));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(-20, (Program.Func(0, -4, 3)), 0.0001);
        }

        [TestMethod]
        public void DivideByZeroArgA()
        {
            Assert.AreEqual(double.NaN, (Program.Func(0, -3, 3)));
        }
    }
}