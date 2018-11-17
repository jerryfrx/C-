//Kata.ToCamelCase("the-stealth-warrior") // returns "theStealthWarrior"

//Kata.ToCamelCase("The_Stealth_Warrior") // returns "TheStealthWarrior"

using System;
using System.Text.RegularExpressions;

namespace ConsoleApp13{
    class Program{
        public static void Main ( ) {
            Console.WriteLine(ToCamelCase("asd-sdf-dsf")); 
        }

        public static string ToCamelCase(string str) {
            return Regex.Replace(str , @"[_-](\w)" , m => m.Groups[1].Value.ToUpper());
        }
    }
}