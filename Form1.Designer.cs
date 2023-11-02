namespace db
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.signuplabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Users = new System.Windows.Forms.DataGridView();
            this.showUsers = new System.Windows.Forms.Button();
            this.showUsersLAbel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(327, 72);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(142, 22);
            this.username.TabIndex = 0;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(327, 115);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(142, 22);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(359, 143);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 27);
            this.login.TabIndex = 2;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(398, 184);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(75, 27);
            this.signup.TabIndex = 3;
            this.signup.Text = "signup";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // signuplabel
            // 
            this.signuplabel.AutoSize = true;
            this.signuplabel.Location = new System.Drawing.Point(243, 189);
            this.signuplabel.Name = "signuplabel";
            this.signuplabel.Size = new System.Drawing.Size(137, 16);
            this.signuplabel.TabIndex = 4;
            this.signuplabel.Text = "don\'t have an account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "login page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "password";
            // 
            // Users
            // 
            this.Users.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users.Location = new System.Drawing.Point(206, 276);
            this.Users.Name = "Users";
            this.Users.RowHeadersWidth = 51;
            this.Users.Size = new System.Drawing.Size(329, 150);
            this.Users.TabIndex = 8;
            this.Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_CellContentClick);
            // 
            // showUsers
            // 
            this.showUsers.Location = new System.Drawing.Point(246, 243);
            this.showUsers.Name = "showUsers";
            this.showUsers.Size = new System.Drawing.Size(95, 27);
            this.showUsers.TabIndex = 9;
            this.showUsers.Text = "click here";
            this.showUsers.UseVisualStyleBackColor = true;
            this.showUsers.Click += new System.EventHandler(this.showUsers_Click);
            // 
            // showUsersLAbel
            // 
            this.showUsersLAbel.AutoSize = true;
            this.showUsersLAbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUsersLAbel.Location = new System.Drawing.Point(347, 245);
            this.showUsersLAbel.Name = "showUsersLAbel";
            this.showUsersLAbel.Size = new System.Drawing.Size(136, 20);
            this.showUsersLAbel.TabIndex = 10;
            this.showUsersLAbel.Text = "to show all users";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showUsersLAbel);
            this.Controls.Add(this.showUsers);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signuplabel);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label signuplabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView Users;
        private System.Windows.Forms.Button showUsers;
        private System.Windows.Forms.Label showUsersLAbel;
    }
}

