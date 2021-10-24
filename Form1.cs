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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        // declaring remarks for public use
        public string remark;

        // submit button
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // computation starts here
            // int grade = int.Parse(textBox4.Text);
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

        // this method will clear all inputted characted in the textboxes.
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
        // Clear button
        private void buttonClearTextBoxes_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        // error prompt for ID No. textbox when using letters
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
        //Computations menu details
        private void computationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Computation details:" +
                "\nAn excellent grade means you got a 95% - 100% score." +
                "\nA good grade means you got an 85% - 94% score." +
                "\nA fair grade means you got a 75% - 84% score." +
                "\nA poor grade means you got less than a 75% score." +
                "\n\nTip: Always study smart and be a hardworking student.", "Computation Details");
        }
        //About menu details
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Group: WannaBeTechies" +
                "\nNames:  Laput, Alaine " +
                "\nLawan, Alixander " +
                "\nLibato, Kevin " +
                "\nLlanto, Cathyrine " +
                "\nMahinay, Angelu " +
                "\nMatin - ao, Meinhardt Allain " +
                "\nMembers: 6 " +
                "\nPoint person: Lawan, Alixander", "About Us");
        }

        private void databaseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseForm databaseForm = new DatabaseForm();
            databaseForm.Show();
        }
    }
}
