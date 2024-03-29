﻿using System;
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
        List<Course> courses = null;
        List<Course> customCourses = null;
        List<Panel> listpanel = new List<Panel>();
        int pageIndex = 0;
        //1 = Spring, 2 = Summer, 3 = Fall
        int nextSemester = 0;

        public Form1()
        {
            InitializeComponent();

            //Maybe have radio button for which term the student is looking to take classes for
            //For now we will look for Spring

        }

        public void compileCourses()
        {

            if (springbtn.Checked) nextSemester = 1;
            if (summerbtn.Checked) nextSemester = 2;
            if (fallbtn.Checked) nextSemester = 3;


            //Course List set to IsCompleted = false by default
            Course Healthful_Living = new Course
            {
                Prefix = "HLTH 1520",
                IsCompleted = Healthful_Livingcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Physical_Activity_1 = new Course
            {
                Prefix = "KINS 1XXX",
                IsCompleted = Physical_Activity_1cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Physical_Activity_2 = new Course
            {
                Prefix = "KINS 1XXX",
                IsCompleted = Physical_Activity_2cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course First_Year_Experience = new Course
            {
                Prefix = "FYE 1220",
                IsCompleted = First_Year_Experiencecb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };

            Course Composition_1 = new Course
            {
                Prefix = "ENGL 1101",
                IsCompleted = Composition_1cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Composition_2 = new Course
            {
                Prefix = "ENGL 1102",
                IsCompleted = Composition_2cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Composition_1 } }
            };
            Course College_Algebra = new Course
            {
                Prefix = "MATH 1111",
                IsCompleted = College_Algebracb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Trigonometry = new Course
            {
                Prefix = "MATH 1112",
                IsCompleted = Trigonometrycb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { College_Algebra } }
            };
            Course Pre_Calculus = new Course
            {
                Prefix = "MATH 1113",
                IsCompleted = Pre_Calculuscb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { College_Algebra } }
            };
            Course Calculus_1 = new Course
            {
                Prefix = "MATH 1441",
                IsCompleted = Calculus_1cb.Checked,
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
                IsCompleted = Quantitative_Reasoningcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_To_Mathematical_Modeling = new Course
            {
                Prefix = "MATH 1101",
                IsCompleted = Introduction_To_Mathematical_Modelingcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Survey_of_Calculus = new Course
            {
                Prefix = "MATH 1232",
                IsCompleted = Survey_of_Calculuscb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Introduction_To_Mathematical_Modeling, College_Algebra, Trigonometry, Pre_Calculus } }
            };
            Course Elementary_Statistics = new Course
            {
                Prefix = "STAT 1401",
                IsCompleted = Elementary_Statisticscb.Checked,
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
                IsCompleted = World_History_2cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Global_Citizens = new Course
            {
                Prefix = "FYE 1410",
                IsCompleted = Global_Citizenscb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { First_Year_Experience } }
            };

            Course World_Literature_1_or_2 = new Course
            {
                Prefix = "ENGL 2111/2112",
                IsCompleted = World_Literature_1_or_2cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Composition_2 } }
            };
            Course Public_Speaking = new Course
            {
                Prefix = "COMM 1110",
                IsCompleted = Public_Speakingcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Composition_1 } }
            };

            Course Principles_of_Chemistry_1_with_lab = new Course
            {
                Prefix = "CHEM 1211K",
                IsCompleted = Principles_of_Chemistry_1_with_labcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_to_the_Earth = new Course
            {
                Prefix = "GEOL 1121",
                IsCompleted = Introduction_to_the_Earthcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_to_Physics_1 = new Course
            {
                Prefix = "PHYS 1111K",
                IsCompleted = Introduction_to_Physics_1cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Pre_Calculus, Trigonometry } }
            };
            Course Principles_of_Physics_1 = new Course
            {
                Prefix = "PHYS 2211K",
                IsCompleted = Principles_of_Physics_1cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Calculus_1 } }
            };

            Course Environmental_Biology_with_lab = new Course
            {
                Prefix = "BIOL 1230 & 1210",
                IsCompleted = Environmental_Biology_with_labcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Chemistry_and_the_Environment_with_lab = new Course
            {
                Prefix = "CHEM 1040",
                IsCompleted = Chemistry_and_the_Environment_with_labcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Environment_Geology_with_lab = new Course
            {
                Prefix = "GEOL 1340",
                IsCompleted = Environment_Geology_with_labcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Environment_Physics_with_lab = new Course
            {
                Prefix = "PHYS 1149",
                IsCompleted = Environment_Physics_with_labcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };

            Course Economics_in_a_Global_Society = new Course
            {
                Prefix = "ECON 2105",
                IsCompleted = Economics_in_a_Global_Societycb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course US_A_Comprehensive_Survey = new Course
            {
                Prefix = "HIST 2110",
                IsCompleted = US_A_Comprehensive_Surveycb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course American_Government = new Course
            {
                Prefix = "POLS 1101",
                IsCompleted = American_Governmentcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_to_Anthropology = new Course
            {
                Prefix = "ANTH 1102",
                IsCompleted = Introduction_to_Anthropologycb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course World_Regional_Geography = new Course
            {
                Prefix = "GEOG 1130",
                IsCompleted = World_Regional_Geographycb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_to_Phychology = new Course
            {
                Prefix = "PSYC 1101",
                IsCompleted = Introduction_to_Phychologycb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };
            Course Introduction_to_Sociology = new Course
            {
                Prefix = "SOCI 1101",
                IsCompleted = Introduction_to_Sociologycb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { }
            };

            Course Programming_Principles_1 = new Course
            {
                Prefix = "CSCI 1301",
                IsCompleted = Programming_Principles_1cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Calculus_1 } }
            };
            Course Calculus_2 = new Course
            {
                Prefix = "MATH 2242",
                IsCompleted = Calculus_2cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Calculus_1 } }
            };
            Course Discrete_Math = new Course
            {
                Prefix = "MATH 2130",
                IsCompleted = Discrete_Mathcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Introduction_To_Mathematical_Modeling, College_Algebra, Trigonometry, Pre_Calculus, Calculus_1, Calculus_2 } }
            };
            Course Programming_Principles_2 = new Course
            {
                Prefix = "CSCI 1302",
                IsCompleted = Programming_Principles_2cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_1 }, new Course[] { Discrete_Math }, new Course[] { Calculus_1 } }
            };
            Course Statistics_1 = new Course
            {
                Prefix = "STAT 2231",
                IsCompleted = Statistics_1cb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { College_Algebra, Trigonometry, Pre_Calculus, Calculus_1 } }
            };
            Course Linear_Algebra = new Course
            {
                Prefix = "MATH 2160",
                IsCompleted = Linear_Algebracb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Calculus_2 } }
            };
            Course Computers_Ethics_and_Society = new Course
            {
                Prefix = "CSCI 2120",
                IsCompleted = Computers_Ethics_and_Societycb.Checked,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_1 }, new Course[] { Public_Speaking } }
            };

            Course Introduction_To_International_Studies = new Course
            {
                Prefix = "INTS 2130",
                IsCompleted = Introduction_to_International_Studiescb.Checked,
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
                IsCompleted = Principles_Of_Biology_1_With_Labcb.Checked,
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
                IsCompleted = Principles_of_Biology_2_with_labcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Principles_Of_Biology_1_With_Lab } }
            };
            Course Principles_Of_Chemistry_2_With_Lab = new Course
            {
                Prefix = "CHEM 1212K",
                IsCompleted = Principles_of_Chemistry_2_with_labcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Principles_of_Chemistry_1_with_lab } }
            };
            Course General_Historical_Geology_With_Lab = new Course
            {
                Prefix = "GEOL 1122",
                IsCompleted = General_Historal_Geology_with_labcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Introduction_to_the_Earth } }
            };
            Course Introduction_to_Physics_2_with_Lab = new Course
            {
                Prefix = "PHYS 1112K",
                IsCompleted = Introduction_to_Physics_2_with_labcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Introduction_to_Physics_1 } }
            };
            Course Principles_of_Physics_2 = new Course
            {
                Prefix = "PHYS 2212K",
                IsCompleted = Principles_of_Physics_2cb.Checked,
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
                IsCompleted = Data_Structurescb.Checked,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 }, new Course[] { Discrete_Math } }
            };
            Course Systems_Software = new Course
            {
                Prefix = "CSCI 3232",
                IsCompleted = Systems_Softwarecb.Checked,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 } } //concurrent or prior DS
            };
            Course Cpp_Programming = new Course
            {
                Prefix = "CSCI 2490",
                IsCompleted = Cpp_Programmingcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 } }
            };
            Course Introduction_To_Operating_Systems = new Course
            {
                Prefix = "CSCI 3341",
                IsCompleted = Introduction_to_Operating_Systemcb.Checked,
                Fall = true,
                Summer = false,
                Spring = false,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Data_Structures }, new Course[] { Cpp_Programming } }
            };
            Course Theoretical_Foundations = new Course
            {
                Prefix = "CSCI 3236",
                IsCompleted = Theoretical_Foundationscb.Checked,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 }, new Course[] { Discrete_Math } }
            };
            Course Database_Systems = new Course
            {
                Prefix = "CSCI 3432",
                IsCompleted = Database_Systemscb.Checked,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_1 }, new Course[] { Discrete_Math } }
            };
            Course Algorithm_Design_and_Analysis = new Course
            {
                Prefix = "CSCI 5330",
                IsCompleted = Algorithm_Design_and_Analysiscb.Checked,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Theoretical_Foundations }, new Course[] { Calculus_2 } }
            };
            Course Computer_Architecture = new Course
            {
                Prefix = "CSCI 5331",
                IsCompleted = Computer_Architecturecb.Checked,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Systems_Software, Introduction_To_Operating_Systems } }
            };
            Course Data_Communications_And_Networking = new Course
            {
                Prefix = "CSCI 5332",
                IsCompleted = Data_Comm_and_Networkingcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Systems_Software, Introduction_To_Operating_Systems }, new Course[] { Elementary_Statistics } }
            };
            Course Object_Oriented_Design = new Course
            {
                Prefix = "CSCI 5335",
                IsCompleted = Object_Oriented_Designcb.Checked,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Data_Structures } }
            };
            Course Computer_Security = new Course
            {
                Prefix = "CSCI 5431",
                IsCompleted = Computer_Securitycb.Checked,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Computers_Ethics_and_Society } }
            };
            Course Distributed_Web_Systems_Design = new Course
            {
                Prefix = "CSCI 5436",
                IsCompleted = Distributed_Web_Systems_Designcb.Checked,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Database_Systems } }
            };
            Course Software_Engineering = new Course
            {
                Prefix = "CSCI 5530",
                IsCompleted = Software_Engineeringcb.Checked,
                Fall = true,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Algorithm_Design_and_Analysis }, new Course[] { Object_Oriented_Design }, new Course[] { Database_Systems } }
            };
            Course Computing_for_Engineers = new Course
            {
                Prefix = "ENGR 1731",
                IsCompleted = Computing_for_Engineerscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Calculus_1 } }
            };
            Course Logic_Circuit_Design = new Course
            {
                Prefix = "ENGR 2332",
                IsCompleted = Introduction_to_Computer_Engineeringcb.Checked,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Computing_for_Engineers } }
            };
            Course Logic_Circuits_and_Microprocessors = new Course
            {
                Prefix = "CSCI 3231",
                IsCompleted = Logic_Circuits_and_Microprocessorscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 } }
            };
            Course Comparative_Languages = new Course
            {
                Prefix = "CSCI 3330",
                IsCompleted = Comparative_Languagescb.Checked,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Cpp_Programming } }
            };
            Course Data_Warehouse_Design = new Course
            {
                Prefix = "CSCI 4132",
                IsCompleted = Data_Warehouse_Designcb.Checked,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Database_Systems } }
            };
            Course High_Performance_Computing = new Course
            {
                Prefix = "CSCI 4210",
                IsCompleted = High_Performance_Computingcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Introduction_To_Operating_Systems } }
            };
            Course Human_Computer_Interaction = new Course
            {
                Prefix = "CSCI 4235",
                IsCompleted = Human_Computer_Interactioncb.Checked,
                Fall = true,
                Summer = false,
                Spring = false,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Data_Structures } }
            };
            Course Game_Programming = new Course
            {
                Prefix = "CSCI 4439",
                IsCompleted = Game_Programmingcb.Checked,
                Fall = true,
                Summer = false,
                Spring = false,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 } }
            };
            Course Machine_Learning = new Course
            {
                Prefix = "CSCI 4520",
                IsCompleted = Machine_Learningcb.Checked,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Cpp_Programming }, new Course[] { Discrete_Math } }
            };
            Course Numerical_Analysis = new Course
            {
                Prefix = "CSCI 4610",
                IsCompleted = Numerical_Analysiscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_1 }, new Course[] { Calculus_2 } }
            };
            Course Software_Testing_and_Quality_Assurance = new Course
            {
                Prefix = "CSCI 4534",
                IsCompleted = Software_Testing_and_Quality_Assurancecb.Checked,
                Fall = false,
                Summer = false,
                Spring = true,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Theoretical_Foundations } }
            };
            Course Broadband_Networks = new Course
            {
                Prefix = "CSCI 4537",
                IsCompleted = Broadband_Networkscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Data_Communications_And_Networking } }
            };
            Course Optical_Networks = new Course
            {
                Prefix = "CSCI 4539",
                IsCompleted = Optical_Networkscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Data_Communications_And_Networking } }
            };
            Course Selected_Topics = new Course
            {
                Prefix = "CSCI 5090",
                IsCompleted = Selected_Topicscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Discrete_Simulation = new Course
            {
                Prefix = "CSCI 5230",
                IsCompleted = Discrete_Simulationcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Elementary_Statistics }, new Course[] { Data_Structures } }
            };
            Course Artificial_Intelligence = new Course
            {
                Prefix = "CSCI 5430",
                IsCompleted = Artificial_Intelligencecb.Checked,
                Fall = true,
                Summer = false,
                Spring = false,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Data_Structures }, new Course[] { Algorithm_Design_and_Analysis } }
            };
            Course Computer_Graphics = new Course
            {
                Prefix = "CSCI 5437",
                IsCompleted = Computer_Graphicscb.Checked,
                Fall = true,
                Summer = false,
                Spring = false,
                OnDemand = false,
                Prereqs = new Course[][] { new Course[] { Data_Structures }, new Course[] { Theoretical_Foundations } }
            };
            Course Animation = new Course
            {
                Prefix = "CSCI 5438",
                IsCompleted = Animationcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Computer_Graphics } }
            };
            Course Systems_and_Software_Assurance = new Course
            {
                Prefix = "CSCI 5531",
                IsCompleted = Systems_and_Software_Assurancecb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 }, new Course[] { Database_Systems } }
            };
            Course Network_Management_Systems = new Course
            {
                Prefix = "CSCI 5532",
                IsCompleted = Network_Management_Systemscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Data_Communications_And_Networking } }
            };
            Course Wireless_and_Mobile_Systems = new Course
            {
                Prefix = "CSCI 5538",
                IsCompleted = Wireless_and_Mobile_Systemscb.Checked,
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
                IsCompleted = Comp_App_For_Bus_Majorscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Data_Communications_And_Networking } }
            };
            Course Introduction_To_BASIC_Programming = new Course
            {
                Prefix = "CSCI 1230",
                IsCompleted = Introduction_to_BASIC_Programmingcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Introduction_To_Java_Programming = new Course
            {
                Prefix = "CSCI 1236",
                IsCompleted = Introduction_to_Java_Programmingcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { College_Algebra, Pre_Calculus, Survey_of_Calculus, Calculus_1 } }
            };
            Course Networks = new Course
            {
                Prefix = "CSCI 4220",
                IsCompleted = Networkscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Advanced_Database_Systems = new Course
            {
                Prefix = "CSCI 4320",
                IsCompleted = Advanced_Database_Systemscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Database_Systems } }
            };
            Course Advanced_Software_Engineering = new Course
            {
                Prefix = "CSCI 4322",
                IsCompleted = Advanced_Software_Engineeringcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Advanced_Operating_Systems = new Course
            {
                Prefix = "CSCI 4342",
                IsCompleted = Advanced_Operating_Systemscb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Introduction_To_Operating_Systems } }
            };
            Course System_Prog_Under_Unix = new Course
            {
                Prefix = "CSCI 4343",
                IsCompleted = System_Prog_Under_Unixcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Introduction_To_Operating_Systems } }
            };
            Course Compiler_Theory = new Course
            {
                Prefix = "CSCI 4342",
                IsCompleted = Compiler_Theorycb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Comparative_Languages } }
            };
            Course Embedded_Systems_Programming = new Course
            {
                Prefix = "CSCI 4360",
                IsCompleted = Embedded_Systems_Programmingcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Handheld_Ubiquitous_Computing = new Course
            {
                Prefix = "CSCI 4370",
                IsCompleted = Handheld_Ubiquitous_Computingcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Data_Mining = new Course
            {
                Prefix = "CSCI 4535",
                IsCompleted = Data_Miningcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Database_Systems } }
            };
            Course Special_Problems_CO_OP = new Course
            {
                Prefix = "CSCI 4790",
                IsCompleted = Special_Problems_CO_OPcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Directed_Study_In_Computer_Science = new Course
            {
                Prefix = "CSCI 4890",
                IsCompleted = Directed_Study_in_Computer_Sciencecb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { }
            };
            Course Data_Management_For_Math_And_The_Sciences = new Course
            {
                Prefix = "CSCI 5130",
                IsCompleted = Data_Management_for_Math_and_the_Sciencescb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Introduction_To_BASIC_Programming } }
            };
            Course Software_Security_And_Secure_Coding = new Course
            {
                Prefix = "CSCI 5380",
                IsCompleted = Software_Security_and_Secure_Codingcb.Checked,
                Fall = false,
                Summer = false,
                Spring = false,
                OnDemand = true,
                Prereqs = new Course[][] { new Course[] { Programming_Principles_2 } }
            };


            courses = new List<Course>
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
                Software_Security_And_Secure_Coding,

                //Other random Pre-reqs or conflicts b/w handout and current curriculuum
                Statistics_1,
                Linear_Algebra,
                Principles_Of_Biology_1_With_Lab,
                Quantitative_Reasoning,
                Introduction_To_Mathematical_Modeling,
                Survey_of_Calculus,
                Elementary_Statistics,
                Computing_for_Engineers
            };
            if (customCourses != null)
            {
                foreach (Course c in customCourses)
                {
                    ReestablishReferences(c);
                }
                foreach (Course c in customCourses)
                {
                    courses.Add(c);
                }
            }



        }

        public List<Course> startForwardChaining()
        {
            List<Course> eligible_to_take = new List<Course>();

            if (nextSemester == 1)
            {
                courses.ForEach(course =>
                {
                    if (course.Spring == true || course.OnDemand == true)
                    {
                        if (!course.IsCompleted)
                        {
                            if (course.Prereqs.Length != 0)
                            {
                                //CHECK ALL PREREQS
                                bool ANDeligible = true;
                                for (int i = 0; i < course.Prereqs.Length; i++)
                                {
                                    if (course.Prereqs[i].Length > 1)
                                    {
                                        bool OReligible = false;
                                        //CHECK THE ORS
                                        for (int j = 0; j < course.Prereqs[i].Length; j++)
                                        {
                                            //Console.WriteLine("Option: " + course.Prereqs[i][j].Prefix);
                                            if (course.Prereqs[i][j].IsCompleted) OReligible = true;
                                        }
                                        if (!OReligible)
                                        {
                                            ANDeligible = false;
                                        }
                                    }
                                    //AND AND AND AND
                                    else
                                    {
                                        if (!course.Prereqs[i][0].IsCompleted)
                                        {
                                            ANDeligible = false;
                                        }
                                    }
                                }
                                if (ANDeligible) eligible_to_take.Add(course);
                            }
                            else
                            {
                                eligible_to_take.Add(course);
                            }
                        }
                    }
                });
            }
            else if (nextSemester == 2)
            {
                courses.ForEach(course =>
                {
                    if (course.Summer == true || course.OnDemand == true)
                    {
                        if (!course.IsCompleted)
                        {
                            if (course.Prereqs.Length != 0)
                            {
                                //CHECK ALL PREREQS
                                bool ANDeligible = true;
                                for (int i = 0; i < course.Prereqs.Length; i++)
                                {
                                    // OR OR OR OR OR OR OR 
                                    if (course.Prereqs[i].Length > 1)
                                    {
                                        bool OReligible = false;
                                        //CHECK THE ORS
                                        for (int j = 0; j < course.Prereqs[i].Length; j++)
                                        {
                                            //Console.WriteLine("Option: " + course.Prereqs[i][j].Prefix);
                                            if (course.Prereqs[i][j].IsCompleted) OReligible = true;
                                        }
                                        if (!OReligible)
                                        {
                                            ANDeligible = false;
                                        }
                                    }
                                    //AND AND AND AND
                                    else
                                    {
                                        if (!course.Prereqs[i][0].IsCompleted)
                                        {
                                            ANDeligible = false;
                                        }
                                    }
                                }
                                if (ANDeligible) eligible_to_take.Add(course);
                            }
                            else
                            {
                                eligible_to_take.Add(course);
                            }
                        }
                    }
                });
            }
            //Normally would just be "else" instead of "else if" but we need to make sure the condition doesn't equal 0
            else if (nextSemester == 3)
            {
                courses.ForEach(course =>
                {
                    if (course.Fall == true || course.OnDemand == true)
                    {
                        if (!course.IsCompleted)
                        {
                            if (course.Prereqs.Length != 0)
                            {
                                //CHECK ALL PREREQS
                                bool ANDeligible = true;
                                for (int i = 0; i < course.Prereqs.Length; i++)
                                {
                                    // OR OR OR OR OR OR OR 
                                    if (course.Prereqs[i].Length > 1)
                                    {
                                        bool OReligible = false;
                                        //CHECK THE ORS
                                        for (int j = 0; j < course.Prereqs[i].Length; j++)
                                        {
                                            if (course.Prereqs[i][j].IsCompleted) OReligible = true;
                                        }
                                        if (!OReligible)
                                        {
                                            ANDeligible = false;
                                        }
                                    }
                                    //AND AND AND AND
                                    else
                                    {
                                        if (course.Prereqs[i][0].IsCompleted)
                                        {
                                            ANDeligible = false;
                                        }
                                    }
                                }
                                if (ANDeligible) eligible_to_take.Add(course);
                            }
                            else
                            {
                                eligible_to_take.Add(course);
                            }
                        }
                    }
                });
            }

            return eligible_to_take;
        }

        public List<List<Course>> startBackwardChaining(Course course_to_check)
        {
            List<List<Course>> courses_related_to_target = new List<List<Course>>();

            if (course_to_check.Spring && nextSemester == 1)
            {
                if (course_to_check.Prereqs.Length != 0)
                {
                    for (int i = 0; i < course_to_check.Prereqs.Length; i++)
                    {
                        // Gather ORS
                        if (course_to_check.Prereqs[i].Length > 1)
                        {
                            List<Course> orTemp = new List<Course>();
                            //CHECK THE ORS
                            for (int j = 0; j < course_to_check.Prereqs[i].Length; j++)
                            {
                                //Console.WriteLine("Option: " + course.Prereqs[i][j].Prefix);
                                orTemp.Add(course_to_check.Prereqs[i][j]);
                            }
                            courses_related_to_target.Add(orTemp);
                        }
                        //AND AND AND AND
                        else
                        {
                            courses_related_to_target.Add(new List<Course>() { course_to_check.Prereqs[i][0] });
                        }
                    }
                }
            }
            else if (course_to_check.Summer && nextSemester == 2)
            {
                if (course_to_check.Prereqs.Length != 0)
                {
                    for (int i = 0; i < course_to_check.Prereqs.Length; i++)
                    {
                        // Gather ORS
                        if (course_to_check.Prereqs[i].Length > 1)
                        {
                            List<Course> orTemp = new List<Course>();
                            //CHECK THE ORS
                            for (int j = 0; j < course_to_check.Prereqs[i].Length; j++)
                            {
                                //Console.WriteLine("Option: " + course.Prereqs[i][j].Prefix);
                                orTemp.Add(course_to_check.Prereqs[i][j]);
                            }
                            courses_related_to_target.Add(orTemp);
                        }
                        //AND AND AND AND
                        else
                        {
                            courses_related_to_target.Add(new List<Course>() { course_to_check.Prereqs[i][0] });
                        }
                    }
                }
            }
            else if (course_to_check.Spring && nextSemester == 3)
            {
                if (course_to_check.Prereqs.Length != 0)
                {
                    for (int i = 0; i < course_to_check.Prereqs.Length; i++)
                    {
                        // Gather ORS
                        if (course_to_check.Prereqs[i].Length > 1)
                        {
                            List<Course> orTemp = new List<Course>();
                            //CHECK THE ORS
                            for (int j = 0; j < course_to_check.Prereqs[i].Length; j++)
                            {
                                //Console.WriteLine("Option: " + course.Prereqs[i][j].Prefix);
                                orTemp.Add(course_to_check.Prereqs[i][j]);
                            }
                            courses_related_to_target.Add(orTemp);
                        }
                        //AND AND AND AND
                        else
                        {
                            courses_related_to_target.Add(new List<Course>() { course_to_check.Prereqs[i][0] });
                        }
                    }
                }
            }
            else if (course_to_check.OnDemand)
            {
                for (int i = 0; i < course_to_check.Prereqs.Length; i++)
                {
                    // Gather ORS
                    if (course_to_check.Prereqs[i].Length > 1)
                    {
                        List<Course> orTemp = new List<Course>();
                        //CHECK THE ORS
                        for (int j = 0; j < course_to_check.Prereqs[i].Length; j++)
                        {
                            //Console.WriteLine("Option: " + course.Prereqs[i][j].Prefix);
                            orTemp.Add(course_to_check.Prereqs[i][j]);
                        }
                        courses_related_to_target.Add(orTemp);
                    }
                    //AND AND AND AND
                    else
                    {
                        courses_related_to_target.Add(new List<Course>() { course_to_check.Prereqs[i][0] });
                    }
                }
            }


            return courses_related_to_target;
        }

        public class Course
        {
            //ex: ENGL 1101
            public string Prefix
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
                if (!IsCompleted)
                {
                    return Prefix + " has either not been taken, or not been passed with a C or better";
                }
                else
                {
                    return Prefix + " has been passed with a C or better";
                }
            }
        }

        //Fixing custom class references
        public void ReestablishReferences(Course c)
        {
            if (c.Prereqs.Length > 0)
            {
                for (int i = 0; i < c.Prereqs.Length; i++)
                {
                    if (c.Prereqs[i].Length > 0)
                    {
                        for (int k = 0; k < c.Prereqs[i].Length; k++)
                        {
                            for (int j = 0; j < courses.Count; j++)
                            {
                                if (courses[j].Prefix == c.Prereqs[i][k].Prefix)
                                    c.Prereqs[i][k] = courses[j];
                            }
                        }
                    }

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listpanel.Add(HomePanel);
            listpanel.Add(AreaAPanel);
            listpanel.Add(AreaBPanel);
            listpanel.Add(AreaCPanel);
            listpanel.Add(AreaDPanel);
            listpanel.Add(AreaEPanel);
            listpanel.Add(URPanel);
            listpanel.Add(AreaFPanel);
            listpanel.Add(SIRPanel);
            listpanel.Add(SLSsRPanel);
            listpanel.Add(MRC1Panel);
            listpanel.Add(MRC2Panel);
            listpanel.Add(E1Panel);
            listpanel.Add(E2Panel);
            listpanel.Add(CustomClassesPanel);
            listpanel.Add(SeasonPanel);
            listpanel.Add(ChainingPanel);
            listpanel.Add(EligibleCoursesPanel);
            listpanel.Add(CanTakePanel);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            compileCourses();
            List<Course> eligible_courses = startForwardChaining();
            List<Course> confirmed_courses = new List<Course>();
            List<Course> on_demand_courses = new List<Course>();

            foreach (Course c in eligible_courses)
            {
                if (c.OnDemand) on_demand_courses.Add(c);
                else confirmed_courses.Add(c);
            }

            string result = "Eligible to take next semester: ";
            foreach (Course c in eligible_courses)
            {
                result += Environment.NewLine;
                result += c.Prefix;
            }
            result += Environment.NewLine;
            result += Environment.NewLine;

            result += "These Courses may be available on demand: ";
            foreach (Course c in on_demand_courses)
            {
                result += Environment.NewLine;
                result += c.Prefix;
            }
            Eligible_CoursesTxt.Text = result;
            forward_Click(sender, e);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            
            compileCourses();
            backwardcbb.Items.Clear();
            foreach (Course c in courses)
            {
                backwardcbb.Items.Add(c.Prefix);
            }
            pageIndex += 2;
            listpanel[pageIndex].BringToFront();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (pageIndex < listpanel.Count - 1)
            {
                listpanel[++pageIndex].BringToFront();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (pageIndex > 0)
            {
                listpanel[--pageIndex].BringToFront();
            }

        }

        private void button36_Click(object sender, EventArgs e)
        {
            clearCustom();
            pageIndex = 0;
            listpanel[0].BringToFront();
        }

        private void clearCustom()
        {
            prereqscbb.Text = "";
            customPrefixtxt.Text = "";
            customPrereqstxt.Text = "";
            ORtxt.Text = "";
            customNametxt.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            customPrereqstxt.Text = "";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            compileCourses();
            prereqscbb.Items.Clear();
            foreach (Course c in courses)
            {
                prereqscbb.Items.Add(c.Prefix);
            }
            CreateCoursePanel.BringToFront();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            ORtxt.Text = "";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            string result = "[";
            result += ORtxt.Text;
            result = result.Replace("\r\n", ",");
            result = result.Remove(result.Length - 1);
            result += "]\r\n";
            customPrereqstxt.AppendText(result);
            ORtxt.Text = "";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            customPrereqstxt.Text += prereqscbb.Text;
            customPrereqstxt.Text += Environment.NewLine;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            ORtxt.Text += prereqscbb.Text;
            ORtxt.Text += Environment.NewLine;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void seasonbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                checkBox4.Checked = false;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearCustom();
        }


        //Create Custom Class
        private void button35_Click(object sender, EventArgs e)
        {
            if (customCourses == null)
            {
                customCourses = new List<Course>();
            }

            string strtext = customPrereqstxt.Text;
            customClassesBox.Items.Add(customNametxt.Text);
            var textArr = strtext.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            Course[][] temp = new Course[textArr.Length][];
            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i].StartsWith("["))
                {
                    textArr[i] = textArr[i].Remove(0, 1);
                    textArr[i] = textArr[i].Remove(textArr[i].Length - 1);
                    var sepCommas = textArr[i].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    Course[] or = new Course[sepCommas.Length];
                    for (int p = 0; p < sepCommas.Length; p++)
                    {


                        for (int c = 0; c < courses.Count; c++)
                        {
                            if (courses[c].Prefix == sepCommas[p])
                            {
                                or[p] = courses[c];
                            }
                        }
                    }
                    temp[i] = or;
                }
                else
                {
                    for (int c = 0; c < courses.Count; c++)
                    {

                        if (courses[c].Prefix == textArr[i])
                        {
                            temp[i] = new Course[] { courses[c] };
                        }
                    }
                }
            }

            Course custom = new Course
            {
                Prefix = customPrefixtxt.Text,
                IsCompleted = Software_Security_and_Secure_Codingcb.Checked,
                Fall = checkBox3.Checked,
                Summer = checkBox2.Checked,
                Spring = checkBox1.Checked,
                OnDemand = checkBox4.Checked,
                Prereqs = temp
            };


            customCourses.Add(custom);
            clearCustom();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            pageIndex -= 2;
            listpanel[pageIndex].BringToFront();
        }

        private void checkEliBtn_Click(object sender, EventArgs e)
        {
            if (backwardcbb.SelectedItem != null)
            {
                Course course_to_check = courses.Find(x => x.Prefix == ((string)backwardcbb.SelectedItem));      //Get course from UI here
                List<List<Course>> reasoningList = startBackwardChaining(course_to_check);
                bool isEligible = true;
                if (reasoningList.Count != 0)
                {
                    for (int i = 0; i < reasoningList.Count; i++)
                    {
                        //Check OR Conditions
                        if (reasoningList[i].Count > 1)
                        {
                            bool OReligible = false;
                            //CHECK THE ORS
                            for (int j = 0; j < reasoningList[i].Count; j++)
                            {                                    
                                if (reasoningList[i][j].IsCompleted) OReligible = true;
                            }
                            if (!OReligible)
                            {
                                isEligible = false;
                            }
                        }
                        //Check And conditions
                        else
                        {
                            if (!reasoningList[i][0].IsCompleted)
                            {
                                isEligible = false;
                            }
                        }
                    }
                }

                string s = "";
                if (isEligible)
                {
                    s += "You are eligible to take: " + course_to_check.Prefix;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += "You satisfy these pre-requisite requirements: ";
                }
                else
                {
                    s += "You are NOT eligible to take: " + course_to_check.Prefix;
                    s += Environment.NewLine;
                    s += Environment.NewLine;
                    s += "To be eligible for this course you must satisfy these pre-requisite requirements: ";
                }

                s += Environment.NewLine;
                for(int i =0; i < reasoningList.Count; i++)
                {
                    if (reasoningList[i].Count > 1)
                    {
                        s += "[";                     
                        for (int j = 0; j < reasoningList[i].Count; j++)
                        {
                            s+= reasoningList[i][j].Prefix;
                            if (j != (reasoningList[i].Count - 1)) s += " OR "; 
                        }
                        s += "]";
                        s += Environment.NewLine;
                    }
                    else
                    {
                        s += reasoningList[i][0].Prefix;
                        s += Environment.NewLine;
                    }
                }
                resulttxt.Text = s;
                

            }

        }
    }
}
