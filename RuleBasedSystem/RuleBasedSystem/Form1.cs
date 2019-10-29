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
        }

        public static List<Func<T, bool>> PreCompileRuleSet<T>(List<T> targetSet, List<Rule> ruleSet)
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
    }
}
