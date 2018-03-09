using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaryMazeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //probably need a public list to hold the values of the box and the values of the maze. 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //launch the startScreen when the program starts
            // Create an instance of the HomeScreen
            startScreen ss = new startScreen();

            // Add the Control to the Form
            this.Controls.Add(ss);
        }

    }
}
