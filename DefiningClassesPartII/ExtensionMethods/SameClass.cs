using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SameClass
{
    public int Numb { get; private set; }
    public SameClass(int n )
    {
        this.Numb = n;
        Console.WriteLine("It is my class");
        Console.WriteLine(this.Numb);
    }
}
