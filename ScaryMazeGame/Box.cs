using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ScaryMazeGame
{
    class Box
    {
        // class for drawing the playerbox. 
        public int x, y, size, width, length;
        public SolidBrush sb;

        public Box( int _x, int _y, int _width, int _length)
        {
            x = _x;
            y = _y;
            width = _width;
            length = _length; 
        }

        public Box(SolidBrush _sb, int _x, int _y, int _size)
        {
            sb = _sb;
            x = _x;
            y = _y;
            size = _size;
        }

        // class for the box to move. 
        public void Move(string direction, int boxSpeed)
        {
            if (direction == "left")
            {
                x -= boxSpeed;
            }
            if (direction == "right")
            {
                x += boxSpeed;
            }

            if (direction == "up")
            {
                y -= boxSpeed;
            }
            if (direction == "down")
            {
                y += boxSpeed;
                
            }
        }
    }
}
