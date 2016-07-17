namespace StackAndQueue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.choosingProjectComboBox = new System.Windows.Forms.ComboBox();
            this.myInputValueTextBox = new System.Windows.Forms.TextBox();
            this.cInputValueTextBox = new System.Windows.Forms.TextBox();
            this.myProjectName = new System.Windows.Forms.Label();
            this.cProjectName = new System.Windows.Forms.Label();
            this.myAddValueButton = new System.Windows.Forms.Button();
            this.myRemoveValueButton = new System.Windows.Forms.Button();
            this.cAddValueButton = new System.Windows.Forms.Button();
            this.cRemoveValueButton = new System.Windows.Forms.Button();
            this.myOperationTimeLabelForAdd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cOperationTimeLabelForAdd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cOperationTimeLabelForAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.myOperationTimeLabelForAdd);
            this.panel1.Controls.Add(this.cRemoveValueButton);
            this.panel1.Controls.Add(this.cAddValueButton);
            this.panel1.Controls.Add(this.myRemoveValueButton);
            this.panel1.Controls.Add(this.myAddValueButton);
            this.panel1.Controls.Add(this.cProjectName);
            this.panel1.Controls.Add(this.myProjectName);
            this.panel1.Controls.Add(this.cInputValueTextBox);
            this.panel1.Controls.Add(this.myInputValueTextBox);
            this.panel1.Controls.Add(this.choosingProjectComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 465);
            this.panel1.TabIndex = 0;
            // 
            // choosingProjectComboBox
            // 
            this.choosingProjectComboBox.FormattingEnabled = true;
            this.choosingProjectComboBox.Items.AddRange(new object[] {
            "C# Stack",
            "C# Queue",
            "My Stack",
            "My Queue"});
            this.choosingProjectComboBox.Location = new System.Drawing.Point(13, 19);
            this.choosingProjectComboBox.Name = "choosingProjectComboBox";
            this.choosingProjectComboBox.Size = new System.Drawing.Size(121, 21);
            this.choosingProjectComboBox.TabIndex = 0;
            // 
            // myInputValueTextBox
            // 
            this.myInputValueTextBox.Location = new System.Drawing.Point(13, 84);
            this.myInputValueTextBox.Name = "myInputValueTextBox";
            this.myInputValueTextBox.Size = new System.Drawing.Size(121, 20);
            this.myInputValueTextBox.TabIndex = 1;
            // 
            // cInputValueTextBox
            // 
            this.cInputValueTextBox.Location = new System.Drawing.Point(234, 84);
            this.cInputValueTextBox.Name = "cInputValueTextBox";
            this.cInputValueTextBox.Size = new System.Drawing.Size(121, 20);
            this.cInputValueTextBox.TabIndex = 2;
            // 
            // myProjectName
            // 
            this.myProjectName.AutoSize = true;
            this.myProjectName.Location = new System.Drawing.Point(10, 58);
            this.myProjectName.Name = "myProjectName";
            this.myProjectName.Size = new System.Drawing.Size(35, 13);
            this.myProjectName.TabIndex = 3;
            this.myProjectName.Text = "label1";
            // 
            // cProjectName
            // 
            this.cProjectName.AutoSize = true;
            this.cProjectName.Location = new System.Drawing.Point(231, 58);
            this.cProjectName.Name = "cProjectName";
            this.cProjectName.Size = new System.Drawing.Size(35, 13);
            this.cProjectName.TabIndex = 4;
            this.cProjectName.Text = "label2";
            // 
            // myAddValueButton
            // 
            this.myAddValueButton.Location = new System.Drawing.Point(13, 142);
            this.myAddValueButton.Name = "myAddValueButton";
            this.myAddValueButton.Size = new System.Drawing.Size(75, 23);
            this.myAddValueButton.TabIndex = 5;
            this.myAddValueButton.Text = "Add";
            this.myAddValueButton.UseVisualStyleBackColor = true;
            this.myAddValueButton.Click += new System.EventHandler(this.myAddValueButton_Click);
            // 
            // myRemoveValueButton
            // 
            this.myRemoveValueButton.Location = new System.Drawing.Point(13, 231);
            this.myRemoveValueButton.Name = "myRemoveValueButton";
            this.myRemoveValueButton.Size = new System.Drawing.Size(75, 23);
            this.myRemoveValueButton.TabIndex = 6;
            this.myRemoveValueButton.Text = "Remove";
            this.myRemoveValueButton.UseVisualStyleBackColor = true;
            // 
            // cAddValueButton
            // 
            this.cAddValueButton.Location = new System.Drawing.Point(234, 142);
            this.cAddValueButton.Name = "cAddValueButton";
            this.cAddValueButton.Size = new System.Drawing.Size(75, 23);
            this.cAddValueButton.TabIndex = 7;
            this.cAddValueButton.Text = "Add";
            this.cAddValueButton.UseVisualStyleBackColor = true;
            // 
            // cRemoveValueButton
            // 
            this.cRemoveValueButton.Location = new System.Drawing.Point(234, 231);
            this.cRemoveValueButton.Name = "cRemoveValueButton";
            this.cRemoveValueButton.Size = new System.Drawing.Size(75, 23);
            this.cRemoveValueButton.TabIndex = 8;
            this.cRemoveValueButton.Text = "Remove";
            this.cRemoveValueButton.UseVisualStyleBackColor = true;
            // 
            // myOperationTimeLabelForAdd
            // 
            this.myOperationTimeLabelForAdd.AutoSize = true;
            this.myOperationTimeLabelForAdd.Location = new System.Drawing.Point(69, 185);
            this.myOperationTimeLabelForAdd.Name = "myOperationTimeLabelForAdd";
            this.myOperationTimeLabelForAdd.Size = new System.Drawing.Size(35, 13);
            this.myOperationTimeLabelForAdd.TabIndex = 9;
            this.myOperationTimeLabelForAdd.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // cOperationTimeLabelForAdd
            // 
            this.cOperationTimeLabelForAdd.AutoSize = true;
            this.cOperationTimeLabelForAdd.Location = new System.Drawing.Point(308, 185);
            this.cOperationTimeLabelForAdd.Name = "cOperationTimeLabelForAdd";
            this.cOperationTimeLabelForAdd.Size = new System.Drawing.Size(35, 13);
            this.cOperationTimeLabelForAdd.TabIndex = 11;
            this.cOperationTimeLabelForAdd.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 489);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cOperationTimeLabelForAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label myOperationTimeLabelForAdd;
        private System.Windows.Forms.Button cRemoveValueButton;
        private System.Windows.Forms.Button cAddValueButton;
        private System.Windows.Forms.Button myRemoveValueButton;
        private System.Windows.Forms.Button myAddValueButton;
        private System.Windows.Forms.Label cProjectName;
        private System.Windows.Forms.Label myProjectName;
        private System.Windows.Forms.TextBox cInputValueTextBox;
        private System.Windows.Forms.TextBox myInputValueTextBox;
        private System.Windows.Forms.ComboBox choosingProjectComboBox;
    }
}

