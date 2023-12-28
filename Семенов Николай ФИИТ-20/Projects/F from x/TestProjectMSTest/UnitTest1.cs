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


        //borders


        [TestMethod]
        public void Border1()
        {
            Assert.AreEqual(22.911, (Program.Func(1, -3.001, 3)), 0.001);
        }

        [TestMethod]
        public void Border2()
        {
            Assert.AreEqual(-11011.243, (Program.Func(1, -4, 2.924)), 0.001);
        }

        [TestMethod]
        public void Border3()
        {
            Assert.AreEqual(2347.965, (Program.Func(1, -4, 2.9241)), 0.001);
        }

        [TestMethod]
        public void Border4()
        {
            Assert.AreEqual(-1677.380, (Program.Func(1, -4, 2.9239)), 0.001);
        }

        [TestMethod]
        public void Border5()
        {
            Assert.AreEqual(double.NaN, (Program.Func(1, -2.9999, 3)));
        }

        [TestMethod]
        public void Border6()
        {
            Assert.AreEqual(116.781, (Program.Func(1, 23.0001, 3)), 0.001);
        }

        [TestMethod]
        public void Border7()
        {
            Assert.AreEqual(double.PositiveInfinity, (Program.Func(1, 23, 3)));
        }

        [TestMethod]
        public void Border8()
        {
            Assert.AreEqual(double.NaN, (Program.Func(0, 0, 0)));
        }

        [TestMethod]
        public void Border9()
        {
            Assert.AreEqual(-20, (Program.Func(0, -4, 3)), 0.001);
        }

        [TestMethod]
        public void Border10()
        {
            Assert.AreEqual(double.PositiveInfinity, (Program.Func(1, -3, 3)));
        }


        //arrays

        [TestMethod]
        public void Array1()
        {
            double[] a = { -20, -19.1528493718909, -0.611397487563494, 50.6243556529821, 149.554410049746 };
            double[] b = Program.Razb(0, 10, 5, -4, 3);
            for (int i = 0; i < a.Length; i++) 
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
            
        }
        [TestMethod]
        public void Array2()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array3()
        {
            double[] a = { -20, -19.1528493718909, -0.611397487563494, 50.6243556529821, 149.554410049746 };
            double[] b = Program.Razb(0, 10, 5, 24, 3);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array4()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, 24, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array5()
        {
            double[] a = { Double.NaN };
            double[] b = Program.Razb(0, 10, 5, 0, 0);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array6()
        {
            double[] a = { -2355.28493718909, -790.489619222653 -146.445589950254, -18.1528493718909, -0.611397487563494 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array7()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array8()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array9()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array10()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array11()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array12()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array13()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array14()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array15()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array16()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array17()
        {
            double[] a = { -20, -21.9469670189497, -22.9643386640341, -24.8168208176061, -29.2691193620187 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }

    }
}