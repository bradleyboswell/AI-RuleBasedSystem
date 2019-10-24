using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuleBasedSystem
{

    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            List<Course> CoReqs = new List<Course>();
            List<Course> PreReqs = new List<Course>();
            List<Course> PostReqs = new List<Course>();
            Course comp1 = new Course("ENGL 1101 Composition I", true, true, true, true, true,CoReqs,PreReqs,PostReqs);
            PrintDialog(comp1.name);

        }

        public class Course
        {
            string name;
            bool isTaken, fall, spring, summer, onDemand;
            List<Course> CoReqs, PreReqs, PostReqs;


	        public Course(string name, bool isTaken, bool fall, bool spring, bool summer, bool onDemand, List<Course> CoReqs, List<Course> PreReqs, List<Course> PostReqs)
	        {
                this.name = name;
                this.isTaken = isTaken;
                this.fall = fall;
                this.spring = spring;
                this.summer = summer;
                this.onDemand = onDemand;
                this.CoReqs = CoReqs;
                this.PreReqs = PreReqs;
                this.PostReqs = PostReqs;
	        }
        }

        public class Person
        {
             public List<Course> coursesTaken;
             public bool isFall, isSpring, isSummer;

	        public Person(bool isFall,bool isSpring,bool isSummer)
	        {
                this.isFall = isFall;
                this.isSpring = isSpring;
                this.isSummer = isSummer;
                coursesTaken = new List<Course>();

	        }
        }


    }
}
