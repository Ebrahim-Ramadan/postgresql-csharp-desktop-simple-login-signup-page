namespace db
{
    partial class Form2
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
            this.signupusername = new System.Windows.Forms.TextBox();
            this.signuppassword = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.signuppage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signupusername
            // 
            this.signupusername.Location = new System.Drawing.Point(251, 120);
            this.signupusername.Name = "signupusername";
            this.signupusername.Size = new System.Drawing.Size(171, 22);
            this.signupusername.TabIndex = 0;
            this.signupusername.TextChanged += new System.EventHandler(this.signupusername_TextChanged);
            // 
            // signuppassword
            // 
            this.signuppassword.Location = new System.Drawing.Point(251, 164);
            this.signuppassword.Name = "signuppassword";
            this.signuppassword.Size = new System.Drawing.Size(171, 22);
            this.signuppassword.TabIndex = 1;
            this.signuppassword.TextChanged += new System.EventHandler(this.signuppassword_TextChanged);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(311, 210);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(87, 31);
            this.signup.TabIndex = 2;
            this.signup.Text = "signup";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // signuppage
            // 
            this.signuppage.AutoSize = true;
            this.signuppage.Location = new System.Drawing.Point(323, 69);
            this.signuppage.Name = "signuppage";
            this.signuppage.Size = new System.Drawing.Size(85, 16);
            this.signuppage.TabIndex = 3;
            this.signuppage.Text = "sign up page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signuppage);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.signuppassword);
            this.Controls.Add(this.signupusername);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox signupusername;
        private System.Windows.Forms.TextBox signuppassword;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label signuppage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}