
namespace StudentsManagementWinForm
{
    partial class Form1
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
            this.textBoxIDNo = new System.Windows.Forms.TextBox();
            this.labelIDNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOverallScore = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClearTextBoxes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIDNo
            // 
            this.textBoxIDNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxIDNo.Location = new System.Drawing.Point(16, 64);
            this.textBoxIDNo.Name = "textBoxIDNo";
            this.textBoxIDNo.Size = new System.Drawing.Size(654, 26);
            this.textBoxIDNo.TabIndex = 0;
            this.textBoxIDNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDNo_KeyPress);
            // 
            // labelIDNo
            // 
            this.labelIDNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelIDNo.AutoSize = true;
            this.labelIDNo.Location = new System.Drawing.Point(12, 41);
            this.labelIDNo.Name = "labelIDNo";
            this.labelIDNo.Size = new System.Drawing.Size(58, 20);
            this.labelIDNo.TabIndex = 1;
            this.labelIDNo.Text = "ID. No:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFirstName.Location = new System.Drawing.Point(16, 178);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(654, 26);
            this.textBoxFirstName.TabIndex = 2;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLastName.Location = new System.Drawing.Point(16, 122);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(654, 26);
            this.textBoxLastName.TabIndex = 4;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Course:";
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCourse.Location = new System.Drawing.Point(16, 233);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(654, 26);
            this.textBoxCourse.TabIndex = 6;
            this.textBoxCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCourse_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Score:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxScore.Location = new System.Drawing.Point(16, 289);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(654, 26);
            this.textBoxScore.TabIndex = 8;
            this.textBoxScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxScore_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Overall Score:";
            // 
            // textBoxOverallScore
            // 
            this.textBoxOverallScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxOverallScore.Location = new System.Drawing.Point(16, 350);
            this.textBoxOverallScore.Name = "textBoxOverallScore";
            this.textBoxOverallScore.Size = new System.Drawing.Size(654, 26);
            this.textBoxOverallScore.TabIndex = 10;
            this.textBoxOverallScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOverallScore_KeyPress);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmit.Location = new System.Drawing.Point(364, 382);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(180, 50);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClearTextBoxes
            // 
            this.buttonClearTextBoxes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClearTextBoxes.Location = new System.Drawing.Point(178, 382);
            this.buttonClearTextBoxes.Name = "buttonClearTextBoxes";
            this.buttonClearTextBoxes.Size = new System.Drawing.Size(180, 50);
            this.buttonClearTextBoxes.TabIndex = 13;
            this.buttonClearTextBoxes.Text = "Clear All";
            this.buttonClearTextBoxes.UseVisualStyleBackColor = true;
            this.buttonClearTextBoxes.Click += new System.EventHandler(this.buttonClearTextBoxes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.databaseManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computationDetailsToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // computationDetailsToolStripMenuItem
            // 
            this.computationDetailsToolStripMenuItem.Name = "computationDetailsToolStripMenuItem";
            this.computationDetailsToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.computationDetailsToolStripMenuItem.Text = "Computation Details";
            this.computationDetailsToolStripMenuItem.Click += new System.EventHandler(this.computationDetailsToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // databaseManagementToolStripMenuItem
            // 
            this.databaseManagementToolStripMenuItem.Name = "databaseManagementToolStripMenuItem";
            this.databaseManagementToolStripMenuItem.Size = new System.Drawing.Size(212, 29);
            this.databaseManagementToolStripMenuItem.Text = "Database Management";
            this.databaseManagementToolStripMenuItem.Click += new System.EventHandler(this.databaseManagementToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 444);
            this.Controls.Add(this.buttonClearTextBoxes);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOverallScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelIDNo);
            this.Controls.Add(this.textBoxIDNo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Text = "ComputingGradesForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIDNo;
        private System.Windows.Forms.Label labelIDNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOverallScore;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClearTextBoxes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseManagementToolStripMenuItem;
    }
}

