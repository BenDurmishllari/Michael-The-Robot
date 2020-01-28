namespace Michael_The_Robot___remote_control__
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblUserName = new MaterialSkin.Controls.MaterialLabel();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogIn = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblCopyright = new MaterialSkin.Controls.MaterialLabel();
            this.chkShow = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnCreateAccount = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(228, 208);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 39);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(228, 262);
            this.txtPassWord.Multiline = true;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(200, 39);
            this.txtPassWord.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Depth = 0;
            this.lblUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserName.Location = new System.Drawing.Point(23, 215);
            this.lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(144, 32);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPassword.Location = new System.Drawing.Point(23, 269);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(130, 32);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnLogIn
            // 
            this.btnLogIn.AutoSize = true;
            this.btnLogIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogIn.Depth = 0;
            this.btnLogIn.Location = new System.Drawing.Point(260, 367);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Primary = false;
            this.btnLogIn.Size = new System.Drawing.Size(91, 36);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Depth = 0;
            this.lblCopyright.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCopyright.Location = new System.Drawing.Point(254, 444);
            this.lblCopyright.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(85, 32);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "© Ben";
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Depth = 0;
            this.chkShow.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkShow.Location = new System.Drawing.Point(431, 239);
            this.chkShow.Margin = new System.Windows.Forms.Padding(0);
            this.chkShow.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkShow.Name = "chkShow";
            this.chkShow.Ripple = true;
            this.chkShow.Size = new System.Drawing.Size(93, 30);
            this.chkShow.TabIndex = 7;
            this.chkShow.Text = "Show";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.AutoSize = true;
            this.btnCreateAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.Window;
            this.btnCreateAccount.Depth = 0;
            this.btnCreateAccount.Location = new System.Drawing.Point(207, 319);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Primary = false;
            this.btnCreateAccount.Size = new System.Drawing.Size(221, 36);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 494);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Name = "Form1";
            this.Text = "Michael remote control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialFlatButton btnLogIn;
        private MaterialSkin.Controls.MaterialLabel lblCopyright;
        private MaterialSkin.Controls.MaterialCheckBox chkShow;
        private MaterialSkin.Controls.MaterialFlatButton btnCreateAccount;
    }
}

