﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHawk
{
    public partial class checkOutForm : Form
    {
        public checkOutForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when clicked fills in billing info with the same info as shipping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSame_Click(object sender, EventArgs e)
        {
            txtBoxFirstBilling.Text = txtBoxFirst.Text;
            txtBoxLastBilling.Text = txtBoxLast.Text;
            txtBoxAddressBilling.Text = txtBoxAddress.Text;
            txtBoxCityBilling.Text = txtBoxCity.Text;
            txtBoxStateBilling.Text = txtBoxState.Text;
            txtBoxZipBilling.Text = txtBoxZip.Text;

        }
        /// <summary>
        /// Exits Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnExit_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to leave the Application?";
            const string caption = "Quiting Application!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Application.Exit();
            }
        }
        /// <summary>
        /// Displays the help page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }
        /// <summary>
        /// takes user back to the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }
        /// <summary>
        /// Allows user to logout of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnLogout_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to logout?";
            const string caption = "Logging Out!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                SignInForm signIn = new SignInForm();
                signIn.Show();
            }
        }
        /// <summary>
        /// Allows user to view their account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAccount_Click(object sender, EventArgs e)
        {
            accountForm account = new accountForm();
            account.Show();
            this.Close();
        }
        /// <summary>
        /// user sumbits their order and returns them to the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnOrdered_Click(object sender, EventArgs e)
        {
            const string message = "Thank You for your purchase!";
            const string caption = "Thank You!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                frmHome home = new frmHome();
                home.Show();
                this.Close();
            }
        }
    }
}