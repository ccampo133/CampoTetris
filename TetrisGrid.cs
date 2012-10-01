using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CampoTetris
{
    class TetrisGrid
    {
        #region member variables
        private int[,] blocks;
        private SolidBrush[,] colors;
        private TetrisBlock curBlock;
        private int scaleX;
        private int scaleY;
        private int height;
        private int width;
        #endregion

        #region initialization
        public TetrisGrid(int width, int height, int scaleX, int scaleY)
        {
            this.width = width;
            this.height = height;
            this.scaleX = scaleX;
            this.scaleY = scaleY;
            blocks = new int[height, width];
            colors = new SolidBrush[height, width];
        }

        public TetrisBlock CreateNewBlock(string type, int x, int y)
        {
            curBlock = new TetrisBlock(type, x, y, scaleX, scaleY);
            return curBlock;
        }
        #endregion

        #region collision detection and grid management
        public bool IsCollision()
        {
            for (int i = 0; i < curBlock.n; i++)
            {
                for (int j = 0; j < curBlock.m; j++)
                {
                    // check bottom
                    if (curBlock.boundingBox[i, j] == 1 &&
                        curBlock.y + i == height)
                        return true;

                    // check edges
                    if (curBlock.boundingBox[i, j] == 1 &&
                        (curBlock.x + j <= -1 || curBlock.x + j >= width))
                        return true;

                    // check other pieces
                    if (curBlock.boundingBox[i, j] == 1 &&
                        blocks[curBlock.y + i, curBlock.x + j] == curBlock.boundingBox[i, j])
                        return true;
                }
            }
            return false;
        }

        // used when there is a collision.  fill the grid with 1s where the block lands
        public void AddBlockToGrid()
        {
            for (int i = 0; i < curBlock.n; i++)
                for (int j = 0; j < curBlock.m; j++)
                    if (curBlock.boundingBox[i, j] == 1)
                    {
                        blocks[i + curBlock.y, j + curBlock.x] = curBlock.boundingBox[i, j];
                        colors[i + curBlock.y, j + curBlock.x] = curBlock.color;
                    }
        }

        public int ClearLines()
        {
            // start from the bottom up
            bool isFull = false;
            int lines = 0;
            for (int i = this.height - 1; i >= 0; i--)
            {
                for (int j = 0; j < this.width - 1; j++)
                {
                    if (blocks[i, j] == 1 && blocks[i, j] == blocks[i, j + 1])
                        isFull = true;
                    else
                    {
                        isFull = false;
                        break;
                    }
                }
                if (isFull)
                {
                    lines++;
                    isFull = false;
                    ShiftGridDown(i);
                    i++;
                }
            }
            return lines;
        }

        public void ShiftGridDown(int ind)
        {
            for (int i = ind; i > 0; i--)
                for (int j = 0; j < this.width; j++)
                {
                    blocks[i, j] = blocks[i - 1, j];
                    colors[i, j] = colors[i - 1, j];
                }
        }
        #endregion

        #region graphics
        public void Draw(Graphics dc)
        {
            // draw blocks
            for (int i = 0; i < this.height; i++)
                for (int j = 0; j < this.width; j++)
                    if (i >= 2)
                    {
                        Rectangle r = new Rectangle(j * scaleX, i * scaleX, scaleX, scaleY);
                        if (blocks[i, j] == 1)
                        {
                            dc.FillRectangle(colors[i, j], r);
                            dc.DrawRectangle(new Pen(Color.Black), r);
                        }
                    }

            // draw border
            Rectangle rect = new Rectangle(0, 2 * scaleX, width * scaleX, (height - 2) * scaleY);
            dc.DrawRectangle(new Pen(Color.Purple, 5), rect);
        }
        #endregion
    }
}
