
namespace StudentsManagementWinForm
{
    partial class ParentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonAboutUs = new System.Windows.Forms.Button();
            this.buttonComputationDetails = new System.Windows.Forms.Button();
            this.buttonStudentEntry = new System.Windows.Forms.Button();
            this.buttonComputeGrades = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.buttonExit);
            this.panelSideMenu.Controls.Add(this.buttonHome);
            this.panelSideMenu.Controls.Add(this.buttonAboutUs);
            this.panelSideMenu.Controls.Add(this.buttonComputationDetails);
            this.panelSideMenu.Controls.Add(this.buttonStudentEntry);
            this.panelSideMenu.Controls.Add(this.buttonComputeGrades);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 644);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHome.Location = new System.Drawing.Point(0, 100);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(250, 45);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonAboutUs
            // 
            this.buttonAboutUs.FlatAppearance.BorderSize = 0;
            this.buttonAboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutUs.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAboutUs.Location = new System.Drawing.Point(0, 276);
            this.buttonAboutUs.Name = "buttonAboutUs";
            this.buttonAboutUs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAboutUs.Size = new System.Drawing.Size(250, 45);
            this.buttonAboutUs.TabIndex = 5;
            this.buttonAboutUs.Text = "About Us";
            this.buttonAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutUs.UseVisualStyleBackColor = true;
            this.buttonAboutUs.Click += new System.EventHandler(this.buttonAboutUs_Click);
            // 
            // buttonComputationDetails
            // 
            this.buttonComputationDetails.FlatAppearance.BorderSize = 0;
            this.buttonComputationDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonComputationDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComputationDetails.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonComputationDetails.Location = new System.Drawing.Point(0, 231);
            this.buttonComputationDetails.Name = "buttonComputationDetails";
            this.buttonComputationDetails.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonComputationDetails.Size = new System.Drawing.Size(250, 45);
            this.buttonComputationDetails.TabIndex = 4;
            this.buttonComputationDetails.Text = "Computation Details";
            this.buttonComputationDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComputationDetails.UseVisualStyleBackColor = true;
            this.buttonComputationDetails.Click += new System.EventHandler(this.buttonComputationDetails_Click);
            // 
            // buttonStudentEntry
            // 
            this.buttonStudentEntry.FlatAppearance.BorderSize = 0;
            this.buttonStudentEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonStudentEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentEntry.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStudentEntry.Location = new System.Drawing.Point(0, 186);
            this.buttonStudentEntry.Name = "buttonStudentEntry";
            this.buttonStudentEntry.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonStudentEntry.Size = new System.Drawing.Size(250, 45);
            this.buttonStudentEntry.TabIndex = 3;
            this.buttonStudentEntry.Text = "Student Entry";
            this.buttonStudentEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentEntry.UseVisualStyleBackColor = true;
            this.buttonStudentEntry.Click += new System.EventHandler(this.buttonCheckDatabase_Click);
            // 
            // buttonComputeGrades
            // 
            this.buttonComputeGrades.FlatAppearance.BorderSize = 0;
            this.buttonComputeGrades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonComputeGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComputeGrades.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonComputeGrades.Location = new System.Drawing.Point(0, 141);
            this.buttonComputeGrades.Name = "buttonComputeGrades";
            this.buttonComputeGrades.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonComputeGrades.Size = new System.Drawing.Size(250, 45);
            this.buttonComputeGrades.TabIndex = 2;
            this.buttonComputeGrades.Text = "Compute Grades";
            this.buttonComputeGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComputeGrades.UseVisualStyleBackColor = true;
            this.buttonComputeGrades.Click += new System.EventHandler(this.buttonComputeGrades_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::StudentsManagementWinForm.Properties.Resources.GroupIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(928, 644);
            this.panelChildForm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(186, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "THIS IS WANNABETECHIES\r\n          WINFORM APP";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::StudentsManagementWinForm.Properties.Resources.GroupIcon1;
            this.pictureBox2.Location = new System.Drawing.Point(324, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.Location = new System.Drawing.Point(0, 599);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(250, 45);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button buttonComputeGrades;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAboutUs;
        private System.Windows.Forms.Button buttonComputationDetails;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStudentEntry;
        private System.Windows.Forms.Button buttonExit;
    }
}