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
    public partial class Profile : Form
    {
        string password = null;
        string path = null;
        public Profile(string name, string surname,string passw)
        {
            InitializeComponent();
            lbl_profname.Text = name;
            lbl_profsurname.Text = surname;
            password = passw;
            path = lbl_profname.Text + "_" + lbl_profsurname.Text + ".txt";
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (true)
            {

            }
            rtb_file.Clear();
            btn_update.Enabled = true;
            List<string> info = File.ReadAllLines(path).ToList();
            password = info.ElementAt(0);
            for (int i = 1; i < info.Count; i++)
            {
                rtb_file.Text += info.ElementAt(i)+"\n";

            }


        }

 

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure","This info will be added to your profile",MessageBoxButtons.YesNo);

            if (answer ==DialogResult.Yes)
            {
                string time = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
                StreamWriter sw = new StreamWriter(path, append: true);
                string border = "-------------------------------";
                sw.WriteLine(border+"---------" + time + border+"---------"+ "\n" + rtb_file.Text+"\n"+border+border+border+"-------");
                sw.Close();
                rtb_file.Clear();

            }
        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_file.Clear();
        }

        private void btn_profclear_Click(object sender, EventArgs e)
        {
            DialogResult ans =  MessageBox.Show("Are sure to clear all your information","Delete Information",MessageBoxButtons.YesNo);
            if (ans==DialogResult.Yes)
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(password);
                sw.Close();
                MessageBox.Show("Your profile is clear");
                rtb_file.Clear();
            }
            
        }

    }
}
