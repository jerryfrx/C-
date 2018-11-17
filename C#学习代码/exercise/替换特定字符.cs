//替换G <---> C      T <---> A
using System;
using System.Text.RegularExpressions;

namespace ConsoleApp13{
    class Program{
        public static void Main ( ) {
            Console.WriteLine (MakeComplement("GATCCAC"));
        }
        public static string MakeComplement ( string dna ) {
            return dna.Replace('T' , '?').Replace('A' , 'T').Replace('?' , 'A').Replace('G' , '?').Replace('C' , 'G').Replace('?' , 'C');
        }
    }
}
