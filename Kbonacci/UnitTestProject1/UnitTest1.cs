using System;
using knbonacci;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            int k = 3;
            int n = 4;
            Kbonacci z = new Kbonacci(k);
            long result = Kbonacci.Kcalculo(n, k);
            Assert.AreEqual(result, actual: 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int k = 2;
            int n = 4;
            Kbonacci z = new Kbonacci(k);
            long result = Kbonacci.Kcalculo(n, k);
            Assert.AreEqual(result, actual: 5);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int k = 2;
            int n = 0;
            Kbonacci z = new Kbonacci(k);
            long result = Kbonacci.Kcalculo(n, k);
            Assert.AreEqual(result, actual: 1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int k = 5;
            int n = 5;
            Kbonacci z = new Kbonacci(k);
            long result = Kbonacci.Kcalculo(n, k);
            Assert.AreEqual(result, actual: 5);
        }


        [TestMethod]
        public void TestMethod10()
        {
            int k = 5;
            int n = 0;
            Kbonacci z = new Kbonacci(k);
            long result = Kbonacci.Kcalculo(n, k);
            Assert.AreEqual(result, actual: 1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int k = 5;
            int n = 10;
            Kbonacci z = new Kbonacci(k);
            long result = Kbonacci.Kcalculo(n, k);
            Assert.AreEqual(result, actual: 129);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int k = 9;
            int n = 20;
            Kbonacci z = new Kbonacci(k);
            long result = Kbonacci.Kcalculo(n, k);
            Assert.AreEqual(result, actual: 16353);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int k = 5;
            int n = 30;
            Kbonacci z = new Kbonacci(k);
            long result = Kbonacci.Kcalculo(n, k);
            Assert.AreEqual(result, actual: 95653929);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int k = 30;
            int n = 50;
            Kbonacci z = new Kbonacci(k);
            long result = Kbonacci.Kcalculo(n, k);
            Assert.AreEqual(result, actual: 30408705);
        }
    }
}
