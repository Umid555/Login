namespace Login
{
    partial class Profile
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
            this.rtb_file = new System.Windows.Forms.RichTextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_profsurname = new System.Windows.Forms.Label();
            this.lbl_profname = new System.Windows.Forms.Label();
            this.pn_photo = new System.Windows.Forms.Panel();
            this.lbl_hi = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_profclear = new System.Windows.Forms.Button();
            this.pn_photo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_file
            // 
            this.rtb_file.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtb_file.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_file.ForeColor = System.Drawing.Color.Green;
            this.rtb_file.Location = new System.Drawing.Point(12, 12);
            this.rtb_file.Name = "rtb_file";
            this.rtb_file.Size = new System.Drawing.Size(734, 437);
            this.rtb_file.TabIndex = 10;
            this.rtb_file.Text = "";
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.SystemColors.Control;
            this.btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_read.Location = new System.Drawing.Point(765, 248);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(123, 60);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.Control;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_update.Location = new System.Drawing.Point(765, 314);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(123, 60);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Write";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_profsurname
            // 
            this.lbl_profsurname.AutoSize = true;
            this.lbl_profsurname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_profsurname.Location = new System.Drawing.Point(3, 80);
            this.lbl_profsurname.Name = "lbl_profsurname";
            this.lbl_profsurname.Size = new System.Drawing.Size(86, 23);
            this.lbl_profsurname.TabIndex = 2;
            this.lbl_profsurname.Text = "Surname";
            // 
            // lbl_profname
            // 
            this.lbl_profname.AutoSize = true;
            this.lbl_profname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_profname.Location = new System.Drawing.Point(3, 51);
            this.lbl_profname.Name = "lbl_profname";
            this.lbl_profname.Size = new System.Drawing.Size(59, 23);
            this.lbl_profname.TabIndex = 1;
            this.lbl_profname.Text = "Name";
            // 
            // pn_photo
            // 
            this.pn_photo.BackColor = System.Drawing.Color.Yellow;
            this.pn_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pn_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_photo.Controls.Add(this.lbl_hi);
            this.pn_photo.Controls.Add(this.lbl_profname);
            this.pn_photo.Controls.Add(this.lbl_profsurname);
            this.pn_photo.Location = new System.Drawing.Point(765, 12);
            this.pn_photo.Name = "pn_photo";
            this.pn_photo.Size = new System.Drawing.Size(123, 121);
            this.pn_photo.TabIndex = 0;
            // 
            // lbl_hi
            // 
            this.lbl_hi.AutoSize = true;
            this.lbl_hi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_hi.Location = new System.Drawing.Point(3, 21);
            this.lbl_hi.Name = "lbl_hi";
            this.lbl_hi.Size = new System.Drawing.Size(33, 23);
            this.lbl_hi.TabIndex = 3;
            this.lbl_hi.Text = "Hi,";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.Location = new System.Drawing.Point(765, 380);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(123, 60);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_profclear
            // 
            this.btn_profclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_profclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_profclear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_profclear.Location = new System.Drawing.Point(765, 139);
            this.btn_profclear.Name = "btn_profclear";
            this.btn_profclear.Size = new System.Drawing.Size(123, 60);
            this.btn_profclear.TabIndex = 12;
            this.btn_profclear.Text = "Clear Profile";
            this.btn_profclear.UseVisualStyleBackColor = false;
            this.btn_profclear.Click += new System.EventHandler(this.btn_profclear_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 470);
            this.Controls.Add(this.btn_profclear);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.pn_photo);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.rtb_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            this.pn_photo.ResumeLayout(false);
            this.pn_photo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_file;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_profsurname;
        private System.Windows.Forms.Label lbl_profname;
        private System.Windows.Forms.Panel pn_photo;
        private System.Windows.Forms.Label lbl_hi;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_profclear;
    }
}