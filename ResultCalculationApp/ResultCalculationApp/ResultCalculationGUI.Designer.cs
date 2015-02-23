namespace ResultCalculationApp
{
    partial class ResultCalculationGUI
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
            this.physicsTextButton = new System.Windows.Forms.TextBox();
            this.chemistryTextButton = new System.Windows.Forms.TextBox();
            this.mathTextButton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.averageTextButton = new System.Windows.Forms.TextBox();
            this.gradeTextButton = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // physicsTextButton
            // 
            this.physicsTextButton.Location = new System.Drawing.Point(123, 51);
            this.physicsTextButton.Name = "physicsTextButton";
            this.physicsTextButton.Size = new System.Drawing.Size(100, 20);
            this.physicsTextButton.TabIndex = 0;
            // 
            // chemistryTextButton
            // 
            this.chemistryTextButton.Location = new System.Drawing.Point(123, 97);
            this.chemistryTextButton.Name = "chemistryTextButton";
            this.chemistryTextButton.Size = new System.Drawing.Size(100, 20);
            this.chemistryTextButton.TabIndex = 0;
            // 
            // mathTextButton
            // 
            this.mathTextButton.Location = new System.Drawing.Point(123, 139);
            this.mathTextButton.Name = "mathTextButton";
            this.mathTextButton.Size = new System.Drawing.Size(100, 20);
            this.mathTextButton.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Physics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chemistry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Math";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "out of 100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "out of 100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "out of 100";
            // 
            // averageTextButton
            // 
            this.averageTextButton.Location = new System.Drawing.Point(123, 202);
            this.averageTextButton.Name = "averageTextButton";
            this.averageTextButton.Size = new System.Drawing.Size(100, 20);
            this.averageTextButton.TabIndex = 3;
            // 
            // gradeTextButton
            // 
            this.gradeTextButton.Location = new System.Drawing.Point(123, 244);
            this.gradeTextButton.Name = "gradeTextButton";
            this.gradeTextButton.Size = new System.Drawing.Size(100, 20);
            this.gradeTextButton.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(257, 199);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Average";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Grade Letter";
            // 
            // ResultCalculationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 286);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.gradeTextButton);
            this.Controls.Add(this.averageTextButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mathTextButton);
            this.Controls.Add(this.chemistryTextButton);
            this.Controls.Add(this.physicsTextButton);
            this.Name = "ResultCalculationGUI";
            this.Text = "ResultCalculationGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox physicsTextButton;
        private System.Windows.Forms.TextBox chemistryTextButton;
        private System.Windows.Forms.TextBox mathTextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox averageTextButton;
        private System.Windows.Forms.TextBox gradeTextButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

