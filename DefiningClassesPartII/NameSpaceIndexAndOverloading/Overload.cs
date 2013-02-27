using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSpaceIndexAndOverloading
{
    public struct Contain
    {
        public string Result
        {
            get;
            set;
        }
        public Contain(string a): this()
        {
            this.Result = a;
        }
        public override string  ToString()
        {
            return this.Result.ToString();
        }
        public static string operator *(Contain ab, Contain vg)
        {
            Contain result = new Contain();
            result.Result = ab.Result + vg.Result;
            return result.ToString();
        }



        
    }
}
