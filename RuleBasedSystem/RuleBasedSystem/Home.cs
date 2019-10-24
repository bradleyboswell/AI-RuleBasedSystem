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


    }
}
