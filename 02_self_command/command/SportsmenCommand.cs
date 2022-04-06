using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    internal interface SportsmenCommand //interfejs to polega na tym, że potrzebuje void execute?
    {
        string execute(Sportsmen sportsmen);
    }
}
