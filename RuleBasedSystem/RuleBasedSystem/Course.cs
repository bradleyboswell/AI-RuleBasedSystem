using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBasedSystem
{
    class Course
    {
        string name;
        bool isTaken, spring, summer, fall, onDemand;
        ArrayList CoReqs, PreReqs, PostReqs;


        public Course(string name, bool isTaken, bool spring, bool summer, bool fall, bool onDemand, ArrayList CoReqs, ArrayList PreReqs, ArrayList PostReqs)
        {
            this.name = name;
            this.isTaken = isTaken;
            this.CoReqs = CoReqs;
            this.PreReqs = PreReqs;
            this.PostReqs = PostReqs;
        }
    }
}
