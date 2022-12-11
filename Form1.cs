using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using CLIPSNET;

namespace CourseFinder
{
    public partial class CourseFinder : Form
    {
        private CLIPSNET.Environment clips = new CLIPSNET.Environment();
        private Dictionary<string, string> courseImages = new Dictionary<string, string>();

        public CourseFinder()
        {
            InitializeComponent();

            courseImages.Add("STEP-IT", "\\images\\" + "STEP-IT.png");
            courseImages.Add("IT-ACADEMY", "\\images\\" + "IT-ACADEMY.png");
            courseImages.Add("SAT-ACADEMY", "\\images\\" + "SAT-ACADEMY.png");
            courseImages.Add("THINK-WISE", "\\images\\" + "THINK-WISE.png");
            courseImages.Add("LLBS", "\\images\\" + "LLBS.jpg");
            courseImages.Add("CELT-COLLEGES", "\\images\\" + "CELT-COLLEGES.png");
        }


        private void CourseFinder_Load(object sender, EventArgs e)
        {
            cBoxCategory.SelectedIndex = 0;
            cBoxBudget.SelectedIndex = 0;
            cBoxRegime.SelectedIndex = 0;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            pBoxInstitution.Image = null;
            clips.Clear();

            clips.Load("courses.clp");
            clips.Load("program.clp");

            clips.Reset();

            String criteriaCategory = cBoxCategory.Text;
            String criteriaBudget = cBoxBudget.Text;
            String criteriaRegime = cBoxRegime.Text;

            clips.AssertString($"(category {criteriaCategory})");
            clips.AssertString($"(budget {criteriaBudget})");
            clips.AssertString($"(regime {criteriaRegime})");

            clips.Run();

            try
            {
                string institution = clips.FindFact("result")["institution"].ToString();
                lblResult.Text = institution;
                pBoxInstitution.Image = Image.FromFile(Directory.GetCurrentDirectory() + courseImages[institution]);
            }
            catch
            {
                lblResult.Text = "sorry, no result";
            }
            lblResult.Visible = true;
        }
    }
}
