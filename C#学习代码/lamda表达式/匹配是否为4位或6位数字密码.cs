public class Kata
{
  public static bool ValidatePin(string pin)
  {
    return new Regex(@"^(\d{4}|\d{6})$").IsMatch(pin);
  }
}