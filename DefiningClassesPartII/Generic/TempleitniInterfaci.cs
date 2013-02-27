using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


 public class TempleitniInterfaci<T> 
     where T : IComparable<T>
{
     //nqkakyw metod
     public void Add(T a, T b)
     {
         Console.WriteLine(a+""+b);
         Console.WriteLine(a.CompareTo(b));
     }

}

