
namespace StudentsManagementWinForm
{
    partial class DatabaseForm
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
            this.labelIDNo = new System.Windows.Forms.Label();
            this.textBoxIDNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOverallScore = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonInsertData = new System.Windows.Forms.Button();
            this.buttonViewData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDNo
            // 
            this.labelIDNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelIDNo.AutoSize = true;
            this.labelIDNo.Location = new System.Drawing.Point(8, 36);
            this.labelIDNo.Name = "labelIDNo";
            this.labelIDNo.Size = new System.Drawing.Size(58, 20);
            this.labelIDNo.TabIndex = 3;
            this.labelIDNo.Text = "ID. No:";
            // 
            // textBoxIDNo
            // 
            this.textBoxIDNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxIDNo.Location = new System.Drawing.Point(12, 59);
            this.textBoxIDNo.Name = "textBoxIDNo";
            this.textBoxIDNo.Size = new System.Drawing.Size(208, 26);
            this.textBoxIDNo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(946, 302);
            this.dataGridView1.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(8, 93);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(88, 20);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Last name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLastName.Location = new System.Drawing.Point(12, 116);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(208, 26);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 173);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(208, 26);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Course:";
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCourse.Location = new System.Drawing.Point(12, 236);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(208, 26);
            this.textBoxCourse.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Score:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxScore.Location = new System.Drawing.Point(12, 292);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(208, 26);
            this.textBoxScore.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Overall Score:";
            // 
            // textBoxOverallScore
            // 
            this.textBoxOverallScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxOverallScore.Location = new System.Drawing.Point(12, 350);
            this.textBoxOverallScore.Name = "textBoxOverallScore";
            this.textBoxOverallScore.Size = new System.Drawing.Size(208, 26);
            this.textBoxOverallScore.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID No",
            "Last Name",
            "First Name",
            "Course"});
            this.comboBox1.Location = new System.Drawing.Point(270, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearch.Location = new System.Drawing.Point(397, 59);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(819, 26);
            this.textBoxSearch.TabIndex = 16;
            // 
            // buttonInsertData
            // 
            this.buttonInsertData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonInsertData.Location = new System.Drawing.Point(30, 382);
            this.buttonInsertData.Name = "buttonInsertData";
            this.buttonInsertData.Size = new System.Drawing.Size(180, 50);
            this.buttonInsertData.TabIndex = 17;
            this.buttonInsertData.Text = "Insert Data";
            this.buttonInsertData.UseVisualStyleBackColor = true;
            // 
            // buttonViewData
            // 
            this.buttonViewData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonViewData.Location = new System.Drawing.Point(783, 401);
            this.buttonViewData.Name = "buttonViewData";
            this.buttonViewData.Size = new System.Drawing.Size(180, 40);
            this.buttonViewData.TabIndex = 18;
            this.buttonViewData.Text = "View Data";
            this.buttonViewData.UseVisualStyleBackColor = true;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 444);
            this.Controls.Add(this.buttonViewData);
            this.Controls.Add(this.buttonInsertData);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOverallScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelIDNo);
            this.Controls.Add(this.textBoxIDNo);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDNo;
        private System.Windows.Forms.TextBox textBoxIDNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOverallScore;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonInsertData;
        private System.Windows.Forms.Button buttonViewData;
    }
}