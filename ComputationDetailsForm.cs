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
    public partial class ComputationDetailsForm : Form
    {
        public ComputationDetailsForm()
        {
            InitializeComponent();

            string computationDetails = "Computation details:" +
                "\nAn excellent grade means you got a 95% - 100% score." +
                "\nA good grade means you got an 85% - 94% score." +
                "\nA fair grade means you got a 75% - 84% score." +
                "\nA poor grade means you got less than a 75% score." +
                "\n\nTip: Always study smart and be a hardworking student.";
            
            //Display Info to the label
            labelComputationDetails.Text = computationDetails;
        }
    }
}
