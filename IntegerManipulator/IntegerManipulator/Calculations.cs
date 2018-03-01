using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerManipulator
{
    class Calculations
    {
        public IEnumerable<int> getPrimes(int input)
        {
            int first = getAllPrimes()
                .TakeWhile(x => x <= Math.Sqrt(input))
                .FirstOrDefault(x => input % x == 0);
            return first == 0
                    ? new[] { input }
                    : new[] { first }.Concat(getPrimes(input / first));
        }

        public IEnumerable<int> getAllPrimes()
        {
            var ints = Enumerable.Range(2, Int32.MaxValue - 1);
            return ints.Where(x => !ints
                                    .TakeWhile(y => y < x)
                                    .Any(y => x % y == 0));
        }
    }
}
