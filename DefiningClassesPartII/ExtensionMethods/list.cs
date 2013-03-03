using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 public static class ListC
    {
     public static void ListCount(this IList<int> list)
     {
         list.Add(55);
         Console.WriteLine(list.Count);
     }
    }
