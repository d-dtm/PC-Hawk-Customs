﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHawkVer3
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        /// <summary>
        /// This odes nothing but dont delete it cause just dont
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// sets the hide password filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxPass.Checked == true)
            {
                
                txtBoxPass.PasswordChar = '*';
                txtBoxPass.Refresh();
            }
            else
            {
               
                txtBoxPass.PasswordChar = '\0';
                txtBoxPass.Refresh();
            }
            txtBoxPass.Refresh();
        }
        /// <summary>
        /// logs the user in to the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnLogin_Click(object sender, EventArgs e)
        {
            //MyStaticClass.MyStringMessage object will be assigned the email of the logging in user. accessible throughout forms.
            //MyStaticClass.MyStringMessage is a static public class.
            MyStaticClass.MyStringMessage = txtBoxEmail.Text;
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }
        /// <summary>
        /// Takes user to the sign up form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpForm signUp = new signUpForm();
            signUp.Show();
        }
        /// <summary>
        /// allows user to view the help form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }
        /// <summary>
        /// actions that run when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignInForm_Load(object sender, EventArgs e)
        {
            txtBoxPass.PasswordChar = '*';
        }
    }
 }
