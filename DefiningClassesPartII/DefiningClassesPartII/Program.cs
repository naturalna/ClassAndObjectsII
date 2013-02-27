using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SqrtTwo.Result(5));
        Console.WriteLine(SqrtTwo.Result(5));
        Console.WriteLine(SqrtTwo.Result(5));
        Months month = Months.Jul;
        Console.WriteLine(month);
        //ne inicializiranite enumi s 4islo imat castwane kym int rawno na poziciqta mu
        //w redicata po4wa6ta ot 0 kato se broqt i znacite razli4ni ot =  i 4234 
        // kato se inicializira si dawa 4isloto
        Console.Write("Cast int:");
        Console.WriteLine((int)month);
        Point b = new Point(3);
        Console.WriteLine("Konstruktor s override tostring : konst s edin parametyr");
        Console.WriteLine(b.ToString());
        Point point2 = new Point(3,5);
        Console.WriteLine("Konstruktor s override tostring : konst s dwa parametyra");
        Console.WriteLine(point2.ToString());
        
    }
}

