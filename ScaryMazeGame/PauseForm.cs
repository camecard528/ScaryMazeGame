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
    public partial class PauseForm : Form
    {
        Timer timer;

        public PauseForm(Timer _timer)
        {
            InitializeComponent();

            timer = _timer;
        }

        private void PauseForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.M:
                    Application.Exit();
                    break;
                case Keys.Space:
                    timer.Start();
                    Close();
                    break;
            }
        }

        private void PauseForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }
    }
}
