
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAboutUs = new System.Windows.Forms.Button();
            this.buttonComputationDetails = new System.Windows.Forms.Button();
            this.buttonStudentEntry = new System.Windows.Forms.Button();
            this.buttonComputeGrades = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.panelSideMenu.Controls.Add(this.buttonHome);
            this.panelSideMenu.Controls.Add(this.buttonExit);
            this.panelSideMenu.Controls.Add(this.buttonAboutUs);
            this.panelSideMenu.Controls.Add(this.buttonComputationDetails);
            this.panelSideMenu.Controls.Add(this.buttonStudentEntry);
            this.panelSideMenu.Controls.Add(this.buttonComputeGrades);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(280, 645);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 105);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonHome.Size = new System.Drawing.Size(280, 45);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(0, 595);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(280, 45);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAboutUs
            // 
            this.buttonAboutUs.FlatAppearance.BorderSize = 0;
            this.buttonAboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAboutUs.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("buttonAboutUs.Image")));
            this.buttonAboutUs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAboutUs.Location = new System.Drawing.Point(0, 300);
            this.buttonAboutUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAboutUs.Name = "buttonAboutUs";
            this.buttonAboutUs.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonAboutUs.Size = new System.Drawing.Size(280, 45);
            this.buttonAboutUs.TabIndex = 5;
            this.buttonAboutUs.Text = "About Us";
            this.buttonAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAboutUs.UseVisualStyleBackColor = true;
            this.buttonAboutUs.Click += new System.EventHandler(this.buttonAboutUs_Click);
            // 
            // buttonComputationDetails
            // 
            this.buttonComputationDetails.FlatAppearance.BorderSize = 0;
            this.buttonComputationDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonComputationDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComputationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComputationDetails.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonComputationDetails.Image = ((System.Drawing.Image)(resources.GetObject("buttonComputationDetails.Image")));
            this.buttonComputationDetails.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonComputationDetails.Location = new System.Drawing.Point(0, 254);
            this.buttonComputationDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonComputationDetails.Name = "buttonComputationDetails";
            this.buttonComputationDetails.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonComputationDetails.Size = new System.Drawing.Size(280, 45);
            this.buttonComputationDetails.TabIndex = 4;
            this.buttonComputationDetails.Text = "Computation Details";
            this.buttonComputationDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComputationDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonComputationDetails.UseVisualStyleBackColor = true;
            this.buttonComputationDetails.Click += new System.EventHandler(this.buttonComputationDetails_Click);
            // 
            // buttonStudentEntry
            // 
            this.buttonStudentEntry.FlatAppearance.BorderSize = 0;
            this.buttonStudentEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonStudentEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentEntry.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStudentEntry.Image = ((System.Drawing.Image)(resources.GetObject("buttonStudentEntry.Image")));
            this.buttonStudentEntry.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonStudentEntry.Location = new System.Drawing.Point(0, 205);
            this.buttonStudentEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudentEntry.Name = "buttonStudentEntry";
            this.buttonStudentEntry.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonStudentEntry.Size = new System.Drawing.Size(280, 45);
            this.buttonStudentEntry.TabIndex = 3;
            this.buttonStudentEntry.Text = "Student Entry";
            this.buttonStudentEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudentEntry.UseVisualStyleBackColor = true;
            this.buttonStudentEntry.Click += new System.EventHandler(this.buttonCheckDatabase_Click);
            // 
            // buttonComputeGrades
            // 
            this.buttonComputeGrades.FlatAppearance.BorderSize = 0;
            this.buttonComputeGrades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonComputeGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComputeGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComputeGrades.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonComputeGrades.Image = ((System.Drawing.Image)(resources.GetObject("buttonComputeGrades.Image")));
            this.buttonComputeGrades.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonComputeGrades.Location = new System.Drawing.Point(0, 155);
            this.buttonComputeGrades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonComputeGrades.Name = "buttonComputeGrades";
            this.buttonComputeGrades.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonComputeGrades.Size = new System.Drawing.Size(280, 45);
            this.buttonComputeGrades.TabIndex = 2;
            this.buttonComputeGrades.Text = "Compute Grades";
            this.buttonComputeGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComputeGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonComputeGrades.UseVisualStyleBackColor = true;
            this.buttonComputeGrades.Click += new System.EventHandler(this.buttonComputeGrades_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(280, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::StudentsManagementWinForm.Properties.Resources.GroupIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 100);
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
            this.panelChildForm.Location = new System.Drawing.Point(280, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(898, 645);
            this.panelChildForm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(172, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "THIS IS WANNABETECHIES\r\n          WINFORM APP";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::StudentsManagementWinForm.Properties.Resources.GroupIcon1;
            this.pictureBox2.Location = new System.Drawing.Point(310, 100);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 645);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ParentForm";
            this.Text = "Student Management";
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