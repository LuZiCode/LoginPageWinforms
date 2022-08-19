namespace LoginPageWinForms
{
    partial class CreateAccountPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountPage));
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.toolTipUsername = new System.Windows.Forms.ToolTip(this.components);
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.toolTipEmail = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.hidePasswordButton = new System.Windows.Forms.Button();
            this.hidePasswordButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(308, 191);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(228, 20);
            this.lastnameTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lastname*";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(308, 146);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(228, 20);
            this.firstnameTextBox.TabIndex = 8;
            this.firstnameTextBox.TextChanged += new System.EventHandler(this.firstnameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Firstname*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "CREATE ACCOUNT";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(308, 282);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(228, 20);
            this.usernameTextBox.TabIndex = 14;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username*";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(308, 237);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(228, 20);
            this.emailTextBox.TabIndex = 12;
            this.emailTextBox.TextChanged += new System.EventHandler(this.firstnameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email*";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(308, 328);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(207, 20);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password*";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(308, 366);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 17;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameLabel.Location = new System.Drawing.Point(523, 266);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(13, 13);
            this.usernameLabel.TabIndex = 19;
            this.usernameLabel.Text = "?";
            this.usernameLabel.MouseEnter += new System.EventHandler(this.usernameLabel_MouseEnter);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailLabel.Location = new System.Drawing.Point(523, 221);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(13, 13);
            this.emailLabel.TabIndex = 20;
            this.emailLabel.Text = "?";
            this.emailLabel.MouseEnter += new System.EventHandler(this.emailLabel_MouseEnter);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordLabel.Location = new System.Drawing.Point(523, 312);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(13, 13);
            this.passwordLabel.TabIndex = 21;
            this.passwordLabel.Text = "?";
            this.passwordLabel.MouseEnter += new System.EventHandler(this.passwordLabel_MouseEnter);
            // 
            // hidePasswordButton
            // 
            this.hidePasswordButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hidePasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidePasswordButton.BackgroundImage")));
            this.hidePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hidePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidePasswordButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hidePasswordButton.Location = new System.Drawing.Point(514, 328);
            this.hidePasswordButton.Name = "hidePasswordButton";
            this.hidePasswordButton.Size = new System.Drawing.Size(22, 20);
            this.hidePasswordButton.TabIndex = 22;
            this.hidePasswordButton.UseVisualStyleBackColor = false;
            this.hidePasswordButton.Click += new System.EventHandler(this.hidePasswordButton_Click);
            // 
            // hidePasswordButton2
            // 
            this.hidePasswordButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hidePasswordButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidePasswordButton2.BackgroundImage")));
            this.hidePasswordButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hidePasswordButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidePasswordButton2.Location = new System.Drawing.Point(514, 328);
            this.hidePasswordButton2.Name = "hidePasswordButton2";
            this.hidePasswordButton2.Size = new System.Drawing.Size(22, 20);
            this.hidePasswordButton2.TabIndex = 23;
            this.hidePasswordButton2.UseVisualStyleBackColor = false;
            this.hidePasswordButton2.Click += new System.EventHandler(this.hidePasswordButton2_Click);
            // 
            // CreateAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hidePasswordButton2);
            this.Controls.Add(this.hidePasswordButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccountPage";
            this.Text = "CreateAccountPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ToolTip toolTipUsername;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ToolTip toolTipEmail;
        private System.Windows.Forms.ToolTip toolTipPassword;
        private System.Windows.Forms.Button hidePasswordButton;
        private System.Windows.Forms.Button hidePasswordButton2;
    }
}