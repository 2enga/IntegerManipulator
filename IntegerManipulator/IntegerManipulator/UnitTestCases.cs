using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerManipulator
{
    [TestFixture]
    class UnitTestCases
    {
        [TestCase]
        public void getPrimesTest()
        {
            Calculations test = new Calculations();
            IEnumerable<int> actual = new int[] { 2,2,3}; 
            Assert.AreEqual(actual, test.getPrimes(12));
        }    
    }
}
