using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class SqrtTwo
{
    public const byte two = 2;
    private static byte number=3;//samo pole  static nqma this
    //konstruktor
    static SqrtTwo()
    {
        Console.WriteLine("stati4niqt konstruktor e bez parametri i se izpylnqwa samo vednyj");
    }
    //static mrthod
    public static double Result(byte val)
    {
        Console.WriteLine(number*two);
        return Math.Sqrt(val);
    }
    
}

