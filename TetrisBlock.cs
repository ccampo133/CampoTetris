using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CampoTetris
{
    class TetrisBlock
    {
        #region member variables
        public string type;
        public SolidBrush color;
        public int[,] boundingBox;
        public int x;
        public int y;
        public int height;
        public int width;
        public int n;
        public int m;
        #endregion

        #region initialization
        public TetrisBlock(string type, int x, int y, int width, int height)
        {
            this.type = type;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

            // standard tetromino colors
            if (type == "i")
                color = new SolidBrush(Color.Cyan);
            else if (type == "square")
                color = new SolidBrush(Color.Yellow);
            else if (type == "t")
                color = new SolidBrush(Color.Magenta);
            else if (type == "l")
                color = new SolidBrush(Color.Orange);
            else if (type == "j")
                color = new SolidBrush(Color.Blue);
            else if (type == "z")
                color = new SolidBrush(Color.Red);
            else if (type == "s")
                color = new SolidBrush(Color.Lime);

            ConstructBoundingBox(type);
            this.n = boundingBox.GetLength(0);
            this.m = boundingBox.GetLength(1);
        }

        // standard tetromino shapes
        private void ConstructBoundingBox(string type)
        {
            if (type == "i")
            {
                boundingBox = new int[,]
                {
                    {0, 0, 0, 0},
                    {1, 1, 1, 1},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                };
            }
            else if (type == "square")
            {
                boundingBox = new int[,]
                {
                    {0, 1, 1, 0},
                    {0, 1, 1, 0},
                    {0, 0, 0, 0}
                };
            }
            else if (type == "t")
            {
                boundingBox = new int[,]
                {
                    {0, 1, 0},
                    {1, 1, 1},
                    {0, 0, 0}
                };
            }
            else if (type == "l")
            {
                boundingBox = new int[,]
                {
                    {0, 0, 1},
                    {1, 1, 1},
                    {0, 0, 0}
                };
            }
            else if (type == "j")
            {
                boundingBox = new int[,]
                {
                    {1, 0, 0},
                    {1, 1, 1},
                    {0, 0, 0}
                };
            }
            else if (type == "s")
            {
                boundingBox = new int[,]
                {
                    {0, 1, 1},
                    {1, 1, 0},
                    {0, 0, 0}
                };
            }
            else if (type == "z")
            {
                boundingBox = new int[,]
                {
                    {1, 1, 0},
                    {0, 1, 1},
                    {0, 0, 0}
                };
            }
        }
        #endregion

        #region Movement and Rotation
        public void MoveDown(int dy)
        {
            this.y += dy;
        }

        public void MoveUp(int dy)
        {
            this.y -= dy;
        }

        public void MoveRight(int dx)
        {
            this.x += dx;
        }

        public void MoveLeft(int dx)
        {
            this.x -= dx;
        }

        public void Rotate()
        {
            // only rotate for non-squares
            if (type != "square")
            {
                int[,] newBB = new int[this.n, this.m];
                for (int i = 0; i < this.n; ++i)
                    for (int j = 0; j < this.m; ++j)
                        newBB[i, j] = boundingBox[n - j - 1, i];
                boundingBox = newBB;
            }
        }
        #endregion

        #region graphics
        public void Draw(Graphics dc)
        {

            for (int i = 0; i < this.n; i++)
                for (int j = 0; j < this.m; j++)
                {
                    // do not draw the first two rows if the block is at y = 0
                    if (this.y == 0)
                        return;
                    else if (this.y == 1 && i == 0)
                        i++;
                    Rectangle r = new Rectangle((x + j) * width, (y + i) * height, width, height);
                    // only fill the part of the bound. box that contains the block
                    if (boundingBox[i, j] == 1)
                    {
                        dc.FillRectangle(color, r);
                        dc.DrawRectangle(new Pen(Color.Black), r);
                    }
                }
        }
        #endregion
    }
}
