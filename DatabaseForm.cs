using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentsManagementWinForm
{
    public partial class DatabaseForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DatabaseForm()
        {
            InitializeComponent();
            viewData();
        }


       
        #region Method to Display Recent Changes in Database
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True
        void viewData()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
           // con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            cmd = new SqlCommand("Select * from Students");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Students");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        #endregion

        
        #region Search Data From Database
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //conditional statement to select IdNo to be searched
            if (comboBox1.Text == "ID No")
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                cmd = new SqlCommand("Select * from Students where IdNo like '%' + '" + textBoxSearch.Text + "' + '%' ");
                cmd.Connection = con;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Students");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            //conditional statement to select Lastname to be searched
            else if (comboBox1.Text == "Last Name")
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                cmd = new SqlCommand("Select * from Students where LastName like '%' + '" + textBoxSearch.Text + "' + '%' ");
                cmd.Connection = con;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Students");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            //conditional statement to select FirstName to be searched
            else if (comboBox1.Text == "First Name")
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                cmd = new SqlCommand("Select * from Students where FirstName like '%' + '" + textBoxSearch.Text + "' + '%' ");
                cmd.Connection = con;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Students");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            //conditional statement to select Course to be searched
            else if (comboBox1.Text == "Course")
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
               // con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                cmd = new SqlCommand("Select * from Students where Course like '%' + '" + textBoxSearch.Text + "' + '%' ");
                cmd.Connection = con;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Students");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }

            else
            {

            }
        }
        #endregion

        private void DatabaseForm_Load(object sender, EventArgs e)
        {

        }
        #region Insert Data from Database
        private void buttonInsertData_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            cmd = new SqlCommand("Insert Into Students values (@IdNo,@LastName,@FirstName,@Course,@Score,@OverallScore)");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@IdNo", textBoxIDNo.Text);
            cmd.Parameters.AddWithValue("@Lastname", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@Course", textBoxCourse.Text);
            cmd.Parameters.AddWithValue("@Score", textBoxScore.Text);
            cmd.Parameters.AddWithValue("@OverallScore", textBoxOverallScore.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            viewData();
        }
        #endregion

        
        #region Delete
        //delete and update ni bro ako nalang ge apil ang update 
        private void Delete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            cmd = new SqlCommand("Delete students where IdNo=@IdNo", con);
            cmd.Parameters.AddWithValue("@IdNo", textBoxIDNo.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            viewData();
            MessageBox.Show("Deleted");

        }
        #endregion

        #region Update
        private void Update_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            cmd = new SqlCommand("Update students set LastName = '" + textBoxLastName.Text + "', FirstName = '"+ textBoxFirstName.Text +"', Course = '"+ textBoxCourse.Text + "', Score = '" + textBoxScore.Text + "', OverallScore = '" + textBoxOverallScore.Text + "' where IdNo = '" + textBoxIDNo.Text + "'", con);
            cmd.Parameters.AddWithValue("@IdNo", textBoxIDNo.Text);
            cmd.Parameters.AddWithValue("@Lastname", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@Course", textBoxCourse.Text);
            cmd.Parameters.AddWithValue("@Score", textBoxScore.Text);
            cmd.Parameters.AddWithValue("@OverallScore", textBoxOverallScore.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            viewData();
            MessageBox.Show("Successfully Updated");

        }
        #endregion
    }
}
