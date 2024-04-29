namespace Merch
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
            this.login_panel = new System.Windows.Forms.Panel();
            this.forgotpass = new System.Windows.Forms.LinkLabel();
            this.submit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userinput = new System.Windows.Forms.Label();
            this.SignUp_panel = new System.Windows.Forms.Panel();
            this.signin = new System.Windows.Forms.Button();
            this.hav_account = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.login_panel.SuspendLayout();
            this.SignUp_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.login_panel);
            this.panel1.Controls.Add(this.SignUp_panel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 405);
            this.panel1.TabIndex = 0;
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.forgotpass);
            this.login_panel.Controls.Add(this.submit);
            this.login_panel.Controls.Add(this.checkBox1);
            this.login_panel.Controls.Add(this.label2);
            this.login_panel.Controls.Add(this.password);
            this.login_panel.Controls.Add(this.name);
            this.login_panel.Controls.Add(this.label1);
            this.login_panel.Controls.Add(this.userinput);
            this.login_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_panel.Location = new System.Drawing.Point(282, 3);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(375, 399);
            this.login_panel.TabIndex = 1;
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpass.Location = new System.Drawing.Point(131, 311);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(105, 12);
            this.forgotpass.TabIndex = 8;
            this.forgotpass.TabStop = true;
            this.forgotpass.Text = "Forgot Password?";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Location = new System.Drawing.Point(132, 326);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(104, 27);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(213, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show Password?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "LOG IN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(43, 236);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(287, 20);
            this.password.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(43, 189);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(287, 20);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userinput
            // 
            this.userinput.AutoSize = true;
            this.userinput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userinput.Location = new System.Drawing.Point(41, 174);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(62, 12);
            this.userinput.TabIndex = 0;
            this.userinput.Text = "Username";
            // 
            // SignUp_panel
            // 
            this.SignUp_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(121)))));
            this.SignUp_panel.Controls.Add(this.signin);
            this.SignUp_panel.Controls.Add(this.hav_account);
            this.SignUp_panel.Controls.Add(this.label3);
            this.SignUp_panel.Controls.Add(this.pictureBox1);
            this.SignUp_panel.Controls.Add(this.welcome);
            this.SignUp_panel.Location = new System.Drawing.Point(3, 3);
            this.SignUp_panel.Name = "SignUp_panel";
            this.SignUp_panel.Size = new System.Drawing.Size(280, 399);
            this.SignUp_panel.TabIndex = 0;
            this.SignUp_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.SignUp_panel_Paint);
            // 
            // signin
            // 
            this.signin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.Black;
            this.signin.Location = new System.Drawing.Point(86, 315);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(104, 27);
            this.signin.TabIndex = 9;
            this.signin.Text = "Sign Up";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // hav_account
            // 
            this.hav_account.AutoSize = true;
            this.hav_account.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hav_account.ForeColor = System.Drawing.Color.White;
            this.hav_account.Location = new System.Drawing.Point(65, 300);
            this.hav_account.Name = "hav_account";
            this.hav_account.Size = new System.Drawing.Size(150, 12);
            this.hav_account.TabIndex = 8;
            this.hav_account.Text = "Already have an account?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "CircUITS Collection";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(52, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 97);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(44, 88);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(197, 43);
            this.welcome.TabIndex = 5;
            this.welcome.Text = "Welcome!";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcome.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.SignUp_panel.ResumeLayout(false);
            this.SignUp_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label userinput;
        private System.Windows.Forms.Panel SignUp_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.LinkLabel forgotpass;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Label hav_account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

