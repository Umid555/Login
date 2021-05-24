using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        int yoxla = 0;
        public Login()
        {
            InitializeComponent();
        }

        int i = 1;

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_name.Text!=String.Empty&&txt_password.Text!=String.Empty&&txt_surname.Text!=String.Empty)
            {
                string path = txt_name.Text + "_" + txt_surname.Text + ".txt";
                bool checker = File.Exists(path);
                SoundPlayer player = new SoundPlayer();
                if (checker)
                {

                    string password = File.ReadAllLines(path).First();
                    if (txt_password.Text == password)
                    {
                        lbl_access.Text = "ACCESS GRANTED";
                        lbl_access.ForeColor = Color.DarkOliveGreen;
                        player.SoundLocation = "glitch.wav";
                        player.Play();
                        yoxla = 1;
                    }
                    else
                    {
                        if (lbl_access.Text == "ACCESS GRANTED")
                        {
                            lbl_access.Text = "ACCESS DENIED";
                            lbl_access.ForeColor = Color.DarkRed;
                        }
                        player.SoundLocation = "AccessDenied.wav";
                        player.Play();
                    }

                }
                else
                {
                    player.SoundLocation = "AccessDenied.wav";
                    player.Play();
                }
                lbl_access.Visible = true;
                timer_acc_den.Start();

            }
            else
            {
                MessageBox.Show("Please fill gaps!");
            }
            


        }

        private void timer_acc_den_Tick(object sender, EventArgs e)
        {
            if (i % 2 == 0)
                lbl_access.Visible = true;
            else
                lbl_access.Visible = false;
            i++;
            if (i==5)
            {
                timer_acc_den.Stop();
                i = 1;
                if (yoxla==1)
                {
                    Profile pr = new Profile(txt_name.Text,txt_surname.Text,txt_password.Text);
                    pr.Show();
                    this.Hide();
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program working like this: when you enter name and surname, it wil join them like" +
                " name_surname and try to find file same with this name. If it finds file then first line of file is password " +
                "it looking password_textbox and first line of this file is same or not. If password is correct you access your " +
                "profile if not, then you can't. Also when you register, it create file named name_surname and password is writen " +
                "to first line of this file. EXAMPLE PROFILE: Name:Umid | Surname:Haciyev | Password:umid123 ");
        }
    }
}
