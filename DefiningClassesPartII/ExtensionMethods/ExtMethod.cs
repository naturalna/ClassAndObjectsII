using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static class ExtMethod
{
    public static int Power(this SameClass extClass, int newNumber)
    {
        // dostypwame propyrtitata w klasyt ni i si wzimame i nashi drugi 
        // w slu4eqt newNumber
       return extClass.Numb* newNumber;
    }
}

