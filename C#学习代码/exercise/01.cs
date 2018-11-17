/*
Kata.Maskify('4556364607935616'); // should return "############5616"
Kata.Maskify('64607935616');      // should return "#######5616"
Kata.Maskify('1');                // should return "1"
Kata.Maskify('');                 // should return ""

// "What was the name of your first pet?"
Kata.Maskify('Skippy');                                   // should return "##ippy"
Kata.Maskify('Nananananananananananananananana Batman!'); // should return "####################################man!"
*/

public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    int length = cc.Length;
    if(length <=4 ){
      return cc;
    }
    return cc.Substring(length-4).PadLeft(length,'#');
  }
}