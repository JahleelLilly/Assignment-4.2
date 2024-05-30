namespace Assignment_4._2
{
    partial class AccountLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnterButton = new Button();
            AddStudentbutton = new Button();
            Exitbutton = new Button();
            SuspendLayout();
            // 
            // EnterButton
            // 
            EnterButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnterButton.Location = new Point(640, 24);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(138, 39);
            EnterButton.TabIndex = 4;
            EnterButton.Text = "ENTER";
            EnterButton.UseMnemonic = false;
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // AddStudentbutton
            // 
            AddStudentbutton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddStudentbutton.Location = new Point(12, 24);
            AddStudentbutton.Name = "AddStudentbutton";
            AddStudentbutton.Size = new Size(151, 39);
            AddStudentbutton.TabIndex = 5;
            AddStudentbutton.Text = "Add Student";
            AddStudentbutton.UseMnemonic = false;
            AddStudentbutton.UseVisualStyleBackColor = true;
            AddStudentbutton.Click += AddStudentbutton_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exitbutton.Location = new Point(496, 24);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(138, 39);
            Exitbutton.TabIndex = 6;
            Exitbutton.Text = "EXIT";
            Exitbutton.UseMnemonic = false;
            Exitbutton.UseVisualStyleBackColor = true;
            Exitbutton.Click += Exitbutton_Click;
            // 
            // AccountLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exitbutton);
            Controls.Add(AddStudentbutton);
            Controls.Add(EnterButton);
            DoubleBuffered = true;
            Name = "AccountLogin";
            Text = "Account Login";
            ResumeLayout(false);
        }

        #endregion
        private Button EnterButton;
        private Button AddStudentbutton;
        private Button Exitbutton;
    }
}
