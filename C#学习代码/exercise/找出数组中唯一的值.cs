/*findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55*/

using System;
using System.Text.RegularExpressions;
using System . Linq;
using System . Collections . Generic;

namespace ConsoleApp13{
    class Program{
        public static void Main ( ) {
            Console . WriteLine (GetUnique (new [ ] { 1,1,1,2})); 
        }
        public static int GetUnique(IEnumerable<int> numbers) {
            return numbers . GroupBy (x => x) . Single (x => x . Count () == 1) . Key;
            }
    }
}