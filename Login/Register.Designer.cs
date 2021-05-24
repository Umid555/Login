namespace Login
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
            this.btn_backlogin = new System.Windows.Forms.Button();
            this.txt_name2 = new System.Windows.Forms.TextBox();
            this.lbl_pswagain = new System.Windows.Forms.Label();
            this.btn_register2 = new System.Windows.Forms.Button();
            this.txt_pswagain = new System.Windows.Forms.TextBox();
            this.lbl_password2 = new System.Windows.Forms.Label();
            this.lbl_surname2 = new System.Windows.Forms.Label();
            this.lbl_name2 = new System.Windows.Forms.Label();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.txt_surname2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btn_backlogin);
            this.panel1.Controls.Add(this.txt_name2);
            this.panel1.Controls.Add(this.lbl_pswagain);
            this.panel1.Controls.Add(this.btn_register2);
            this.panel1.Controls.Add(this.txt_pswagain);
            this.panel1.Controls.Add(this.lbl_password2);
            this.panel1.Controls.Add(this.lbl_surname2);
            this.panel1.Controls.Add(this.lbl_name2);
            this.panel1.Controls.Add(this.txt_password2);
            this.panel1.Controls.Add(this.txt_surname2);
            this.panel1.Location = new System.Drawing.Point(78, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 283);
            this.panel1.TabIndex = 0;
            // 
            // btn_backlogin
            // 
            this.btn_backlogin.FlatAppearance.BorderSize = 3;
            this.btn_backlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_backlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_backlogin.Location = new System.Drawing.Point(69, 212);
            this.btn_backlogin.Name = "btn_backlogin";
            this.btn_backlogin.Size = new System.Drawing.Size(177, 43);
            this.btn_backlogin.TabIndex = 6;
            this.btn_backlogin.Text = "Back to login";
            this.btn_backlogin.UseVisualStyleBackColor = true;
            this.btn_backlogin.Click += new System.EventHandler(this.btn_backlogin_Click);
            // 
            // txt_name2
            // 
            this.txt_name2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_name2.Location = new System.Drawing.Point(209, 32);
            this.txt_name2.Name = "txt_name2";
            this.txt_name2.Size = new System.Drawing.Size(239, 23);
            this.txt_name2.TabIndex = 1;
            this.txt_name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_pswagain
            // 
            this.lbl_pswagain.AutoSize = true;
            this.lbl_pswagain.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pswagain.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_pswagain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_pswagain.Location = new System.Drawing.Point(16, 145);
            this.lbl_pswagain.Name = "lbl_pswagain";
            this.lbl_pswagain.Size = new System.Drawing.Size(187, 25);
            this.lbl_pswagain.TabIndex = 19;
            this.lbl_pswagain.Text = "Password again:";
            // 
            // btn_register2
            // 
            this.btn_register2.FlatAppearance.BorderSize = 3;
            this.btn_register2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_register2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_register2.Location = new System.Drawing.Point(297, 212);
            this.btn_register2.Name = "btn_register2";
            this.btn_register2.Size = new System.Drawing.Size(135, 43);
            this.btn_register2.TabIndex = 5;
            this.btn_register2.Text = "Register";
            this.btn_register2.UseVisualStyleBackColor = true;
            this.btn_register2.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_pswagain
            // 
            this.txt_pswagain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pswagain.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_pswagain.Location = new System.Drawing.Point(209, 147);
            this.txt_pswagain.Name = "txt_pswagain";
            this.txt_pswagain.PasswordChar = '•';
            this.txt_pswagain.Size = new System.Drawing.Size(239, 23);
            this.txt_pswagain.TabIndex = 4;
            this.txt_pswagain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_password2
            // 
            this.lbl_password2.AutoSize = true;
            this.lbl_password2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_password2.Location = new System.Drawing.Point(80, 108);
            this.lbl_password2.Name = "lbl_password2";
            this.lbl_password2.Size = new System.Drawing.Size(123, 25);
            this.lbl_password2.TabIndex = 16;
            this.lbl_password2.Text = "Password:";
            // 
            // lbl_surname2
            // 
            this.lbl_surname2.AutoSize = true;
            this.lbl_surname2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_surname2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_surname2.Location = new System.Drawing.Point(90, 71);
            this.lbl_surname2.Name = "lbl_surname2";
            this.lbl_surname2.Size = new System.Drawing.Size(113, 25);
            this.lbl_surname2.TabIndex = 15;
            this.lbl_surname2.Text = "Surname:";
            // 
            // lbl_name2
            // 
            this.lbl_name2.AutoSize = true;
            this.lbl_name2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name2.Location = new System.Drawing.Point(122, 30);
            this.lbl_name2.Name = "lbl_name2";
            this.lbl_name2.Size = new System.Drawing.Size(81, 25);
            this.lbl_name2.TabIndex = 14;
            this.lbl_name2.Text = "Name:";
            // 
            // txt_password2
            // 
            this.txt_password2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_password2.Location = new System.Drawing.Point(209, 110);
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.PasswordChar = '•';
            this.txt_password2.Size = new System.Drawing.Size(239, 23);
            this.txt_password2.TabIndex = 3;
            this.txt_password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_surname2
            // 
            this.txt_surname2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_surname2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_surname2.Location = new System.Drawing.Point(209, 71);
            this.txt_surname2.Name = "txt_surname2";
            this.txt_surname2.Size = new System.Drawing.Size(239, 23);
            this.txt_surname2.TabIndex = 2;
            this.txt_surname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_register2;
        private System.Windows.Forms.Label lbl_password2;
        private System.Windows.Forms.Label lbl_surname2;
        private System.Windows.Forms.Label lbl_name2;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.TextBox txt_surname2;
        private System.Windows.Forms.Label lbl_pswagain;
        private System.Windows.Forms.TextBox txt_pswagain;
        private System.Windows.Forms.TextBox txt_name2;
        private System.Windows.Forms.Button btn_backlogin;
    }
}