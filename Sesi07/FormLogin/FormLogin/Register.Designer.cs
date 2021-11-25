
namespace FormLogin
{
    partial class Register
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHaveAccount = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.lblHaveAccount);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(197, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nama";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(177, 136);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(179, 195);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(282, 267);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(404, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHaveAccount
            // 
            this.lblHaveAccount.AutoSize = true;
            this.lblHaveAccount.Location = new System.Drawing.Point(279, 363);
            this.lblHaveAccount.Name = "lblHaveAccount";
            this.lblHaveAccount.Size = new System.Drawing.Size(96, 13);
            this.lblHaveAccount.TabIndex = 5;
            this.lblHaveAccount.Text = "Have an account?";
            // 
            // lblLogin
            // 
            this.lblLogin.Location = new System.Drawing.Point(404, 358);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(75, 23);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login";
            this.lblLogin.UseVisualStyleBackColor = true;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(404, 76);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(404, 136);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(195, 20);
            this.textBoxUsername.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(404, 195);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(195, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button lblLogin;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
    }
}