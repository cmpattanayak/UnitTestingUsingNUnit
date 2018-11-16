using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample;
using System.Reflection;

namespace NUnitTest
{
    [TestFixture]
    public class TestClass
    {
        [TestCase]
        public void TestAdd()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(11.00, calc.Add(5, 6));
        }

        [TestCase]
        public void TestMultiply()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(15, calc.Multiply(5, 3));
        }

        /// <summary>
        /// Testing of Private methods using reflection
        /// </summary>
        [TestCase]
        public void TestDivision()
        {
            Calculator calc = new Calculator();
            BindingFlags bFlags = BindingFlags.NonPublic | BindingFlags.Instance;
            MethodInfo mInfo = calc.GetType().GetMethod("Divide", bFlags);

            object[] param = { 10, 2 };
            var res = mInfo.Invoke(calc, param);
            
            Assert.AreEqual(5, res);
        }
    }
}
