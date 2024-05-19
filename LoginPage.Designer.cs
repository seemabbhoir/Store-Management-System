namespace LoginForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.picloginimg = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkpass = new System.Windows.Forms.CheckBox();
            this.lbtrole = new System.Windows.Forms.Label();
            this.cmdRole = new System.Windows.Forms.ComboBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picloginimg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picloginimg
            // 
            this.picloginimg.Image = global::LoginForm.Properties.Resources.loginimg;
            this.picloginimg.Location = new System.Drawing.Point(0, 2);
            this.picloginimg.Name = "picloginimg";
            this.picloginimg.Size = new System.Drawing.Size(206, 247);
            this.picloginimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picloginimg.TabIndex = 4;
            this.picloginimg.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.chkpass);
            this.groupBox1.Controls.Add(this.lbtrole);
            this.groupBox1.Controls.Add(this.cmdRole);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.lblusername);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(212, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 247);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // chkpass
            // 
            this.chkpass.AutoSize = true;
            this.chkpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpass.ForeColor = System.Drawing.Color.Indigo;
            this.chkpass.Location = new System.Drawing.Point(135, 149);
            this.chkpass.Name = "chkpass";
            this.chkpass.Size = new System.Drawing.Size(102, 17);
            this.chkpass.TabIndex = 13;
            this.chkpass.Text = "Show Password";
            this.chkpass.UseVisualStyleBackColor = true;
            this.chkpass.CheckedChanged += new System.EventHandler(this.chkpass_CheckedChanged);
            // 
            // lbtrole
            // 
            this.lbtrole.AutoSize = true;
            this.lbtrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrole.Location = new System.Drawing.Point(25, 29);
            this.lbtrole.Name = "lbtrole";
            this.lbtrole.Size = new System.Drawing.Size(41, 17);
            this.lbtrole.TabIndex = 10;
            this.lbtrole.Text = "Role";
            // 
            // cmdRole
            // 
            this.cmdRole.FormattingEnabled = true;
            this.cmdRole.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.cmdRole.Location = new System.Drawing.Point(135, 22);
            this.cmdRole.Name = "cmdRole";
            this.cmdRole.Size = new System.Drawing.Size(133, 24);
            this.cmdRole.TabIndex = 9;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(25, 126);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(77, 17);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(25, 79);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(88, 17);
            this.lblusername.TabIndex = 4;
            this.lblusername.Text = "User Name";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(135, 193);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Loging";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(135, 120);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(133, 23);
            this.txtPass.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(135, 73);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(133, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 247);
            this.Controls.Add(this.picloginimg);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picloginimg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picloginimg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblusername;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbtrole;
        public System.Windows.Forms.ComboBox cmdRole;
        private System.Windows.Forms.CheckBox chkpass;
    }
}

