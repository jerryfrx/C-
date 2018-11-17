/*Symbol    Value
I          1
V          5
X          10
L          50
C          100
D          500
M          1,000

  [TestCase(1, "I")]
  [TestCase(2, "II")]
  [TestCase(4, "IV")]
  [TestCase(500, "D")]
  [TestCase(1000, "M")]
  [TestCase(1954, "MCMLIV")]
  [TestCase(1990, "MCMXC")]
  [TestCase(2008, "MMVIII")]
  [TestCase(2014, "MMXIV")]
*/

using System;

public class RomanConvert
{
  public static string Solution(int n)
  {
  string roman = "";
  string[] thousand = {"","M","MM","MMM"};
  string[] hundred = {"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
  string[] ten = {"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
  string[] one = {"","I","II","III","IV","V","VI","VII","VIII","IX"};
  
  roman += thousand[(n/1000)%10];
  roman += hundred[(n/100)%10];
  roman += ten[(n/10)%10];
  roman += one[n%10];
  
  return roman;
    
  }
}