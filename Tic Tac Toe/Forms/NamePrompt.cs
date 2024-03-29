﻿/*
    Project: Tic Tac Toe
    File: NamePrompt.cs
    Names: Wilson Wong, Jun Yu Huang, Joseph Yap
    Date Written: 11/27/2016
    Section: S11
    Purpose: Get a name from the user.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class NamePrompt : Form
    {
        //The name
        public string userName;
 

        public NamePrompt()
        {
            InitializeComponent();
            //Init event handlers
            this.okButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.okButton.MouseLeave += CommonEvents.menuButton_MouseLeave;

            this.cancelButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.cancelButton.MouseLeave += CommonEvents.menuButton_MouseLeave;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Sees if length is adequate
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("You need to put something in the field!");
            }
            else
            {
                //Assign the name
                userName = nameTextBox.Text;
                this.Close();
            }        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Give a blank name if canceled
            userName = "";
            this.Close();
        }
    }
}
