using F_from_x;
using System;

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
            double[] a = { -20, 19.982191425682, 311.178765702728, 1087.96472283114, 2584.71506281091 };
            double[] b = Program.Razb(0, 10, 5, -4, 3);
            for (int i = 0; i < a.Length; i++) 
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
            
        }
        [TestMethod]
        public void Array2()
        {
            double[] a = { -20, -23.6758968096121, -38.0859401796248, -90.8036595218028, -209.402584247911 };
            double[] b = Program.Razb(0, 10, 5, -4, 2);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array3()
        {
            double[] a = { -20, 19.982191425682, 311.178765702728, 1087.96472283114, 2584.71506281091 };
            double[] b = Program.Razb(0, 10, 5, 24, 3);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array4()
        {
            double[] a = { -20, -23.6758968096121, -38.0859401796248, -90.8036595218028, -209.402584247911 };
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
                Assert.AreEqual(a[i], b[i]);
            }
        }
        [TestMethod]
        public void Array6()
        {
            double[] a = { -2355.28493718909, -283.821234297272, -20, 311.178765702728, 2584.71506281091 };
            double[] b = Program.Razb(-10, 10, 5, -4, 3);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array7()
        {
            double[] a = { Double.PositiveInfinity, Double.PositiveInfinity, Double.NaN, Double.PositiveInfinity, Double.PositiveInfinity };
            double[] b = Program.Razb(-10, 10, 5, -3, 3);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i]);
            }
        }
        [TestMethod]
        public void Array8()
        {
            double[] a = { -20, 282.883264257091, 1362.78305702836, 3454.07437831382, 6791.13222811345 };
            double[] b = Program.Razb(0, 10, 5, -3.001, 3);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array9()
        {
            double[] a = { -20, -171731.434366686, -1373700.15369919, -4636200.28234619, -10989505.9446564 };
            double[] b = Program.Razb(0, 10, 5, -4, 2.924);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array10()
        {
            double[] a = { -20, 37006.2048085534, 296200.959702725, 999715.97538528, 2369702.96255899 };
            double[] b = Program.Razb(0, 10, 5, -4, 2.9241);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array11()
        {
            double[] a = { -20, -25889.8183108062, -206967.225252152, -698476.648837429, -1655642.51708003 };
            double[] b = Program.Razb(0, 10, 5, -4, 2.9239);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array12()
        {
            double[] a = { Double.NaN, Double.NaN, Double.NaN, Double.NaN, Double.NaN };
            double[] b = Program.Razb(0, 10, 5, -2.9999, 3);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i]);
            }
        }
        [TestMethod]
        public void Array13()
        {
            double[] a = { -20, 869.568941221963, 3709.52576488785, 8734.24547099766, 16178.1030595514 };
            double[] b = Program.Razb(0, 10, 5, 23.0001, 3);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array14()
        {
            double[] a = { Double.NaN, Double.PositiveInfinity, Double.PositiveInfinity, Double.PositiveInfinity, Double.PositiveInfinity };
            double[] b = Program.Razb(0, 10, 5, 23, 3);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i]);
            }
        }
        [TestMethod]
        public void Array15()
        {
            double[] a = { Double.NaN, Double.NaN, Double.NaN, Double.NaN, Double.NaN };
            double[] b = Program.Razb(0, 10, 5, 0, 0);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i]);
            }
        }
        [TestMethod]
        public void Array16()
        {
            double[] a = { -20, 19.982191425682, 311.178765702728, 1087.96472283114, 2584.71506281091 };
            double[] b = Program.Razb(0, 10, 5, -4, 3);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i], 0.001);
            }
        }
        [TestMethod]
        public void Array17()
        {
            double[] a = { Double.NaN, Double.PositiveInfinity, Double.PositiveInfinity, Double.PositiveInfinity, Double.PositiveInfinity };
            double[] b = Program.Razb(0, 10, 5, -3, 3);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i]);
            }
        }


        //write into file


        //    [TestMethod]
        //    [ExpectedException(typeof(Exception),
        //"file is not created")]
        //    public void File1()
        //    {
        //        Program.WriteAnswersToFile(Program.Razb(0, 10, 5, -4, 3), "results.txt");
        //    }

        [TestMethod]
        public void TestFileExists1()
        {
            string path = "output.txt";

            Program.WriteAnswersToFile(Program.Razb(0, 10, 5, -4, 3), path);

            // Проверяем, что файл существует
            Assert.IsTrue(File.Exists(path));
        }
        [TestMethod]
        public void TestFileExists2()
        {
            string path = "C:\\Users\\flytk\\OneDrive\\Рабочий стол\\output.txt";

            Program.WriteAnswersToFile(Program.Razb(0, 10, 5, -4, 3), path);

            // Проверяем, что файл существует
            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        public void TestCreateFile()
        {
            // Создаем массив чисел
            double[] array = Program.Razb(0, 10, 5, -4, 3);
            double[] answer = { -20, 19.982191425682, 311.178765702728, 1087.96472283114, 2584.71506281091 };

            // Создаем путь к файлу
            string path = "output.txt";

            // Вызываем функцию для создания файла
            Program.WriteAnswersToFile(array, path);

            // Проверяем, что содержимое файла соответствует ожидаемому
            //string expectedContent = string.Join("\n", answer);
            //expectedContent += "\n";
            string actualContent = File.ReadAllText(path);
            actualContent.Replace(',', '.');

            string[] elements = actualContent.Split('\n');
            // Преобразуем элементы в double

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].Replace(',', '.');
                Assert.AreEqual(Convert.ToDouble(elements[i]), answer[i], 0.001);
            }
        }
    }
}