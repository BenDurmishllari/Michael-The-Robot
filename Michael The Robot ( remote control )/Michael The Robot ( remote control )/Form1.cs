using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;
using MonoBrick.NXT;
using System.IO;

namespace Michael_The_Robot___remote_control__
{
    public partial class Form1 : MaterialForm
    {
        string sUserName;
        string sPassWord;

        const string sFile = "Aministrator.txt";

        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.Cyan900,Primary.Blue500,Accent.LightBlue200,TextShade.WHITE);


            txtPassWord.PasswordChar = '●';

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked == true)
            {
                txtPassWord.UseSystemPasswordChar = true;
            }

            else
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            sUserName = txtUserName.Text;
            sPassWord = txtPassWord.Text;

            if (txtUserName.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show("Pleas add user name or password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (File.Exists( sFile) == false)
            {
                MessageBox.Show("That account doesn't exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                using (StreamReader srLogin = new StreamReader(sFile))
                {
                    sUserName = srLogin.ReadLine();
                    sPassWord = srLogin.ReadLine();
                }

                if (sPassWord != txtPassWord.Text)
                {
                    MessageBox.Show("Wrong Password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (sUserName == txtUserName.Text && sPassWord == txtPassWord.Text)
                {
                    Form2 secondform = new Form2();
                    secondform.Show();
                    this.Hide();

                }


                txtUserName.Clear();
                txtPassWord.Clear();
            }

           
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            sUserName = txtUserName.Text;
            sPassWord = txtPassWord.Text;

            using (StreamWriter sw = new StreamWriter(sFile, true))
            {
                sw.WriteLine(sUserName);
                sw.WriteLine(sPassWord);
            }
        


                if (txtUserName.Text == "" && txtPassWord.Text == "")
                {
                    MessageBox.Show("Please form the empty boxes!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


         

            txtUserName.Clear();
            txtPassWord.Clear();
        }
    }
}
