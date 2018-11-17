//F(n) = F(n-1) + F(n-2) with F(0) = 0 and F(1) = 1
/*
productFib(714) # should return {21, 34, 1}, 
                # since F(8) = 21, F(9) = 34 and 714 = 21 * 34

productFib(800) # should return {34, 55, 0}, 
                # since F(8) = 21, F(9) = 34, F(10) = 55 and 21 * 34 < 800 < 34 * 55
*/
using System;

namespace ConsoleApp14 {
    class Program {
        static void Main(string [ ] args) {
            foreach ( var item in productFib(714) ) {
                Console.WriteLine(item);
            }
        }
        public static ulong [ ] productFib( ulong prod ) {
            Func<ulong,ulong> func = new Func<ulong, ulong> (Fib);
            ulong count =1;
            while ( true ) {
                if(func(count-1)*func(count) == prod ) {
                    return new ulong[] { func(count - 1),func(count),1 };
                }
                if(func(count-1)*func(count) < prod && func(count) * func(count + 1) > prod ) {
                    return new ulong[] { func(count),func(count + 1),0 };
                }
                count++;
            }         
        }
        static ulong Fib(ulong n ) {
            if ( n <= 0 ) {
                return 0;
            }
            if ( n >0 && n <= 2 ) {
                return 1;
            }
            return Fib ( n-1 ) + Fib ( n - 2 );
        }
    }
 }
