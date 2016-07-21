namespace LibraryCatalogue
{
    partial class frmMain
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
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.txtPassword_Login = new System.Windows.Forms.TextBox();
            this.txtUsername_Login = new System.Windows.Forms.TextBox();
            this.lblPassword_Login = new System.Windows.Forms.Label();
            this.lblUsername_Login = new System.Windows.Forms.Label();
            this.btnLogin_Login = new System.Windows.Forms.Button();
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxLogin.SuspendLayout();
            this.gbxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.txtPassword_Login);
            this.gbxLogin.Controls.Add(this.txtUsername_Login);
            this.gbxLogin.Controls.Add(this.lblPassword_Login);
            this.gbxLogin.Controls.Add(this.lblUsername_Login);
            this.gbxLogin.Controls.Add(this.btnLogin_Login);
            this.gbxLogin.Location = new System.Drawing.Point(12, 12);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(405, 335);
            this.gbxLogin.TabIndex = 0;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Login";
            // 
            // txtPassword_Login
            // 
            this.txtPassword_Login.Location = new System.Drawing.Point(151, 105);
            this.txtPassword_Login.Name = "txtPassword_Login";
            this.txtPassword_Login.Size = new System.Drawing.Size(158, 20);
            this.txtPassword_Login.TabIndex = 4;
            // 
            // txtUsername_Login
            // 
            this.txtUsername_Login.Location = new System.Drawing.Point(151, 53);
            this.txtUsername_Login.Name = "txtUsername_Login";
            this.txtUsername_Login.Size = new System.Drawing.Size(158, 20);
            this.txtUsername_Login.TabIndex = 3;
            // 
            // lblPassword_Login
            // 
            this.lblPassword_Login.AutoSize = true;
            this.lblPassword_Login.Location = new System.Drawing.Point(83, 108);
            this.lblPassword_Login.Name = "lblPassword_Login";
            this.lblPassword_Login.Size = new System.Drawing.Size(59, 13);
            this.lblPassword_Login.TabIndex = 2;
            this.lblPassword_Login.Text = "Password: ";
            // 
            // lblUsername_Login
            // 
            this.lblUsername_Login.AutoSize = true;
            this.lblUsername_Login.Location = new System.Drawing.Point(83, 56);
            this.lblUsername_Login.Name = "lblUsername_Login";
            this.lblUsername_Login.Size = new System.Drawing.Size(61, 13);
            this.lblUsername_Login.TabIndex = 1;
            this.lblUsername_Login.Text = "Username: ";
            // 
            // btnLogin_Login
            // 
            this.btnLogin_Login.Location = new System.Drawing.Point(151, 168);
            this.btnLogin_Login.Name = "btnLogin_Login";
            this.btnLogin_Login.Size = new System.Drawing.Size(75, 23);
            this.btnLogin_Login.TabIndex = 0;
            this.btnLogin_Login.Text = "button1";
            this.btnLogin_Login.UseVisualStyleBackColor = true;
            // 
            // gbxMain
            // 
            this.gbxMain.Controls.Add(this.textBox1);
            this.gbxMain.Controls.Add(this.textBox2);
            this.gbxMain.Controls.Add(this.label1);
            this.gbxMain.Controls.Add(this.label2);
            this.gbxMain.Controls.Add(this.button1);
            this.gbxMain.Location = new System.Drawing.Point(423, 12);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(405, 335);
            this.gbxMain.TabIndex = 1;
            this.gbxMain.TabStop = false;
            this.gbxMain.Text = "Main  Menu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 639);
            this.Controls.Add(this.gbxMain);
            this.Controls.Add(this.gbxLogin);
            this.Name = "frmMain";
            this.Text = "Echo Holdings | Login";
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.gbxMain.ResumeLayout(false);
            this.gbxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.TextBox txtPassword_Login;
        private System.Windows.Forms.TextBox txtUsername_Login;
        private System.Windows.Forms.Label lblPassword_Login;
        private System.Windows.Forms.Label lblUsername_Login;
        private System.Windows.Forms.Button btnLogin_Login;
        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

