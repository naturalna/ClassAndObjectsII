using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//where se pi6e izwyn skobite
//kanstrenti se kazwa mai
public class GenericSUgranichenie<T>
    where T : IDisposable, new()
{
    private T number;
    public void Print(T n,T num)
    {
        Console.WriteLine(n +"" +num);
    }
}

