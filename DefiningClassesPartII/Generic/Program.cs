using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic
{
    class Program
    {
        static void Main()
        {
            GenericListD<int, string> student = new GenericListD<int, string>(3);
            GenericListD<int, int> nubmbers = new GenericListD<int, int>();
            student.Add(222222, "ani");
            //Ako iskam klas bez parametri .samo da priema razni danni polzwame Tuple do 8 sa
            Tuple<int, byte> tuple = new Tuple<int, byte>(1,5);
            Console.WriteLine(tuple.Item1);// moga da wikam otdelnite parametri posle
            TempleitniInterfaci<int> compare = new TempleitniInterfaci<int>();
            compare.Add(10,12);
        }
    }
}
