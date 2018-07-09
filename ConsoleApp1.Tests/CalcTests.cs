using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    public class CalcTests
    {
        [Test]
        public void AddPositives()
        {
            Assert.AreEqual(4, Calc.Add(2, 2));
        }

        [Test]
        public void AddNegatives()
        {
            Assert.AreEqual(-5, Calc.Add(-2, -3));
        }
    }
}
