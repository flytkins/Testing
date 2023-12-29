using FuncRealization;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        //Первая функцция

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

        //Вторая функция

        [TestMethod]
        public void Array1()
        {
            double[] b = FunctionClass.Razb(1, 5, 5, 0, 10);
            for (int i = 0; i < 5; i++) 
            {
                Assert.AreEqual(double.PositiveInfinity, b[i]);
            }
        }

        [TestMethod]
        public void Array2()
        {
            double[] b = FunctionClass.Razb(20, 27, 5, 1.5, -5);
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(double.NaN, b[i]);
            }
        }

        [TestMethod]
        public void Array3()
        {
            double[] b = FunctionClass.Razb(5, 23, 5, 0.5, 9.99);
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(0, b[i], 0.001);
            }
        }

        [TestMethod]
        public void Array4()
        {
            double[] a = { 5.520557522, 5.952747768, 6.418773077, 6.921282308, 7.463131694 };
            double[] b = FunctionClass.Razb(17, 20, 5, 0.99, 11);
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }

        [TestMethod]
        public void Array5()
        {
            double[] a = { 6.749553591, 8.252150891, 10.089259, 12.3353473, 15.08146366 };
            double[] b = FunctionClass.Razb(19, 27, 5, 2.01, 11);
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }

        [TestMethod]

        public void FileExist()
        {
            string filePath = "D:\\Projects\\123.txt";
            double[] b = FunctionClass.Razb(19, 27, 5, 2.01, 11);
            FunctionClass.PrintArrayToFile(b, filePath);
            Assert.IsTrue(File.Exists(filePath));  
        }

        [TestMethod]
        public void File1()
        {
            string filePath = "D:\\Projects\\123.txt";
            double[] a = { 6.749553591, 8.252150891, 10.089259, 12.3353473, 15.08146366 };
            double[] b = FunctionClass.Razb(19, 27, 5, 2.01, 11);
            double[] c = new double[5];
            FunctionClass.PrintArrayToFile(b, filePath);
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделение строки на значения по заданным разделителям
                    string[] values = line.Split('\n');
                    int i = 4;
                    // Обработка извлеченных значений
                    foreach (string value in values)
                    {
                        c[i] = Convert.ToDouble(value); i--;
                    }
                }
            }
            for(int i = 0; i < 5; i++)
            {
                Assert.AreEqual(a[i], c[i], 0.001);
            }
        }
    }
}