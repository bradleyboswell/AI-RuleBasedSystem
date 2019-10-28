using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBasedSystem
{
    public class Course
    {
        public string name;
        public bool isTaken, spring, summer, fall, onDemand;
        public ArrayList CoReqs, PreReqs;


        public Course(string name, bool isTaken, bool spring, bool summer, bool fall, bool onDemand, ArrayList CoReqs, ArrayList PreReqs)
        {
            this.name = name;
            this.isTaken = isTaken;
            this.spring = spring;
            this.summer = summer;
            this.fall = fall;
            this.onDemand = onDemand;
            this.CoReqs = CoReqs;
            this.PreReqs = PreReqs;
        }

        public void printlol()
        {
            Console.WriteLine("abc");
        }
    }
}
