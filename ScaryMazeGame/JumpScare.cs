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
    public partial class JumpScare : UserControl
    {
        public JumpScare()
        {
            InitializeComponent();
        }

        private void JumpScare_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.woscream4);
            player.Play();
        }
    }
}
