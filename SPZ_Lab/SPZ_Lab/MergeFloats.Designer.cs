namespace SPZ_Lab
{
    partial class MergeFloats
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
            this.MergeFloatsLabel = new System.Windows.Forms.Label();
            this.OpenFirstFileButton = new System.Windows.Forms.Button();
            this.OpenSecondFileButton = new System.Windows.Forms.Button();
            this.FirstFileText = new System.Windows.Forms.TextBox();
            this.SecondFileText = new System.Windows.Forms.TextBox();
            this.FirstFileName = new System.Windows.Forms.Label();
            this.SecondFileName = new System.Windows.Forms.Label();
            this.MergedValues = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MergeFloatsLabel
            // 
            this.MergeFloatsLabel.AutoSize = true;
            this.MergeFloatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MergeFloatsLabel.Location = new System.Drawing.Point(290, 9);
            this.MergeFloatsLabel.Name = "MergeFloatsLabel";
            this.MergeFloatsLabel.Size = new System.Drawing.Size(112, 24);
            this.MergeFloatsLabel.TabIndex = 0;
            this.MergeFloatsLabel.Text = "Merge floats";
            // 
            // OpenFirstFileButton
            // 
            this.OpenFirstFileButton.Location = new System.Drawing.Point(51, 46);
            this.OpenFirstFileButton.Name = "OpenFirstFileButton";
            this.OpenFirstFileButton.Size = new System.Drawing.Size(114, 23);
            this.OpenFirstFileButton.TabIndex = 1;
            this.OpenFirstFileButton.Text = "Select first file";
            this.OpenFirstFileButton.UseVisualStyleBackColor = true;
            this.OpenFirstFileButton.Click += new System.EventHandler(this.OpenFirstFileButton_Click);
            // 
            // OpenSecondFileButton
            // 
            this.OpenSecondFileButton.Location = new System.Drawing.Point(546, 46);
            this.OpenSecondFileButton.Name = "OpenSecondFileButton";
            this.OpenSecondFileButton.Size = new System.Drawing.Size(114, 23);
            this.OpenSecondFileButton.TabIndex = 2;
            this.OpenSecondFileButton.Text = "Select second file";
            this.OpenSecondFileButton.UseVisualStyleBackColor = true;
            this.OpenSecondFileButton.Click += new System.EventHandler(this.OpenSecondFileButton_Click);
            // 
            // FirstFileText
            // 
            this.FirstFileText.Location = new System.Drawing.Point(51, 96);
            this.FirstFileText.Multiline = true;
            this.FirstFileText.Name = "FirstFileText";
            this.FirstFileText.Size = new System.Drawing.Size(253, 162);
            this.FirstFileText.TabIndex = 3;
            // 
            // SecondFileText
            // 
            this.SecondFileText.Location = new System.Drawing.Point(407, 96);
            this.SecondFileText.Multiline = true;
            this.SecondFileText.Name = "SecondFileText";
            this.SecondFileText.Size = new System.Drawing.Size(253, 162);
            this.SecondFileText.TabIndex = 4;
            // 
            // FirstFileName
            // 
            this.FirstFileName.Location = new System.Drawing.Point(51, 80);
            this.FirstFileName.Name = "FirstFileName";
            this.FirstFileName.Size = new System.Drawing.Size(253, 13);
            this.FirstFileName.TabIndex = 5;
            // 
            // SecondFileName
            // 
            this.SecondFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondFileName.Location = new System.Drawing.Point(407, 80);
            this.SecondFileName.Name = "SecondFileName";
            this.SecondFileName.Size = new System.Drawing.Size(253, 13);
            this.SecondFileName.TabIndex = 6;
            this.SecondFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MergedValues
            // 
            this.MergedValues.Location = new System.Drawing.Point(51, 308);
            this.MergedValues.Multiline = true;
            this.MergedValues.Name = "MergedValues";
            this.MergedValues.Size = new System.Drawing.Size(609, 162);
            this.MergedValues.TabIndex = 7;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(325, 285);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(55, 20);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Result";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(316, 508);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MergeFloats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 543);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.MergedValues);
            this.Controls.Add(this.SecondFileName);
            this.Controls.Add(this.FirstFileName);
            this.Controls.Add(this.SecondFileText);
            this.Controls.Add(this.FirstFileText);
            this.Controls.Add(this.OpenSecondFileButton);
            this.Controls.Add(this.OpenFirstFileButton);
            this.Controls.Add(this.MergeFloatsLabel);
            this.Name = "MergeFloats";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MergeFloatsLabel;
        private System.Windows.Forms.Button OpenFirstFileButton;
        private System.Windows.Forms.Button OpenSecondFileButton;
        private System.Windows.Forms.TextBox FirstFileText;
        private System.Windows.Forms.TextBox SecondFileText;
        private System.Windows.Forms.Label FirstFileName;
        private System.Windows.Forms.Label SecondFileName;
        private System.Windows.Forms.TextBox MergedValues;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}

