using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSpaceIndexAndOverloading
{
    public struct Idexator
    {
        public uint Num { get; set; }
        // indexator 
        public int this[int ime1, bool nBool]
        {
            // ima si get i set no wytre nqma value Nqma, no imame x[5]
            get
            {
                if (ime1 >= 0 && ime1 <= 31)
                {

                    if (((1 << ime1) & Num) == 1)
                    {
                        return 1;
                    }
                    else
                        return 0;
                }
                else
                {
                    Console.WriteLine("Invalid number");
                    return 2;
                    // moga da hwyrlq exeption i ne mi iska return
                    //throw new ArgumentException("Invalid number !");
                }
            }
            set
            {
                // moje da si napi6em na index poziciq da slojim bit 0 or 1
                // tuka izpolzwame value ve4e value = 1 ili 0 demek
            }
        }
    }
}