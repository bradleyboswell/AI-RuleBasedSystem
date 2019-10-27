using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBasedSystem
{
    class Person
    {
        public List<Course> coursesTaken;
        public bool isFall, isSpring, isSummer;

        public Person(bool isFall, bool isSpring, bool isSummer)
        {
            this.isFall = isFall;
            this.isSpring = isSpring;
            this.isSummer = isSummer;
            coursesTaken = new List<Course>();
        }
    }
}
