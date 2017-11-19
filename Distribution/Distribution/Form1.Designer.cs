namespace Distribution
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.MintextBox = new System.Windows.Forms.TextBox();
            this.MaxtextBox = new System.Windows.Forms.TextBox();
            this.AveragetextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose File";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(12, 124);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(26, 13);
            this.MaxLabel.TabIndex = 1;
            this.MaxLabel.Text = "max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(12, 100);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(23, 13);
            this.minLabel.TabIndex = 1;
            this.minLabel.Text = "min";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(10, 149);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(44, 13);
            this.AverageLabel.TabIndex = 1;
            this.AverageLabel.Text = "Aveage";
            // 
            // MintextBox
            // 
            this.MintextBox.Location = new System.Drawing.Point(97, 100);
            this.MintextBox.Name = "MintextBox";
            this.MintextBox.Size = new System.Drawing.Size(100, 20);
            this.MintextBox.TabIndex = 3;
            // 
            // MaxtextBox
            // 
            this.MaxtextBox.Location = new System.Drawing.Point(97, 126);
            this.MaxtextBox.Name = "MaxtextBox";
            this.MaxtextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxtextBox.TabIndex = 3;
            // 
            // AveragetextBox
            // 
            this.AveragetextBox.Location = new System.Drawing.Point(97, 152);
            this.AveragetextBox.Name = "AveragetextBox";
            this.AveragetextBox.Size = new System.Drawing.Size(100, 20);
            this.AveragetextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(64, 187);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SaveResult";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 300);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.AveragetextBox);
            this.Controls.Add(this.MaxtextBox);
            this.Controls.Add(this.MintextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.TextBox MintextBox;
        private System.Windows.Forms.TextBox MaxtextBox;
        private System.Windows.Forms.TextBox AveragetextBox;
        private System.Windows.Forms.Button saveButton;


    }
}

