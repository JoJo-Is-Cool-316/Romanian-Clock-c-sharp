namespace Clock
{
  class StartingPoint
  {
    static void Main()
    {
      int hour;
      int minute;
      int second;
      string romanHour;
      string romanMinute;
      string romanSecond;

      while (true)
      {
        hour = DateTime.Now.Hour;
        minute = DateTime.Now.Minute;
        second = DateTime.Now.Second;

        romanHour = IntToRoman.Convert(hour);
        romanMinute = IntToRoman.Convert(minute);
        romanSecond = IntToRoman.Convert(second);
        Console.WriteLine($"\rThe Current Time is: {romanHour}:{romanMinute}:{romanSecond}");
        Thread.Sleep(1000);
      }
    }
  }
  public class IntToRoman
  {
    public static string Convert(int number)
    {
      string symbols = "";
      while (number > 0)
      {
        if (number >= 1000)
        {
          symbols += "M";
          number -= 1000;
        }
        else if (number >= 900)
        {
          symbols += "CM";
          number -= 900;
        }
        else if (number >= 500)
        {
          symbols += "D";
          number -= 500;
        }
        else if (number >= 400)
        {
          symbols += "CD";
          number -= 400;
        }
        else if (number >= 100)
        {
          symbols += "C";
          number -= 100;
        }
        else if (number >= 90)
        {
          symbols += "XC";
          number -= 90;
        }
        else if (number >= 50)
        {
          symbols += "L";
          number -= 50;
        }
        else if (number >= 40)
        {
          symbols += "XL";
          number -= 40;
        }
        else if (number >= 10)
        {
          symbols += "X";
          number -= 10;
        }
        else if (number >= 9)
        {
          symbols += "IX";
          number -= 9;
        }
        else if (number >= 5)
        {
          symbols += "V";
          number -= 5;
        }
        else if (number >= 4)
        {
          symbols += "IV";
          number -= 4;
        }
        else
        {
          symbols += "I";
          number -= 1;
        }
      }
      return symbols;
    }

  }


  // THE COMMENT OUT CLASS IS TO TURN ROMAN BACK INTO INT
  // PLANNING TO MAKE IT SO IF I TAP A BUTTON -"s"-, IT SWITCHES BETWEEN ROMAN AND INT. 

  /*
  public class RomanToInt
  {
    public static int Convert(string roman)
    {
      int total = 0;
      var numerials = new Dictionary<char, int>()
      {
        ['I'] = 1,
        ['V'] = 5,
        ['X'] = 10,
        ['L'] = 50,
        ['C'] = 100,
        ['D'] = 500,
        ['M'] = 1000
      };
      for (int i = 0; i < roman.Length; i++)
      {
        if (i < roman.Length - 1 && numerials[roman[i]] < numerials[roman[i + 1]])
        {
          total -= numerials[roman[i]];
        }
        else
        {
          total += numerials[roman[i]];
        }
      }
      return total;
    }
  }
  */
}
