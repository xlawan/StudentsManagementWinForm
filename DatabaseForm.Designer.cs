
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
            this.components = new System.ComponentModel.Container();
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
            this.buttonAddData = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelSearchSelection = new System.Windows.Forms.Label();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.buttonDeleteData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDNo
            // 
            this.labelIDNo.AutoSize = true;
            this.labelIDNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelIDNo.Location = new System.Drawing.Point(5, 23);
            this.labelIDNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDNo.Name = "labelIDNo";
            this.labelIDNo.Size = new System.Drawing.Size(41, 13);
            this.labelIDNo.TabIndex = 3;
            this.labelIDNo.Text = "ID. No:";
            // 
            // textBoxIDNo
            // 
            this.textBoxIDNo.Location = new System.Drawing.Point(8, 38);
            this.textBoxIDNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIDNo.Name = "textBoxIDNo";
            this.textBoxIDNo.Size = new System.Drawing.Size(140, 20);
            this.textBoxIDNo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(416, 196);
            this.dataGridView1.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLastName.Location = new System.Drawing.Point(5, 60);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Last name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(8, 75);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(140, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(8, 112);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(140, 20);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(5, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Course:";
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(8, 153);
            this.textBoxCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(140, 20);
            this.textBoxCourse.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(5, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Score:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(8, 190);
            this.textBoxScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(140, 20);
            this.textBoxScore.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(5, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Overall Score:";
            // 
            // textBoxOverallScore
            // 
            this.textBoxOverallScore.Location = new System.Drawing.Point(8, 227);
            this.textBoxOverallScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOverallScore.Name = "textBoxOverallScore";
            this.textBoxOverallScore.Size = new System.Drawing.Size(140, 20);
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
            this.comboBox1.Location = new System.Drawing.Point(180, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(265, 38);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(333, 20);
            this.textBoxSearch.TabIndex = 16;
            // 
            // buttonAddData
            // 
            this.buttonAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddData.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAddData.Location = new System.Drawing.Point(8, 260);
            this.buttonAddData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(120, 32);
            this.buttonAddData.TabIndex = 17;
            this.buttonAddData.Text = "Add Data";
            this.buttonAddData.UseVisualStyleBackColor = true;
            this.buttonAddData.Click += new System.EventHandler(this.buttonInsertData_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelSearchSelection
            // 
            this.labelSearchSelection.AutoSize = true;
            this.labelSearchSelection.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSearchSelection.Location = new System.Drawing.Point(177, 23);
            this.labelSearchSelection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchSelection.Name = "labelSearchSelection";
            this.labelSearchSelection.Size = new System.Drawing.Size(91, 13);
            this.labelSearchSelection.TabIndex = 18;
            this.labelSearchSelection.Text = "Search Selection:";
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateData.ForeColor = System.Drawing.Color.LightGray;
            this.buttonUpdateData.Location = new System.Drawing.Point(8, 296);
            this.buttonUpdateData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(120, 32);
            this.buttonUpdateData.TabIndex = 19;
            this.buttonUpdateData.Text = "Update Data";
            this.buttonUpdateData.UseVisualStyleBackColor = true;
            this.buttonUpdateData.Click += new System.EventHandler(this.Update_Click);
            // 
            // buttonDeleteData
            // 
            this.buttonDeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteData.ForeColor = System.Drawing.Color.LightGray;
            this.buttonDeleteData.Location = new System.Drawing.Point(8, 333);
            this.buttonDeleteData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteData.Name = "buttonDeleteData";
            this.buttonDeleteData.Size = new System.Drawing.Size(120, 32);
            this.buttonDeleteData.TabIndex = 20;
            this.buttonDeleteData.Text = "Delete Data";
            this.buttonDeleteData.UseVisualStyleBackColor = true;
            this.buttonDeleteData.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(604, 382);
            this.Controls.Add(this.buttonDeleteData);
            this.Controls.Add(this.buttonUpdateData);
            this.Controls.Add(this.labelSearchSelection);
            this.Controls.Add(this.buttonAddData);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelSearchSelection;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.Button buttonDeleteData;
    }
}