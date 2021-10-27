using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagementWinForm
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm) 
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void buttonComputeGrades_Click(object sender, EventArgs e)
        {
            openChildForm(new ComputeGradeForm());
        }

        private void buttonCheckDatabase_Click(object sender, EventArgs e)
        {
            openChildForm(new DatabaseForm());
        }

        //Opens Computation Details Box
        private void buttonComputationDetails_Click(object sender, EventArgs e)
        {
            openChildForm(new ComputationDetailsForm());
        }
        //Opens About Us Message Box
        private void buttonAboutUs_Click(object sender, EventArgs e)
        {
            openChildForm(new AboutUsForm());
        }
    }
}
