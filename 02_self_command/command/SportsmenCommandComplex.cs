using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    internal abstract class SportsmenCommandComplex: SportsmenCommand
    {
        public string name { get; private set; }
        public SportsmenCommandComplex(string name) //czy właściwość równa się składowej
        {
            this.name = name;

        }
        public abstract string execute(Sportsmen sportsmen);
        public override string ToString()
        {
            return name;
        }
    }
}
