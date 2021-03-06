﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaryMazeGame
{
    public partial class startScreen : UserControl
    {
        public startScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // f is the form that this control is on
            Form f = this.FindForm();
            f.Controls.Remove(this);

            // Create an instance of the gameScreen
            gameScreen gs = new gameScreen();

            //center screen 
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);

            // Add the Control to the Form
            f.Controls.Add(gs);

            gs.Focus();
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //code to close program
            Application.Exit();
        }
    }
}
