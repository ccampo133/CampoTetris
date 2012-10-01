using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CampoTetris
{
    public partial class MainForm : Form
    {
        #region member variables
        private int interval = 500;
        private int gridWidth = 10;
        private int gridHeight = 22;
        private int linesPerLevel = 10;
        private int scaleX = 20;
        private int scaleY = 20;
        private int dy = 1;
        private int dx = 1;
        private int _score;
        private int _modifier;
        private int _level;
        private int _totLines;
        private bool _isGameOver = false;
        private bool _isPaused = false;
        private TetrisBlock curBlock;
        private TetrisBlock nextBlock;
        private TetrisGrid grid;

        private int level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
                lblLevel.Text = _level.ToString();
                if(_level < 21) // max effective level since we subtract time in 25ms increments
                    timerMain.Interval = 500 - (_level - 1) * 25;
            }
        }

        private int totLines
        {
            get
            {
                return _totLines;
            }
            set
            {
                _totLines = value;
                if (_totLines >= level * linesPerLevel)
                    level++;
            }
        }
        private int modifier
        {
            get
            {
                return _modifier;
            }
            set
            {
                _modifier = value;
                lblModifier.Text = (_modifier / 100).ToString() + "x";
                timerModifier.Start();
            }
        }

        private int score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                lblScore.Text = _score.ToString();
            }
        }

        private bool isGameOver
        {
            get
            {
                return _isGameOver;
            }
            set
            {
                _isGameOver = value;
                if (_isGameOver)
                {
                    lblGameOver.Visible = true;
                    timerMain.Stop();
                }
                else
                    lblGameOver.Visible = false;
            }
        }

        private bool isPaused
        {
            get
            {
                return _isPaused;
            }
            set
            {
                _isPaused = value;
                if (_isPaused)
                {
                    timerMain.Stop();
                    timerModifier.Stop();
                    lblPause.Visible = true;
                }
                else
                {
                    timerMain.Start();
                    timerModifier.Start();
                    lblPause.Visible = false;
                }
            }
        }
        #endregion

        #region initialization
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;  // removes flickering seen on some systems
            StartGame();
        }
        #endregion

        #region movement controls
        private void MoveBlockDown()
        {
            curBlock.MoveDown(dy);
            if (grid.IsCollision())
            {
                if (curBlock.y <= 2)
                {
                    curBlock.MoveUp(dy);
                    isGameOver = true;
                    return;
                }
                curBlock.MoveUp(dy);
                grid.AddBlockToGrid();
                int lines = grid.ClearLines();
                totLines += lines;
                score += lines * modifier;
                if (lines >= 3)
                {
                    lblBonus.Visible = true;
                    modifier *= 2;
                }
                if (lines == 4)
                    modifier *= 2;

                curBlock = grid.CreateNewBlock(nextBlock.type, gridWidth / 2 - 1, 0);
                nextBlock = new TetrisBlock(RandomBlock(), 12, 12, scaleX, scaleY);
            }
        }

        private void RotateBlock()
        {
            curBlock.Rotate();
            if (grid.IsCollision())
            {
                // rotate backwards.  I should just write another function to
                // perform the inverse of the rotation... but i'm lazy.
                curBlock.Rotate();
                curBlock.Rotate();
                curBlock.Rotate();
            }
        }

        private void MoveBlockLeft()
        {
            curBlock.MoveLeft(dx);
            if (grid.IsCollision())
                curBlock.MoveRight(dx);
        }

        private void MoveBlockRight()
        {
            curBlock.MoveRight(dx);
            if (grid.IsCollision())
                curBlock.MoveLeft(dx);
        }
        #endregion 

        #region game behavior and logic
        private void StartGame()
        {
            this.score = 0;
            this.modifier = 100;
            timerMain.Interval = this.interval;
            this.totLines = 0;
            level = 1;
            grid = new TetrisGrid(gridWidth, gridHeight, scaleX, scaleY);
            curBlock = grid.CreateNewBlock(RandomBlock(), gridWidth / 2 - 1, 0);
            nextBlock = new TetrisBlock(RandomBlock(), 12, 12, scaleX, scaleY);
            timerMain.Start();
        }

        private string RandomBlock()
        {
            Random rand = new Random();
            string[] types = new string[]
            {
                "i", "l", "s", "z", "j", "square", "t"
            };
            return types[rand.Next(0, 7)];
        }

        // handle user input
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameOver && !isPaused)
            {
                if (e.KeyCode == Keys.Up)
                    RotateBlock();
                if (e.KeyCode == Keys.Left)
                    MoveBlockLeft();
                if (e.KeyCode == Keys.Right)
                    MoveBlockRight();
                if (e.KeyCode == Keys.Down)
                    MoveBlockDown();
                if (e.KeyCode == Keys.P || e.KeyCode == Keys.Pause)
                    isPaused = true;
                // space moves blocks all the way to the bottom
                if (e.KeyCode == Keys.Space)
                {
                    while (!grid.IsCollision())
                        curBlock.MoveDown(dy);
                    curBlock.MoveUp(dy);
                    MoveBlockDown();
                }
                this.Invalidate();
            }
            else if (isPaused)
            {
                if (e.KeyCode == Keys.Space)
                    isPaused = false;
            }
            else if (isGameOver)
            {
                if (e.KeyCode == Keys.Y)
                {
                    StartGame();
                    isGameOver = false;
                    Invalidate();
                }
                else if (e.KeyCode == Keys.N)
                    this.Close();
            }
        }
        
        // reset score modifier once the bonus period has passed
        private void timerModifier_Tick(object sender, EventArgs e)
        {
            modifier = 100;
            timerModifier.Stop();
            lblBonus.Visible = false;
        }

        // the main game loop - move blocks down every tick. interval is inversely proportional to level.
        private void timerMain_Tick(object sender, EventArgs e)
        {
            MoveBlockDown();
            this.Invalidate();
        }
        #endregion

        #region graphics
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            curBlock.Draw(dc);
            grid.Draw(dc);
            nextBlock.Draw(dc);
            base.OnPaint(e);
        }
        #endregion
    }
}