using NRules;
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

            int season = 1; //1 for Spring, 2 for Summer, 3 for Fall

            bool Engl1101 = false;


            //new Course("ENGL 1101 Composition I", Engl1101, true, true, true, false, new ArrayList(new string[] {}), new ArrayList(new string[] { }), new ArrayList(new string[] { }));
            ////University Requirements (6 Hours)
            //Course healthful_living = new Course("HLTH 1520 - Healthful Living", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //Course kins_1 = new Course("KINS 1XXXX - Physical Activity", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //Course kins_2 = new Course("KINS 1XXXX - Physical Activity", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //Course fye = new Course("FYE 1220 - First Year Experience", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);

            //// Area A1: Communication Skills (6 hours)
            //Course composition_1 = new Course("ENGL 1101 - Composition I", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //PreReqs.Add(composition_1);
            //Course composition_2 = new Course("ENGL 1102 - Composition II", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //PreReqs.Clear();

            ////Area A2: Quantitative Skills (3 hours) - Choose 1
            //Course college_algebra = new Course("MATH 1111 - College Algebra", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //PreReqs.Add(college_algebra);
            //Course trigonometry = new Course("MATH 1112 - Trigonometry", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //Course pre_calculus = new Course("MATH 1113 - Pre Calculus", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            ////Make a List of OR classes for prereq then add that to the pre req list.
            //OrPreReqs.Add(trigonometry);
            //OrPreReqs.Add(pre_calculus);
            //Course calculus = new Course("MATH 1441 - Calculus", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //PreReqs.Clear();
            //OrPreReqs.Clear();


            ////Area B: Global Engagement (4 hours)
            //Course world_history_2 = new Course("HIST 1112 - World History 2", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //PreReqs.Add(fye);
            //Course global_citizens = new Course("FYE 1410 - First Year Experience", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //PreReqs.Clear();

            ////Area C: Humanities & Fine Arts (6 hours)
            //PreReqs.Add(composition_1);
            //Course public_speaking = new Course("COMM 1110 - Public Speaking", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //PreReqs.Add(composition_2);
            //Course world_literature_1 = new Course("ENGL 2111 - World Literature 1", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //Course world_literature_2 = new Course("ENGL 2112 - World Literature 2", false, true, true, true, false, CoReqs, OrPreReqs, PreReqs);
            //PreReqs.Clear();

            var repository = new RuleRepository();
            repository.Load(x => x.From(typeof(ClassRule).Assembly));

            var factory = repository.Compile();

            var session = factory.CreateSession();
            session.Insert(new Course("ENGL 1101 Composition I", Engl1101, true, true, true, false, new ArrayList(new string[] { }), new ArrayList(new string[] { })));
            session.Insert(season);

            session.Fire();
        }


    }
}
