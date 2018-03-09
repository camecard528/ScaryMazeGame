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
    public partial class gameScreen : UserControl
    {
        //values here
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        // list for the pathing for the maze
        List<Box> mazePaths = new List<Box>();

        //used to draw the box on screen
        SolidBrush boxBrush = new SolidBrush(Color.White);

        // level logic
        bool newLevel = true;
        int gameLevel = 0;

        //pathing rectangles

        Box mazeBox;
        Box playerBox;

        public gameScreen()
        {
            InitializeComponent();
        }

        private void gameScreen_Load(object sender, EventArgs e)
        {
            SolidBrush playerBrush = new SolidBrush(Color.Black);
            int playerX = 250;
            int playerY = 475;
            int playerSize = 10;

            playerBox = new Box(playerBrush, playerX, playerY, playerSize);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
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
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
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

            //TODO - compare collison with the rectangles.
            // COLLISION - between player and maze pathing
            Rectangle playerRec = new Rectangle(playerBox.x, playerBox.y, playerBox.size, playerBox.size);
            foreach(Box b in mazePaths)
            {
                b.recPath()
            }
            if (mazePaths.Count)
            {
                for (int i = 0; i < 3; i++)
                {
                    gameLoop.Enabled = false;
                    Rectangle boxRec = new Rectangle(boxesLeft[i].x, boxesLeft[i].y, boxesLeft[i].size, boxesLeft[i].size);

                    if (playerRec.IntersectsWith(boxRec))
                    {
                        gameLoop.Enabled = false;
                    }
                }
            }

            Rectangle mazeRec = new Rectangle(mazeBox.x, mazeBox.y, mazeBox.width, mazeBox.length);

            // redraw screen
            Refresh();
        }

        private void newMaze(int x)
        {
            if ( x == 1)
            {
                mazeBox.recPath(20, 20, 20, 20);
                mazePaths.Add(mazeBox);
                mazeBox.recPath(0, 0, 0, 0);
                mazePaths.Add(mazeBox);
                mazeBox.recPath(80, 0, 0, 90);
                mazePaths.Add(mazeBox);
                x++;
                newLevel = false;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(playerBox.sb, playerBox.x, playerBox.y, playerBox.size, playerBox.size);
        }
    }
}
