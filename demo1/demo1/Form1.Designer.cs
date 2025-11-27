namespace demo1
{
    partial class Form1
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
            lbUserName = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lbPassword = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(120, 64);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(81, 20);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "UserName:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(229, 59);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(241, 27);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(229, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(120, 140);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(243, 206);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtUserName);
            Controls.Add(lbUserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxUserName;

        private Label lbUserName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lbPassword;
        private Button button1;
    }
}
