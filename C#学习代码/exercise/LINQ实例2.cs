//toWeirdCase( "String" );//=> returns "StRiNg"
//toWeirdCase( "Weird string case" );//=> returns "WeIrD StRiNg CaSe"

using System;
using System.Linq;

namespace ConsoleApp14 {
    class Program {
        public static void Main(string[] args ) {
            Console.WriteLine(ToWeirdCase("thi eAeer dd rrraAAAG"));
        }
        public static string ToWeirdCase( string s ) {
            return string.Join(" ",
              s.Split(' ')
              .Select(w => string.Concat(
                w.Select(( ch,i ) => i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch)
              ))));
        }
    }
}