using System;
using System.Collections.Generic;

class Triangles
{
  static void Main()
  {
    Console.WriteLine("Give me a number that is one side of a triangle");
    string stringNumber1 = Console.ReadLine();
    Console.WriteLine("Give me another number that is side two of a triangle");
    string stringNumber2 = Console.ReadLine();
    Console.WriteLine("Give me one more number that is the third side of a triangle");
    string stringNumber3 = Console.ReadLine();

    int yourNumber1 = int.Parse(stringNumber1);
    int yourNumber2 = int.Parse(stringNumber2);
    int yourNumber3 = int.Parse(stringNumber3);

    if (yourNumber1 == yourNumber2 && yourNumber2 == yourNumber3)
    {
      Console.WriteLine("Your Triangle is Equalateral");
    }
    else if (yourNumber1 == yourNumber2 || yourNumber1 == yourNumber3 || yourNumber2 == yourNumber3)
    {
      Console.WriteLine("Your Triangles is Isosceles");
    }
    else if (yourNumber1 + yourNumber2 <= yourNumber3 || yourNumber1 + yourNumber3 <= yourNumber2 || yourNumber2 + yourNumber3 <= yourNumber1)
    {
      Console.WriteLine("Your Triangle is Scalene");
    }
  }
}
