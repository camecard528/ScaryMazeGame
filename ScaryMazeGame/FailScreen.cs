using System;
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
    public partial class FailScreen : UserControl
    {
        public FailScreen()
        {
            InitializeComponent();
        }

        private void FailScreen_Load(object sender, EventArgs e)
        {

        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            // Send the user to the gameScreen again
            Form f = this.FindForm();
            f.Controls.Remove(this);

            gameScreen gs = new gameScreen();

            f.Controls.Add(gs);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            //escort the user out of the program
            Application.Exit();
        }
    }
}
