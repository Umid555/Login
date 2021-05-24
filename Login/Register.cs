using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string path = txt_name2.Text + "_" + txt_surname2.Text + ".txt";
            
            if (File.Exists(path))
            {
                MessageBox.Show("This user has registered");
            }
            else
            {

                if (txt_password2.Text != "" && txt_pswagain.Text != "" && txt_password2.Text == txt_pswagain.Text &&
                    txt_password2.Text != "" && txt_password2.Text != "" && txt_surname2.Text != "")
                {
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(txt_password2.Text);
                    sw.Close();
                    MessageBox.Show("You have registered");
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
                else if (txt_password2.Text != txt_pswagain.Text)
                {
                    MessageBox.Show("Be sure passwords are same.");

                }
                else
                {
                    MessageBox.Show("PLease fill gaps");
                }
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_backlogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }


    }
}
