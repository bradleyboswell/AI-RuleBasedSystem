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
            /*
            //TEST EXAMPLE TEST EXAMPLE TEST EXAMPLE TEST EXAMPLE TEST EXAMPLE TEST EXAMPLE TEST EXAMPLE TEST EXAMPLE TEST EXAMPLE TEST EXAMPLE TEST EXAMPLE TEST EXAMPLE 
            //
            List<Rule> rules = new List<Rule>
                { new Rule("Age", ExpressionType.GreaterThan, "20"), new Rule("Name", ExpressionType.Equal, "John")};

            var user1 = new User{
                Age = 13,
                Name = "royi"
            };

            var user2 = new User{
                Age = 21,
                Name = "John"
            };

            var user3 = new User{
                Age = 53,
                Name = "paul"
            };

            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);

            var compiledRules = PreCompileRuleSet(new List<User>(), rules);
            
            
            users.ForEach(user => 
            {

                if (compiledRules.TakeWhile(r => r(user)).Count() > 0)             //this is set to 1 because there are two rules that must be satisfied (how do we figure out which rule was satisfied from this?)
                {                   
                    Console.WriteLine("User: "+user.Name+" Satisfied all rules in the list!");
                }
                else
                {
                    Console.WriteLine("User: "+user.Name+" Did not satisfy all rules in the list!");
                }

            });
            
            //END TEST EXAMPLE END TEST EXAMPLE END TEST EXAMPLE END TEST EXAMPLE END TEST EXAMPLE END TEST EXAMPLE END TEST EXAMPLE END TEST EXAMPLE END TEST EXAMPLE END TEST EXAMPLE END TEST EXAMPLE 
            */

            //Maybe have radio button for which term the student is looking to take classes for
            //For now we will look for Spring
            bool NextFall = false;
            bool NextSpring = true;
            bool NextSummer = false;


            //Course List set to IsCompleted = false by default
            Course Composition_1 = new Course
            {
                Prefix = "ENGL 1101",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };
            Course Composition_2 = new Course
            {
                Prefix = "ENGL 1102",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { Composition_1 } }
            };
            Course College_Algebra = new Course
            {
                Prefix = "MATH 1111",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };
            Course Trigonometry = new Course
            {
                Prefix = "MATH 1112",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { College_Algebra } }
            };
            Course Pre_Calculus = new Course
            {
                Prefix = "MATH 1113",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { Trigonometry } }
            };
            Course Calculus_1 = new Course
            {
                Prefix = "MATH 1441",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { Pre_Calculus, Trigonometry } }
            };
            Course World_History_2 = new Course
            {
                Prefix = "HIST 1112",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { {  } }
            };

            Course Gloabl_Citizens = new Course
            {
                Prefix = "FYE 1410",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course World_Literature_1_or_2 = new Course
            {
                Prefix = "ENGL 2111/2112",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { Composition_2 } }
            };

            Course Public_Speaking = new Course
            {
                Prefix = "COMM 1110",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { Composition_1 } }
            };

            Course Principles_of_Chemistry_1_with_lab = new Course
            {
                Prefix = "CHEM 1211K",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { {  } }
            };

            Course Introduction_to_the_Earth = new Course
            {
                Prefix = "GEOL 1121",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Introduction_to_Physics_1 = new Course
            {
                Prefix = "PHYS 1111 K",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { Trigonometry, Pre_Calculus } }
            };

            Course Principles_of_Physics_1 = new Course
            {
                Prefix = "PHYS 2211K",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { Calculus_1 } }
            };

            Course Environmental_Biology_with_lab = new Course
            {
                Prefix = "BIOL 1230 & 1210",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { {  } }
            };

            Course Chemistry_and_the_Environment_with_lab = new Course
            {
                Prefix = "CHEM 1040",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Environment_Geology_with_lab = new Course
            {
                Prefix = "GEOL 1340",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Environment_Physics_with_lab = new Course
            {
                Prefix = "PHYS 1149",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Economics_in_a_Global_Society = new Course
            {
                Prefix = "ECON 2105",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course US_A_Comprehensive_Survey = new Course
            {
                Prefix = "HIST 2110",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course American_Government = new Course
            {
                Prefix = "POLS 1101",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Introduction_to_Anthropology = new Course
            {
                Prefix = "ANTH 1102",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course World_Regional_Geography = new Course
            {
                Prefix = "GEOG 1130",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Introduction_to_Phychology = new Course
            {
                Prefix = "PSYC 1101",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Introduction_to_Sociology = new Course
            {
                Prefix = "SOCI 1101",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Healthful_Living = new Course
            {
                Prefix = "HLTH 1520",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Physical_Activity_1 = new Course
            {
                Prefix = "KINS 1XXX",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Physical_Activity_2 = new Course
            {
                Prefix = "KINS 1XXX",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course First_Year_Experience = new Course
            {
                Prefix = "FYE 1220",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { } }
            };

            Course Statistics_1 = new Course
            {
                Prefix = "STAT 2231",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { College_Algebra, Trigonometry, Pre_Calculus, Calculus_1 } }
            };

            Course Programming_Principles_1 = new Course
            {
                Prefix = "CSCI 1301",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { Calculus_1 } }
            };

            Course Computers_Ethics_and_Society = new Course
            {
                Prefix = "CSCI 2120",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { Programming_Principles_1 } }
            };

            Course Programming_Principles_2 = new Course
            {
                Prefix = "CSCI 1302",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { Calculus_1 }, { Programming_Principles_1 }, { } }
            };

            Course Discrete_Math = new Course
            {
                Prefix = "MATH 2130",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true,
                Prereqs = new Course[,] { { College_Algebra, Trigonometry, Pre_Calculus, Calculus_1, calc} }
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
                Gloabl_Citizens,

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
                Statistics_1,

                Introduction_to_International_Studies,

                Principles_of_Biology_2_with_lab,
                Principles_of_Chemistry_2_with_lab,
                General_Historal_Geology_with_lab,
                Introduction_to_Physics_2_with_lab,
                Principles_of_Physics_2,

                Data_Structures,
                Systems_Software,
                Theoretical_Foundations,
                Database_Systems,
                Algorithm_Design_and_Analysis,
                Computer_Architecture,
                Data_Comm_and_Networking,
                Object_Oriented_Design,
                Computer_Security,
                Distributed_Web_Systems_Design,
                Software_Engineering,

                Introduction_to_Computer_Engineering,
                Logic_Circuits_and_Microprocessors,
                Data_Warehouse_Design,
                Human_Computer_Interaction,
                Game_Programming,
                Software_Testing_and_Quality_Assurance,
                Broadband_Networks,
                Optical_Networks,
                Selected_Topics,
                Discrete_Simulation,
                Artificial_Inteliigence,
                Computer_Graphics,
                Animation,
                Systems_and_Software_Assurance,
                Network_Management_Systems,
                Wireless_and_Mobile_Systems,

                Introduction_to_Operating_System,
                Comparative_Languages,
                Machine_Learning,

                //https://catalog.georgiasouthern.edu/academics/course-descriptions/csci/
                Comp_App_For_Bus_Majors,
                Introduction_to_BASIC_Programming,
                Introduction_to_Java_Programming,
                Cpp_Programming,
                High_Performance_Computing,
                Networks,
                Advanced_Database_Systems,
                Advanced_Operating_Systems,
                System_Prog_Under_Unix,
                Compiler_Theory,
                Embedded_Systems_Programming,
                Handheld_Ubiquitous_Computing,
                Numerical_Analysis,
                Data_Mining,
                Special_Problems_CO-OP,
                Directed_Study_in_Computer_Science,
                Data_Management_for_Math_and_the_Sciences,
                Discrete_Simulation,
                Software_Security_and_Secure_Coding

                

            };


            if (NextSpring)
            {
                List<Rule> springRules = new List<Rule>
                { new Rule("Spring", ExpressionType.Equal, "true")};

                var compiledRules = CompileRuleSet(new List<Course>(), springRules);

                courses.ForEach(course =>
                {

                    if (compiledRules.TakeWhile(r => r(course)).Any())
                    {
                        Console.WriteLine("Course: " + course.Prefix + " is available in the spring!");
                    }
                    else
                    {
                        Console.WriteLine("Course: " + course.Prefix + " is not available in the spring!");
                    }

                });
            }
        }

        public static List<Func<T, bool>> CompileRuleSet<T>(List<T> targetSet, List<Rule> ruleSet)
        {
            ParameterExpression paramType = Expression.Parameter(typeof(T));                //gets the type that is passed into param_0 
            //Console.WriteLine("ParameterExpression paramType = " + paramType.Type);

            List<Func<T,bool>> compiledOut = new List<Func<T, bool>>();                 //store compiled rules to return

            ruleSet.ForEach(r =>
            {              
                MemberExpression srcIdent = Expression.Property(paramType, r.Source);       //identity of src arg in this specific rule 
                //Console.WriteLine("r.Source = " + r.Source);
                //Console.WriteLine("MemberExpression srcIdent = " + srcIdent);

                PropertyInfo srcPropInfo = typeof(T).GetProperty(r.Source);              //Get the property info object about the source arg for this rule
                Type propType = srcPropInfo.PropertyType;                                   //gets property type associated with source arg for this rule
               //Console.WriteLine("Type propType = " + propType.Name);

                ConstantExpression trgIdent = Expression.Constant(Convert.ChangeType(r.Target, propType));      //Get the constant for the target argument in rule
               //Console.WriteLine("ConstantExpression trgIdent = " + trgIdent);

                BinaryExpression exp = Expression.MakeBinary(r.Operator, srcIdent, trgIdent);        //build the binary expression from left/operator/right defined in this Rule 
                //Console.WriteLine("r.Operator = " + r.Operator);
                //Console.WriteLine("BinaryExpression exp = " + exp);

                Func<T, bool> lambda = Expression.Lambda<Func<T, bool>>(exp, paramType).Compile();      //Compile the lambda expression

                compiledOut.Add(lambda);        //add the expression to the list or rules

            });

            return compiledOut;         //return set of compiled rules
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
            public Course[,] Prereqs
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
    }
}
