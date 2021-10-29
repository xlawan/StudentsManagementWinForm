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
    public partial class ComputeGradeForm : Form
    {
        public ComputeGradeForm()
        {
            InitializeComponent();
        }

        

        // declaring remarks for public use
        public string remark;

        // submit button
        #region SubmitButton
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // computation starts here
            double score = double.Parse(textBoxScore.Text);
            double grade = score / double.Parse(textBoxOverallScore.Text) * 100;
            if (grade >= 95)
            {
                remark = "EXCELLENT!!!";

            }
            else if (grade >= 85 && grade < 95)
            {
                remark = "GOOD!!!";

            }
            else if (grade >= 75 && grade < 85)
            {
                remark = "FAIR!!!";

            }
            else if (grade < 75)
            {
                remark = "POOR!!!";

            }
            // computation ends here

            MessageBox.Show("ID No: " + textBoxIDNo.Text
                          + "\nName: " + textBoxFirstName.Text + " " + textBoxLastName.Text
                          + "\nCourse: " + textBoxCourse.Text
                          + "\nScore: " + textBoxScore.Text + " / " + textBoxOverallScore.Text +
                          "\nRemarks: " + remark, "Results");

            // used the public remark to show remark string in messagebox
        }
        #endregion

        // this method will clear all inputted characted in the textboxes.
        #region ClearTextBoxes
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)

                        (control as TextBox).Clear();

                    else
                        func(control.Controls);
                }
            }; func(Controls);


        }
        #endregion


        // Clear button
        #region ClearButton
        private void buttonClearTextBoxes_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        #endregion


        // error prompt for ID No. textbox when using letters
        #region ErrorPrompt
        private void textBoxIDNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter NUMBERS only.", "Error");
            }
        }
        // error prompt for First Name textbox when using numbers
        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter LETTERS only.", "Error");
            }
        }
        // error prompt for Last Name textbox when using numbers
        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter LETTERS only.", "Error");
            }
        }

        // error prompt for Last Name textbox when using numbers
        private void textBoxCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter LETTERS only.", "Error");
            }
        }

        // error prompt for Score textbox when using letters
        private void textBoxScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter NUMBERS only.", "Error");

            }

        }

        // error prompt for Overall Score textbox when using letters
        private void textBoxOverallScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter NUMBERS only.", "Error");

            }

        }
        #endregion
    }
}
