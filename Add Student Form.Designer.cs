namespace Assignment_4._2
{
    partial class Add_Student_Form
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
            StudentIDLabel = new Label();
            StudentNameLabel = new Label();
            GPALabel = new Label();
            StudentIdTextbox = new TextBox();
            GpaTextbox = new TextBox();
            StudentNameTextbox = new TextBox();
            AddStudentbotton = new Button();
            SuspendLayout();
            // 
            // StudentIDLabel
            // 
            StudentIDLabel.AutoSize = true;
            StudentIDLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentIDLabel.Location = new Point(49, 9);
            StudentIDLabel.Name = "StudentIDLabel";
            StudentIDLabel.Size = new Size(94, 25);
            StudentIDLabel.TabIndex = 0;
            StudentIDLabel.Text = "StudentID";
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentNameLabel.Location = new Point(12, 50);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(131, 25);
            StudentNameLabel.TabIndex = 1;
            StudentNameLabel.Text = "Student Name";
            // 
            // GPALabel
            // 
            GPALabel.AutoSize = true;
            GPALabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GPALabel.Location = new Point(96, 90);
            GPALabel.Name = "GPALabel";
            GPALabel.Size = new Size(47, 25);
            GPALabel.TabIndex = 2;
            GPALabel.Text = "GPA";
            // 
            // StudentIdTextbox
            // 
            StudentIdTextbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentIdTextbox.Location = new Point(177, 6);
            StudentIdTextbox.Name = "StudentIdTextbox";
            StudentIdTextbox.Size = new Size(212, 33);
            StudentIdTextbox.TabIndex = 3;
            // 
            // GpaTextbox
            // 
            GpaTextbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GpaTextbox.Location = new Point(177, 87);
            GpaTextbox.Name = "GpaTextbox";
            GpaTextbox.Size = new Size(212, 33);
            GpaTextbox.TabIndex = 4;
            // 
            // StudentNameTextbox
            // 
            StudentNameTextbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentNameTextbox.Location = new Point(177, 47);
            StudentNameTextbox.Name = "StudentNameTextbox";
            StudentNameTextbox.Size = new Size(212, 33);
            StudentNameTextbox.TabIndex = 5;
            // 
            // AddStudentbotton
            // 
            AddStudentbotton.Location = new Point(177, 126);
            AddStudentbotton.Name = "AddStudentbotton";
            AddStudentbotton.Size = new Size(212, 41);
            AddStudentbotton.TabIndex = 6;
            AddStudentbotton.Text = "Add Student";
            AddStudentbotton.UseVisualStyleBackColor = true;
            AddStudentbotton.Click += AddStudentbotton_Click;
            // 
            // Add_Student_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddStudentbotton);
            Controls.Add(StudentNameTextbox);
            Controls.Add(GpaTextbox);
            Controls.Add(StudentIdTextbox);
            Controls.Add(GPALabel);
            Controls.Add(StudentNameLabel);
            Controls.Add(StudentIDLabel);
            Name = "Add_Student_Form";
            Text = "Add Student Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentIDLabel;
        private Label StudentNameLabel;
        private Label GPALabel;
        private TextBox StudentIdTextbox;
        private TextBox GpaTextbox;
        private TextBox StudentNameTextbox;
        private Button AddStudentbotton;
    }
}