using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ScaryMazeGame
{
    public partial class gameScreen : UserControl
    {
        //values here
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown, escDown;

        // list for the pathing for the maze
        List<Box> mazePaths = new List<Box>();
        List<Box> mazeFinal = new List<Box>(); 
       // List<Box> loserPath = new List<Box>(); 
        //used to draw the box on screen
        SolidBrush boxBrush = new SolidBrush(Color.White);
        SolidBrush finalBrush = new SolidBrush(Color.Blue);
        SolidBrush badBrush = new SolidBrush(Color.Red);
        SolidBrush textBrush = new SolidBrush(Color.Black);

        Font drawFont = new Font("Arial", 12);

        // level logic
        bool newLevel = true;
        int gameLevel = 0;
        bool scareTrigger = false; 

        //pathing rectangles
        Box mazeBox;
        Box playerBox;

        //Time to complete Stopwatch
        Stopwatch timeWatch = new Stopwatch();
        long eTime;
        long tTime;
        long sTime = 60000;

        private void yesButton_Click(object sender, EventArgs e)
        {
            contLabel.Visible = false;
            quitLabel.Visible = false;
            yesButton.Visible = false;
            noButton.Visible = false;
            gameLoop.Start();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        public gameScreen()
        {
            InitializeComponent();
        }

        // set starting values for the player when the game loads / prepares object to accept from class. 
        private void gameScreen_Load(object sender, EventArgs e)
        {
            // set the pause menu to be invisible
            contLabel.Visible = false;
            quitLabel.Visible = false;
            yesButton.Visible = false;
            noButton.Visible = false;

            SolidBrush playerBrush = new SolidBrush(Color.Black);
            int playerX = 10;
            int playerY = 20;
            int playerSize = 10;
            
            playerBox = new Box(playerBrush, playerX, playerY, playerSize);
            timeWatch.Start();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    escDown = true;
                    break; ;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.Escape:
                    escDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            // LEVEL LOGIC - decide what level there player is on to draw the level
            if (newLevel == true)
            {
                newMaze(gameLevel);
            }

            // MOVE - player character on x-axis
            if (leftArrowDown)
            {
                playerBox.Move("left", 12);

            }
            if (rightArrowDown)
            {
                playerBox.Move("right", 12);

            }
            // MOVE - player character on the y-axis
            if (upArrowDown)
            {
                playerBox.Move("up", 12);

            }
            if (downArrowDown)
            {
                playerBox.Move("down", 12);

            }

            //check if the user wants to pause the game
            if (escDown)
            {
                gameLoop.Stop();
                contLabel.Visible = true;
                quitLabel.Visible = true;
                yesButton.Visible = true;
                noButton.Visible = true;
                //pauseScreen();
            }

            // COLLISION - between player and maze pathing
            Rectangle playerRec = new Rectangle(playerBox.x, playerBox.y, playerBox.size, playerBox.size);
            Rectangle finalRec = new Rectangle(mazeBox.x, mazeBox.y, mazeBox.length, mazeBox.width);

            //boolean to check is the box has collision with the path
            Boolean isOk = false;
            
            foreach (Box b in mazePaths)
            {
                Rectangle mazeRec = new Rectangle(b.x, b.y, b.width, b.length);

                if (playerRec.IntersectsWith(mazeRec))
                {
                    isOk = true; 
                }
            }

            
            // checks if the player is not in the pathing, and if they are in the end zone. 
            if (!isOk)
            {
                if (playerRec.IntersectsWith(finalRec))
                {
                    gameLevel++; 
                    newLevel = true;
                }
                else if (scareTrigger == true)
                {
                    gameLoop.Enabled = false;
                    // create new instance
                    JumpScare js = new JumpScare();

                    // Remove the screen
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    //center screen 
                    js.Location = new Point((f.Width - js.Width) / 2, (f.Height - js.Height) / 2);

                    // add the screen
                    f.Controls.Add(js);
                    return;
                }
                else
                {
                    // create new instance
                    FailScreen fs = new FailScreen();

                    //stop the loop
                    gameLoop.Enabled = false;
                    
                    // remoce the failscreen
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    //center screen 
                    fs.Location = new Point((f.Width - fs.Width) / 2, (f.Height - fs.Height) / 2);

                    f.Controls.Add(fs);
                }
            }

            eTime = timeWatch.ElapsedMilliseconds;
            tTime = (sTime - eTime) / 1000;

            if(tTime == 0)
            {
                if (scareTrigger == true)
                {
                    gameLoop.Enabled = false;
                    
                    // create new instance
                    JumpScare js = new JumpScare();

                    // Remove the screen
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    //center screen 
                    js.Location = new Point((f.Width - js.Width) / 2, (f.Height - js.Height) / 2);

                    // add the screen
                    f.Controls.Add(js);
                }

                else
                {
                    gameLoop.Stop();
                    
                    // create new instance
                    FailScreen fs = new FailScreen();

                    //stop the loop
                    gameLoop.Enabled = false;

                    // remoce the failscreen
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    //center screen 
                    fs.Location = new Point((f.Width - fs.Width) / 2, (f.Height - fs.Height) / 2);

                    f.Controls.Add(fs);
                }
            }
            
            // redraw screen
            Refresh();
        }

        // LEVELS - This is the code for the maze designs, using a class to create the objects, 
        // then adding them to a list. 
        private void newMaze(int x)
        {
            if ( x == 0)
            {
                mazeBox = new Box(0, 10, 300, 100);
                mazePaths.Add(mazeBox);
               
                mazeBox = new Box (300, 10, 100, 600);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(300, 600, 300, 100);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(600, 300, 100, 600);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(600, 300, 300, 100);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(900, 300, 300, 100);
                mazeFinal.Add(mazeBox);
                
                x = 0;
                newLevel = false;
            }

            if ( x == 1)
            {
                SolidBrush playerBrush = new SolidBrush(Color.Black);
                mazePaths.Clear();
                mazeFinal.Clear();

                mazeBox = new Box(0, 10, 300, 50);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(300, 10, 50, 500);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(200, 460, 100, 50);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(150, 460, 50, 200);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(150, 660, 600, 30);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(750, 300, 20, 390);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(750, 300, 150, 20);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(900, 260, 100, 100);
                mazeFinal.Add(mazeBox);

                playerBox = new Box(playerBrush, 1, 15, 10);
                x = 0;
                newLevel = false;

            }

            if ( x == 2)
            {
                SolidBrush playerBrush = new SolidBrush(Color.Black);
                mazePaths.Clear();
                mazeFinal.Clear();

                mazeBox = new Box(0, 10, 300, 25);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(300, 10, 25, 75);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(250, 75, 75, 25);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(250, 75, 25, 75);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(175, 125, 75, 25);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(175, 125, 15, 100);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(175, 225, 100, 25);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(275, 225, 100, 100);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(375, 300, 100, 25);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(475, 300, 15, 150);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(475, 450, 50, 15);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(525, 450, 15, 50);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(525, 500, 50, 15);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(575, 500, 10, 50);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(575, 550, 50, 10);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(625, 400, 5, 160);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(625, 400, 105, 5);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(730, 360, 5, 40);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(730, 372, 5, 33);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(730, 360, 200, 5);
                mazePaths.Add(mazeBox);

                mazeBox = new Box(930, 370, 10, 20);
                mazePaths.Add(mazeBox);

               // mazeBox = new Box(325, 10, 625, 25);
                //loserPath.Add(mazeBox);

               // mazeBox = new Box(925, 10, 25, 290);
                //loserPath.Add(mazeBox);

                mazeBox = new Box(900, 300, 300, 100);
                mazeFinal.Add(mazeBox);

                playerBox = new Box(playerBrush, 1, 15, 10);
                x = 0;
                newLevel = false;
                scareTrigger = true;
            }
        }

        // PAUSE - this is the code for the pause screen
        //private void pauseScreen()
        //{
            
        //}

        // paint method to draw all of the objects to the screen.
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("REMAINING TIME: " + tTime + "s", drawFont, textBrush, 820, 20);
            foreach (Box b in mazePaths)
            {
                e.Graphics.FillRectangle(boxBrush, b.x, b.y, b.width, b.length);
            }
            foreach (Box b in mazeFinal)
            {
                e.Graphics.FillRectangle(finalBrush, b.x, b.y, b.width, b.length);
            }
        //    foreach (Box b in loserPath)
        //    {
        //        e.Graphics.FillRectangle(badBrush, b.x, b.y, b.width, b.length);
        //    }
            e.Graphics.FillRectangle(playerBox.sb, playerBox.x, playerBox.y, playerBox.size, playerBox.size);
        }
    }
}
