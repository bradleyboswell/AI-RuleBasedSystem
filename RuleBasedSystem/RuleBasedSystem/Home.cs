using NRules.Fluent;
using System;
using System.Collections;
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
            ArrayList blah = new ArrayList(new String[] { "blah" });

            int season = 1; //1 for Spring, 2 for Summer, 3 for Fall

            bool Engl1101 = false;


            new Course("ENGL 1101 Composition I", Engl1101, true, true, true, false, new ArrayList(new string[] {}), new ArrayList(new string[] { }), new ArrayList(new string[] { }));

            var repository = new RuleRepository();
            repository.Load(x => x.From(typeof().Assembly));

        }


    }
}
