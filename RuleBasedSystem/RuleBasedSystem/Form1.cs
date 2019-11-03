using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuleBasedSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           
            //Maybe have radio button for which term the student is looking to take classes for
            //For now we will look for Spring

            //1 = Spring, 2 = Summer, 3 = Fall
            int nextSemester = 1;


            //Course List set to IsCompleted = false by default
            Course Healthful_Living = new Course
            {
                Prefix = "HLTH 1520",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Physical_Activity_1 = new Course
            {
                Prefix = "KINS 1XXX",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Physical_Activity_2 = new Course
            {
                Prefix = "KINS 1XXX",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course First_Year_Experience = new Course
            {
                Prefix = "FYE 1220",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };

            Course Composition_1 = new Course
            {
                Prefix = "ENGL 1101",
                IsCompleted = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Composition_2 = new Course
            {
                Prefix = "ENGL 1102",
                IsCompleted = false,
                hasPreReqs = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Composition_1 } }
            };
            Course College_Algebra = new Course
            {
                Prefix = "MATH 1111",
                IsCompleted = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Trigonometry = new Course
            {
                Prefix = "MATH 1112",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { College_Algebra } }
            };
            Course Pre_Calculus = new Course
            {
                Prefix = "MATH 1113",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { College_Algebra } }
            };
            Course Calculus_1 = new Course
            {
                Prefix = "MATH 1441",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Pre_Calculus, Trigonometry } }
            };

            //EXTRA POSSIBLE COURSES
            Course Quantitative_Reasoning = new Course
            {
                Prefix = "MATH 1001",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_To_Mathematical_Modeling = new Course
            {
                Prefix = "MATH 1101",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Survey_of_Calculus = new Course
            {
                Prefix = "MATH 1232",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Introduction_To_Mathematical_Modeling, College_Algebra, Trigonometry, Pre_Calculus } }
            };
            Course Elementary_Statistics = new Course
            {
                Prefix = "STAT 1401",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Quantitative_Reasoning } }
            };
            //EXTRA POSSIBLE COURSES

            Course World_History_2 = new Course
            {
                Prefix = "HIST 1112",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Global_Citizens = new Course
            {
                Prefix = "FYE 1410",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { First_Year_Experience } }
            };

            Course World_Literature_1_or_2 = new Course
            {
                Prefix = "ENGL 2111/2112",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Composition_2 } }
            };
            Course Public_Speaking = new Course
            {
                Prefix = "COMM 1110",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Composition_1 } }
            };

            Course Principles_of_Chemistry_1_with_lab = new Course
            {
                Prefix = "CHEM 1211K",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_to_the_Earth = new Course
            {
                Prefix = "GEOL 1121",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_to_Physics_1 = new Course
            {
                Prefix = "PHYS 1111K",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Pre_Calculus, Trigonometry } }
            };
            Course Principles_of_Physics_1 = new Course
            {
                Prefix = "PHYS 2211K",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Calculus_1 } }
            };

            Course Environmental_Biology_with_lab = new Course
            {
                Prefix = "BIOL 1230 & 1210",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Chemistry_and_the_Environment_with_lab = new Course
            {
                Prefix = "CHEM 1040",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Environment_Geology_with_lab = new Course
            {
                Prefix = "GEOL 1340",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Environment_Physics_with_lab = new Course
            {
                Prefix = "PHYS 1149",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };

            Course Economics_in_a_Global_Society = new Course
            {
                Prefix = "ECON 2105",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course US_A_Comprehensive_Survey = new Course
            {
                Prefix = "HIST 2110",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course American_Government = new Course
            {
                Prefix = "POLS 1101",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_to_Anthropology = new Course
            {
                Prefix = "ANTH 1102",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course World_Regional_Geography = new Course
            {
                Prefix = "GEOG 1130",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_to_Phychology = new Course
            {
                Prefix = "PSYC 1101",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_to_Sociology = new Course
            {
                Prefix = "SOCI 1101",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };

            Course Programming_Principles_1 = new Course
            {
                Prefix = "CSCI 1301",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Calculus_1 } }
            };
            Course Calculus_2 = new Course
            {
                Prefix = "MATH 2242",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Calculus_1 } }
            };
            Course Discrete_Math = new Course
            {
                Prefix = "MATH 2130",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Introduction_To_Mathematical_Modeling, College_Algebra, Trigonometry, Pre_Calculus, Calculus_1, Calculus_2 } }
            };
            Course Programming_Principles_2 = new Course
            {
                Prefix = "CSCI 1302",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_1 }, new Course[] { Discrete_Math }, new Course[] { Calculus_1 } }
            };
            Course Statistics_1 = new Course
            {
                Prefix = "STAT 2231",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { College_Algebra, Trigonometry, Pre_Calculus, Calculus_1 } }
            };
            Course Linear_Algebra = new Course
            {
                Prefix = "MATH 2160",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Calculus_2 } }
            };
            Course Computers_Ethics_and_Society = new Course
            {
                Prefix = "CSCI 2120",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_1 }, new Course[] { Public_Speaking } }
            };

            Course Introduction_To_International_Studies = new Course
            {
                Prefix = "INTS 2130",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };

            //EXTRA
            Course Principles_Of_Biology_1_With_Lab = new Course
            {
                Prefix = "BIOL 1107 & 1107L",
                IsCompleted = false,

                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { College_Algebra, Pre_Calculus }, new Course[] { Composition_1 } }
            };
            //End EXTRA
            Course Principles_Of_Biology_2_With_Lab = new Course
            {
                Prefix = "BIOL 1108 & 1108L",
                IsCompleted = false,

                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Principles_Of_Biology_1_With_Lab } }
            };
            Course Principles_Of_Chemistry_2_With_Lab = new Course
            {
                Prefix = "CHEM 1212K",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Principles_of_Chemistry_1_with_lab } }
            };
            Course General_Historical_Geology_With_Lab = new Course
            {
                Prefix = "GEOL 1122",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Introduction_to_the_Earth } }
            };
            Course Introduction_to_Physics_2_with_Lab = new Course
            {
                Prefix = "PHYS 1112K",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Introduction_to_Physics_1 } }
            };
            Course Principles_of_Physics_2 = new Course
            {
                Prefix = "PHYS 2212K",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Principles_of_Physics_1 } }
            };

            //MAJOR REQUIRED COURSES
            Course Data_Structures = new Course
            {
                Prefix = "CSCI 3230",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 }, new Course[] { Discrete_Math } }
            };
            Course Systems_Software = new Course
            {
                Prefix = "CSCI 3232",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 } } //concurrent or prior DS
            };
            Course Cpp_Programming = new Course
            {
                Prefix = "CSCI 2490",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 } }
            };
            Course Introduction_To_Operating_Systems = new Course
            {
                Prefix = "CSCI 3341",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = false,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Data_Structures }, new Course[] { Cpp_Programming } }
            };
            Course Theoretical_Foundations = new Course
            {
                Prefix = "CSCI 3236",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 }, new Course[] { Discrete_Math } }
            };
            Course Database_Systems = new Course
            {
                Prefix = "CSCI 3432",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_1 }, new Course[] { Discrete_Math } }
            };
            Course Algorithm_Design_and_Analysis = new Course
            {
                Prefix = "CSCI 5330",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Theoretical_Foundations }, new Course[] { Calculus_2 } }
            };
            Course Computer_Architecture = new Course
            {
                Prefix = "CSCI 5331",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Systems_Software, Introduction_To_Operating_Systems } }
            };
            Course Data_Communications_And_Networking = new Course
            {
                Prefix = "CSCI 5332",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Systems_Software, Introduction_To_Operating_Systems }, new Course[] { Elementary_Statistics } }
            };
            Course Object_Oriented_Design = new Course
            {
                Prefix = "CSCI 5335",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Data_Structures } }
            };
            Course Computer_Security = new Course
            {
                Prefix = "CSCI 5431",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Computers_Ethics_and_Society } }
            };
            Course Distributed_Web_Systems_Design = new Course
            {
                Prefix = "CSCI 5436",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Database_Systems } }
            };
            Course Software_Engineering = new Course
            {
                Prefix = "CSCI 5530",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Algorithm_Design_and_Analysis }, new Course[] { Object_Oriented_Design }, new Course[] { Database_Systems } }
            };
            Course Computing_for_Engineers = new Course
            {
                Prefix = "ENGR 1731",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Calculus_1 } }
            };
            Course Logic_Circuit_Design = new Course
            {
                Prefix = "ENGR 2332",
                IsCompleted = false,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Computing_for_Engineers } }
            };
            Course Logic_Circuits_and_Microprocessors = new Course
            {
                Prefix = "CSCI 3231",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 } }
            };
            Course Comparative_Languages = new Course
            {
                Prefix = "CSCI 3330",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Cpp_Programming } }
            };
            Course Data_Warehouse_Design = new Course
            {
                Prefix = "CSCI 4132",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Database_Systems } }
            };
            Course High_Performance_Computing = new Course
            {
                Prefix = "CSCI 4210",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Introduction_To_Operating_Systems } }
            };
            Course Human_Computer_Interaction = new Course
            {
                Prefix = "CSCI 4235",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = false,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Data_Structures } }
            };
            Course Game_Programming = new Course
            {
                Prefix = "CSCI 4439",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = false,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 } }
            };
            Course Machine_Learning = new Course
            {
                Prefix = "CSCI 4520",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Cpp_Programming }, new Course[] { Discrete_Math } }
            };
            Course Numerical_Analysis = new Course
            {
                Prefix = "CSCI 4610",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_1 }, new Course[] { Calculus_2 } }
            };
            Course Software_Testing_and_Quality_Assurance = new Course
            {
                Prefix = "CSCI 4534",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Theoretical_Foundations } }
            };
            Course Broadband_Networks = new Course
            {
                Prefix = "CSCI 4537",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Data_Communications_And_Networking } }
            };
            Course Optical_Networks = new Course
            {
                Prefix = "CSCI 4539",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Data_Communications_And_Networking } }
            };
            Course Selected_Topics = new Course
            {
                Prefix = "CSCI 5090",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Discrete_Simulation = new Course
            {
                Prefix = "CSCI 5230",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Elementary_Statistics }, new Course[] { Data_Structures } }
            };
            Course Artificial_Intelligence = new Course
            {
                Prefix = "CSCI 5430",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = false,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Data_Structures }, new Course[] { Algorithm_Design_and_Analysis } }
            };
            Course Computer_Graphics = new Course
            {
                Prefix = "CSCI 5437",
                IsCompleted = false,
                Fall = true,
                Summer = false,
                Spring = false,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Data_Structures }, new Course[] { Theoretical_Foundations } }
            };
            Course Animation = new Course
            {
                Prefix = "CSCI 5438",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Computer_Graphics } }
            };
            Course Systems_and_Software_Assurance = new Course
            {
                Prefix = "CSCI 5531",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 }, new Course[] { Database_Systems } }
            };
            Course Network_Management_Systems = new Course
            {
                Prefix = "CSCI 5532",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Data_Communications_And_Networking } }
            };
            Course Wireless_and_Mobile_Systems = new Course
            {
                Prefix = "CSCI 5538",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Data_Communications_And_Networking }, new Course[] { Calculus_1 } }
            };


            //MORE EXTRAS FROM THE WEBLINK 
            Course Comp_App_For_Bus_Majors = new Course
            {
                Prefix = "CSCI 1130M",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Data_Communications_And_Networking } }
            };
            Course Introduction_To_BASIC_Programming = new Course
            {
                Prefix = "CSCI 1230",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Introduction_To_Java_Programming = new Course
            {
                Prefix = "CSCI 1236",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { College_Algebra, Pre_Calculus, Survey_of_Calculus, Calculus_1} }
            };
            Course Networks = new Course
            {
                Prefix = "CSCI 4220",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Advanced_Database_Systems = new Course
            {
                Prefix = "CSCI 4320",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Database_Systems } }
            };
            Course Advanced_Software_Engineering = new Course
            {
                Prefix = "CSCI 4322",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Advanced_Operating_Systems = new Course
            {
                Prefix = "CSCI 4342",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Introduction_To_Operating_Systems } }
            };
            Course System_Prog_Under_Unix = new Course
            {
                Prefix = "CSCI 4343",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Introduction_To_Operating_Systems } }
            };
            Course Compiler_Theory = new Course
            {
                Prefix = "CSCI 4342",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Comparative_Languages } }
            };
            Course Embedded_Systems_Programming = new Course
            {
                Prefix = "CSCI 4360",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Handheld_Ubiquitous_Computing = new Course
            {
                Prefix = "CSCI 4370",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Data_Mining = new Course
            {
                Prefix = "CSCI 4535",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Database_Systems } }
            };
            Course Special_Problems_CO_OP = new Course
            {
                Prefix = "CSCI 4790",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] {}
            };
            Course Directed_Study_In_Computer_Science = new Course
            {
                Prefix = "CSCI 4890",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Data_Management_For_Math_And_The_Sciences = new Course
            {
                Prefix = "CSCI 5130",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Introduction_To_BASIC_Programming } }
            };
            Course Software_Security_And_Secure_Coding = new Course
            {
                Prefix = "CSCI 5380",
                IsCompleted = false,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 } }
            };








            List<Course> courses = new List<Course>
            {
                Composition_1,
                Composition_2,

                College_Algebra,
                Trigonometry,
                Pre_Calculus,
                Calculus_1,

                World_History_2,
                Global_Citizens,

                World_Literature_1_or_2,
                Public_Speaking,

                Principles_of_Chemistry_1_with_lab,
                Introduction_to_the_Earth,
                Introduction_to_Physics_1,
                Principles_of_Physics_1,

                Environmental_Biology_with_lab,
                Chemistry_and_the_Environment_with_lab,
                Environment_Geology_with_lab,
                Environment_Physics_with_lab,

                Economics_in_a_Global_Society,
                US_A_Comprehensive_Survey,
                American_Government,

                Introduction_to_Anthropology,
                World_Regional_Geography,
                Introduction_to_Phychology,
                Introduction_to_Sociology,

                Healthful_Living,
                Physical_Activity_1,
                Physical_Activity_2,
                First_Year_Experience,

                Programming_Principles_1,
                Programming_Principles_2,
                Computers_Ethics_and_Society,
                Discrete_Math,
                Calculus_2,

                Introduction_To_International_Studies,

                Principles_Of_Biology_2_With_Lab,
                Principles_Of_Chemistry_2_With_Lab,
                General_Historical_Geology_With_Lab,
                Introduction_to_Physics_2_with_Lab,
                Principles_of_Physics_2,

                Data_Structures,
                Systems_Software,
                Theoretical_Foundations,
                Database_Systems,
                Algorithm_Design_and_Analysis,
                Computer_Architecture,
                Data_Communications_And_Networking,
                Object_Oriented_Design,
                Computer_Security,
                Distributed_Web_Systems_Design,
                Software_Engineering,

                Logic_Circuit_Design,
                Logic_Circuits_and_Microprocessors,
                Data_Warehouse_Design,
                Human_Computer_Interaction,
                Game_Programming,
                Software_Testing_and_Quality_Assurance,
                Broadband_Networks,
                Optical_Networks,
                Selected_Topics,
                Discrete_Simulation,
                Artificial_Intelligence,
                Computer_Graphics,
                Animation,
                Systems_and_Software_Assurance,
                Network_Management_Systems,
                Wireless_and_Mobile_Systems,

                Introduction_To_Operating_Systems,
                Comparative_Languages,
                Machine_Learning,

                ////https://catalog.georgiasouthern.edu/academics/course-descriptions/csci/
                Comp_App_For_Bus_Majors,
                Introduction_To_BASIC_Programming,
                Introduction_To_Java_Programming,
                Cpp_Programming,
                High_Performance_Computing,
                Networks,
                Advanced_Database_Systems,
                Advanced_Software_Engineering,
                Advanced_Operating_Systems,
                System_Prog_Under_Unix,
                Compiler_Theory,
                Embedded_Systems_Programming,
                Handheld_Ubiquitous_Computing,
                Numerical_Analysis,
                Data_Mining,
                Special_Problems_CO_OP,
                Directed_Study_In_Computer_Science,
                Data_Management_For_Math_And_The_Sciences,
                Discrete_Simulation,
                Software_Security_And_Secure_Coding
            };

            List<Course> eligible_courses = startForwardChaining(nextSemester, courses);
            foreach (Course c in eligible_courses) Console.WriteLine("Eligible to take next semester: " + c.Prefix);
        }

        public List<Course> startForwardChaining(int nextSemester, List<Course> courses)
        {
            List<Course> eligible_to_take = new List<Course>();

            if (nextSemester == 1)
            {
                courses.ForEach(course =>
                {
                    if (course.Spring == true)
                    {
                        //Console.WriteLine("Course: " + course.Prefix + " is available in the spring!");
                        if (!course.IsCompleted)
                        {
                            //Console.WriteLine("Course: " + course.Prefix + " is not taken yet!");
                            //bool FINALELIGIBLE = false;
                            if (course.Prereqs.Length != 0)
                            {
                                //Console.WriteLine("Course: " + course.Prefix + " has the follow prereqs: ");

                                //CHECK ALL PREREQS
                                bool ANDeligible = true;
                                for (int i = 0; i < course.Prereqs.Length; i++)
                                {
                                    //bool OReligible = true;
                                    // OR OR OR OR OR OR OR 
                                    if (course.Prereqs[i].Length > 1)
                                    {
                                        bool OReligible = false;
                                        //Console.WriteLine("Course requires one of these to be taken: ");
                                        //CHECK THE ORS
                                        for (int j = 0; j < course.Prereqs[i].Length; j++)
                                        {
                                            //Console.WriteLine("Option: " + course.Prereqs[i][j].Prefix);
                                            if (course.Prereqs[i][j].IsCompleted) OReligible = true;
                                        }
                                        if (OReligible)
                                        {
                                            // Console.WriteLine("Condition satisfied! (One of those courses is taken!)");
                                        }
                                        else
                                        {
                                            ANDeligible = false;
                                            // Console.WriteLine("Oh no! (One of those courses is not taken)");
                                        }
                                    }
                                    //AND AND AND AND
                                    else
                                    {
                                        // Console.WriteLine("Must take: " + course.Prereqs[i][0].Prefix);
                                        if (course.Prereqs[i][0].IsCompleted)
                                        {
                                            //Console.WriteLine("Condition satisfied! (That course is taken)");
                                        }
                                        else
                                        {
                                            ANDeligible = false;
                                            //Console.WriteLine("Oh no! (That course is not taken)");
                                        }
                                    }
                                }
                                if (ANDeligible) eligible_to_take.Add(course);
                            }
                            else
                            {
                                //Console.WriteLine("You are eligible to take: " + course.Prefix + "!");
                                eligible_to_take.Add(course);
                            }

                        }
                    }
                    else
                    {
                        //Console.WriteLine("Course: " + course.Prefix + " is not available in the spring!");
                    }

                });
            }
            else if (nextSemester == 2)
            {
                courses.ForEach(course =>
                {
                    if (course.Summer == true)
                    {
                        //Console.WriteLine("Course: " + course.Prefix + " is available in the spring!");
                        if (!course.IsCompleted)
                        {
                            //Console.WriteLine("Course: " + course.Prefix + " is not taken yet!");
                            //bool FINALELIGIBLE = false;
                            if (course.Prereqs.Length != 0)
                            {
                                //Console.WriteLine("Course: " + course.Prefix + " has the follow prereqs: ");

                                //CHECK ALL PREREQS
                                bool ANDeligible = true;
                                for (int i = 0; i < course.Prereqs.Length; i++)
                                {
                                    //bool OReligible = true;
                                    // OR OR OR OR OR OR OR 
                                    if (course.Prereqs[i].Length > 1)
                                    {
                                        bool OReligible = false;
                                        //Console.WriteLine("Course requires one of these to be taken: ");
                                        //CHECK THE ORS
                                        for (int j = 0; j < course.Prereqs[i].Length; j++)
                                        {
                                            //Console.WriteLine("Option: " + course.Prereqs[i][j].Prefix);
                                            if (course.Prereqs[i][j].IsCompleted) OReligible = true;
                                        }
                                        if (OReligible)
                                        {
                                            // Console.WriteLine("Condition satisfied! (One of those courses is taken!)");
                                        }
                                        else
                                        {
                                            ANDeligible = false;
                                            // Console.WriteLine("Oh no! (One of those courses is not taken)");
                                        }
                                    }
                                    //AND AND AND AND
                                    else
                                    {
                                        // Console.WriteLine("Must take: " + course.Prereqs[i][0].Prefix);
                                        if (course.Prereqs[i][0].IsCompleted)
                                        {
                                            //Console.WriteLine("Condition satisfied! (That course is taken)");
                                        }
                                        else
                                        {
                                            ANDeligible = false;
                                            //Console.WriteLine("Oh no! (That course is not taken)");
                                        }
                                    }
                                }
                                if (ANDeligible) eligible_to_take.Add(course);
                            }
                            else
                            {
                                //Console.WriteLine("You are eligible to take: " + course.Prefix + "!");
                                eligible_to_take.Add(course);
                            }

                        }
                    }
                    else
                    {
                        //Console.WriteLine("Course: " + course.Prefix + " is not available in the spring!");
                    }

                });
            }

            //Normally would just be "else" instead of "else if" but we need to make sure the condition doesn't equal 0
            else if (nextSemester == 3)
            {
                courses.ForEach(course =>
                {
                    if (course.Fall == true)
                    {
                        //Console.WriteLine("Course: " + course.Prefix + " is available in the spring!");
                        if (!course.IsCompleted)
                        {
                            //Console.WriteLine("Course: " + course.Prefix + " is not taken yet!");
                            //bool FINALELIGIBLE = false;
                            if (course.Prereqs.Length != 0)
                            {
                                //Console.WriteLine("Course: " + course.Prefix + " has the follow prereqs: ");

                                //CHECK ALL PREREQS
                                bool ANDeligible = true;
                                for (int i = 0; i < course.Prereqs.Length; i++)
                                {
                                    //bool OReligible = true;
                                    // OR OR OR OR OR OR OR 
                                    if (course.Prereqs[i].Length > 1)
                                    {
                                        bool OReligible = false;
                                        //Console.WriteLine("Course requires one of these to be taken: ");
                                        //CHECK THE ORS
                                        for (int j = 0; j < course.Prereqs[i].Length; j++)
                                        {
                                            //Console.WriteLine("Option: " + course.Prereqs[i][j].Prefix);
                                            if (course.Prereqs[i][j].IsCompleted) OReligible = true;
                                        }
                                        if (OReligible)
                                        {
                                            // Console.WriteLine("Condition satisfied! (One of those courses is taken!)");
                                        }
                                        else
                                        {
                                            ANDeligible = false;
                                            // Console.WriteLine("Oh no! (One of those courses is not taken)");
                                        }
                                    }
                                    //AND AND AND AND
                                    else
                                    {
                                        // Console.WriteLine("Must take: " + course.Prereqs[i][0].Prefix);
                                        if (course.Prereqs[i][0].IsCompleted)
                                        {
                                            //Console.WriteLine("Condition satisfied! (That course is taken)");
                                        }
                                        else
                                        {
                                            ANDeligible = false;
                                            //Console.WriteLine("Oh no! (That course is not taken)");
                                        }
                                    }
                                }
                                if (ANDeligible) eligible_to_take.Add(course);
                            }
                            else
                            {
                                //Console.WriteLine("You are eligible to take: " + course.Prefix + "!");
                                eligible_to_take.Add(course);
                            }

                        }
                    }
                    else
                    {
                        //Console.WriteLine("Course: " + course.Prefix + " is not available in the spring!");
                    }

                });
            }
            return eligible_to_take;
        }

        public class Course
        {
            //ex: ENGL 1101
            public string Prefix
            {
                get;
                set;
            }
            public bool hasPreReqs
            {
                get;
                set;
            }

            //True = Student passed with C or better ---- False = Student did not take or did not pass the course
            public bool IsCompleted
            {
                get;
                set;
            }

            //We might need this for output query of available classes to be taken for that term after rules are triggered and we change this value accordingly in the loops
            public bool IsAvailable
            {
                get;
                set;
            }

            //booleans for terms the course is offered (all seperate in order to account for classes being offered during multiple terms)
            public bool Fall
            {
                get;
                set;
            }

            public bool Summer
            {
                get;
                set;
            }

            public bool Spring
            {
                get;
                set;
            }

            public bool OnDemand
            {
                get;
                set;
            }

            //Outer elements are ANDed together, inner elements are ORed together
            public Course[][] Prereqs
            {
                get;
                set;
            }


            //To string method for returning info to the user about the status of this course
            public new string ToString()
            {
                if (this.IsCompleted)
                {
                    return Prefix + " has been passed with a C or better";
                }
                else
                {
                    return Prefix + " has either not been taken, or not been passed with a C or better";
                }
            }
        }


        public class Rule
        {
            public string Source
            {
                get;
                set;
            }

            public ExpressionType Operator
            {
                get;
                set;
            }

            public string Target
            {
                get;
                set;
            }

            public Rule(string Source, ExpressionType Operator, string Target)
            {
                this.Source = Source;
                this.Operator = Operator;
                this.Target = Target;
            }
        }

        public class User
        {
            public int Age
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
