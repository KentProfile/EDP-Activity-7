namespace Merch
{
    partial class dashboards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboards));
            this.sidebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.navbar = new System.Windows.Forms.Panel();
            this.profile = new System.Windows.Forms.PictureBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(121)))));
            this.sidebar.Controls.Add(this.label1);
            this.sidebar.Controls.Add(this.logout);
            this.sidebar.Controls.Add(this.account);
            this.sidebar.Controls.Add(this.about);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.dashboard);
            this.sidebar.Controls.Add(this.logo);
            this.sidebar.Location = new System.Drawing.Point(-1, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(248, 627);
            this.sidebar.TabIndex = 0;
            this.sidebar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(77, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "CirCol.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(0, 592);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(248, 35);
            this.logout.TabIndex = 6;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // account
            // 
            this.account.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(44, 378);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(159, 35);
            this.account.TabIndex = 5;
            this.account.Text = "Account";
            this.account.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(44, 325);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(159, 35);
            this.about.TabIndex = 4;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(44, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Merch";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Location = new System.Drawing.Point(44, 221);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(159, 35);
            this.dashboard.TabIndex = 2;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(26, 107);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 61);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.navbar.Controls.Add(this.profile);
            this.navbar.Location = new System.Drawing.Point(247, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(880, 55);
            this.navbar.TabIndex = 1;
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(812, 2);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(56, 50);
            this.profile.TabIndex = 0;
            this.profile.TabStop = false;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dashboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 627);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboards";
            this.Text = "dashboards";
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    }
}