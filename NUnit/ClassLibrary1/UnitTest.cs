using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class UnitTest
    {
        [Test]
        public void AdditionTest()
        {
            Assert.AreEqual(5, Calculator.Addition(3, 2));
        }

        [Test]
        public void AdditionTest2()
        {
            Assert.AreEqual(-2, Calculator.Addition(-4, 2));
        }

        [Test]
        public void AdditionTest3()
        {
            Assert.AreEqual(1, Calculator.Addition(3, -2));
        }

        [Test]
        public void AdditionTest4()
        {
            Assert.AreEqual(-5, Calculator.Addition(-3, -2));
        }

        [Test]
        public void AdditionTest5()
        {
            Assert.AreEqual(-3, Calculator.Addition(-3, 0));
        }

        [Test]
        public void DivisionTest()
        {
            Assert.AreEqual(2, Calculator.Division(4, 2));
        }

        [Test]
        public void DivisionTest2()
        {
            Assert.AreEqual(-2, Calculator.Division(-4, 2));
        }

        [Test]
        public void DivisionTest3()
        {
            Assert.AreEqual(-4, Calculator.Division(-4, 1));
        }

        [Test]
        public void DivisionTest4()
        {
            Assert.AreEqual(8, Calculator.Division(4, 0.5));
        }

        [Test]
        public void DivisionTest5()
        {
            Assert.AreEqual(0.25, Calculator.Division(0.5, 2));
        }

        [Test]
        public void MultiplicationTest()
        {
            Assert.AreEqual(8, Calculator.Multiplication(4, 2));
        }

        [Test]
        public void MultiplicationTest2()
        {
            Assert.AreEqual(-8, Calculator.Multiplication(-4, 2));
        }

        [Test]
        public void MultiplicationTest3()
        {
            Assert.AreEqual(8, Calculator.Multiplication(-4, -2));
        }

        [Test]
        public void MultiplicationTest4()
        {
            Assert.AreEqual(0, Calculator.Multiplication(-4, 0));
        }

        [Test]
        public void MultiplicationTest5()
        {
            Assert.AreEqual(0, Calculator.Multiplication(0, 0));
        }

        [Test]
        public void SubtractionTest()
        {
            Assert.AreEqual(2, Calculator.Subtraction(4, 2));
        }

        [Test]
        public void SubtractionTest2()
        {
            Assert.AreEqual(-6, Calculator.Subtraction(-4, 2));
        }

        [Test]
        public void SubtractionTest3()
        {
            Assert.AreEqual(6, Calculator.Subtraction(4, -2));
        }

        [Test]
        public void SubtractionTest4()
        {
            Assert.AreEqual(3, Calculator.Subtraction(-1, -4));
        }

        [Test]
        public void SubtractionTest5()
        {
            Assert.AreEqual(2, Calculator.Subtraction(0, -2));
        }
    }
}
