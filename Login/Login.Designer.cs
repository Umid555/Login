namespace Login
{
    partial class Login
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lbl_access = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.timer_acc_den = new System.Windows.Forms.Timer(this.components);
            this.btn_help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_name.Location = new System.Drawing.Point(202, 51);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(290, 23);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderSize = 3;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_login.Location = new System.Drawing.Point(202, 172);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(135, 43);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_surname
            // 
            this.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_surname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_surname.Location = new System.Drawing.Point(202, 90);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(290, 23);
            this.txt_surname.TabIndex = 1;
            this.txt_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_access
            // 
            this.lbl_access.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_access.AutoSize = true;
            this.lbl_access.BackColor = System.Drawing.Color.Transparent;
            this.lbl_access.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_access.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_access.Location = new System.Drawing.Point(115, 239);
            this.lbl_access.Name = "lbl_access";
            this.lbl_access.Size = new System.Drawing.Size(418, 58);
            this.lbl_access.TabIndex = 5;
            this.lbl_access.Text = "ACCESS DENIED";
            this.lbl_access.Visible = false;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_password.Location = new System.Drawing.Point(202, 129);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(290, 23);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.Location = new System.Drawing.Point(115, 49);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(81, 25);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_surname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_surname.Location = new System.Drawing.Point(83, 88);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(113, 25);
            this.lbl_surname.TabIndex = 7;
            this.lbl_surname.Text = "Surname:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_password.Location = new System.Drawing.Point(73, 127);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(123, 25);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password:";
            // 
            // btn_register
            // 
            this.btn_register.FlatAppearance.BorderSize = 3;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_register.Location = new System.Drawing.Point(357, 172);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(135, 43);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // timer_acc_den
            // 
            this.timer_acc_den.Interval = 400;
            this.timer_acc_den.Tick += new System.EventHandler(this.timer_acc_den_Tick);
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.Transparent;
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_help.Location = new System.Drawing.Point(594, -1);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(40, 23);
            this.btn_help.TabIndex = 9;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_access);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lbl_access;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Timer timer_acc_den;
        private System.Windows.Forms.Button btn_help;
    }
}

