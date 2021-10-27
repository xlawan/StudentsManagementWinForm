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
    public partial class AboutUsForm : Form
    {
        public AboutUsForm()
        {
            InitializeComponent();

            string aboutUs = "Group: WannaBeTechies" +
                "\n\nNames:  Laput, Alaine " +
                "\nLawan, Alixander " +
                "\nLibato, Kevin " +
                "\nLlanto, Cathyrine " +
                "\nMahinay, Angelu " +
                "\nMatin - ao, Meinhardt Allain " +
                "\nMembers: 6 " +
                "\n\nPoint person: Lawan, Alixander";

            labelAboutUs.Text = aboutUs;
        }
    }
}
