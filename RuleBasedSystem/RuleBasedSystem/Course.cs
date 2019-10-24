using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBasedSystem
{
    class Course
    {
        string name;
        bool isTaken, fall, spring, summer, onDemand;
        List<Course> CoReqs, OrPreReqs, PreReqs;


        public Course(string name, bool isTaken, bool fall, bool spring, bool summer, bool onDemand, List<Course> CoReqs, List<Course> OrPreReqs, List<Course> PreReqs)
        {
            this.name = name;
            this.isTaken = isTaken;
            this.fall = fall;
            this.spring = spring;
            this.summer = summer;
            this.onDemand = onDemand;
            this.CoReqs = CoReqs;
            this.OrPreReqs = OrPreReqs;
            this.PreReqs = PreReqs;          
        }
    }
}
