using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ScaryMazeGame
{
    public partial class FailScreen : UserControl
    {
        public FailScreen()
        {
            InitializeComponent();
        }

        private void FailScreen_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.sad);
            player.Play();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            // Send the user to the gameScreen again   
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

        private void noButton_Click(object sender, EventArgs e)
        {
            //escort the user out of the program
            Application.Exit();
        }

        private void nomoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void tryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
