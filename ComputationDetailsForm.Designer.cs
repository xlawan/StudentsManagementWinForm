
namespace StudentsManagementWinForm
{
    partial class ComputationDetailsForm
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
            this.labelComputationDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelComputationDetails
            // 
            this.labelComputationDetails.AutoSize = true;
            this.labelComputationDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.labelComputationDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelComputationDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelComputationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputationDetails.Location = new System.Drawing.Point(0, 0);
            this.labelComputationDetails.Name = "labelComputationDetails";
            this.labelComputationDetails.Size = new System.Drawing.Size(0, 46);
            this.labelComputationDetails.TabIndex = 1;
            // 
            // ComputationDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(906, 588);
            this.Controls.Add(this.labelComputationDetails);
            this.Name = "ComputationDetailsForm";
            this.Text = "ComputationDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComputationDetails;
    }
}