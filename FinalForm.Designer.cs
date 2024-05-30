namespace Assignment_4._2
{
    partial class FinalForm
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
            PasswordTextBox = new TextBox();
            UserIdTextBox = new TextBox();
            label2 = new Label();
            UserID = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.Location = new Point(316, 119);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(222, 39);
            PasswordTextBox.TabIndex = 7;
            // 
            // UserIdTextBox
            // 
            UserIdTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserIdTextBox.Location = new Point(316, 67);
            UserIdTextBox.Name = "UserIdTextBox";
            UserIdTextBox.Size = new Size(222, 39);
            UserIdTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 122);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 5;
            label2.Text = "Password :";
            // 
            // UserID
            // 
            UserID.AutoSize = true;
            UserID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserID.Location = new Point(144, 70);
            UserID.Name = "UserID";
            UserID.Size = new Size(103, 32);
            UserID.TabIndex = 4;
            UserID.Text = "User ID :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(316, 222);
            button1.Name = "button1";
            button1.Size = new Size(165, 44);
            button1.TabIndex = 8;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FinalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserIdTextBox);
            Controls.Add(label2);
            Controls.Add(UserID);
            Name = "FinalForm";
            Text = "FinalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordTextBox;
        private Label label2;
        private Label UserID;
        private Button button1;
        public TextBox UserIdTextBox;
    }
}