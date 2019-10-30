using System;
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
            Course healthful_living = new Course
            {
                Prefix = "HLTH 1520",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };
            Course physical_activity_1 = new Course
            {
                Prefix = "KINS 1XXX",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };
            Course physical_activity_2 = new Course
            {
                Prefix = "KINS 1XXX",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };
            Course first_year_experience = new Course
            {
                Prefix = "FYE 1220",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };

            Course engl_1101 = new Course
            {
                Prefix = "ENGL 1101",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };
            Course engl_1102 = new Course
            {
                Prefix = "ENGL 1102",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };
            Course college_algebra = new Course
            {
                Prefix = "MATH 1111",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };
            Course trigonometry = new Course
            {
                Prefix = "MATH 1112",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };
            Course pre_calculus = new Course
            {
                Prefix = "MATH 1113",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };
            Course calculus = new Course
            {
                Prefix = "MATH 1441",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };
            Course world_history_2 = new Course
            {
                Prefix = "HIST 1112",
                IsCompleted = false,
                IsAvailable = true,
                Fall = true,
                Summer = true,
                Spring = true,
                OnDemand = true
            };
            


            List<Course> courses = new List<Course>
            {
                engl_1101,
                engl_1102,
                college_algebra,
                trigonometry,
                pre_calculus,
                calculus
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

                PropertyInfo srcPropInfo = typeof(T).GetProperty(r.Source);              //Get the property info object about the source arg for this rul
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
