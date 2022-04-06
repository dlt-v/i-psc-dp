using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    internal class Sportsmen
    {
        //public string _name;
        //public string name { 
        //    get { 
        //        return _name;
        //    } 
        //    private set { 
        //        _name = value; 
        //    } 
        
        //} //public getter, private setter

        public string name { get; private set; }
        public Sportsmen (string name) //czy właściwość równa się składowej
        {
            this.name = name;

        }
        public string Run() { return "Running"; }
        public string Jump() { return "Jumping"; }
        public string Swim() { return "Swimming"; }

        public string execute(SportsmenCommand command)
        {
            return name +": "+command.execute(this);
        }

    }
}
