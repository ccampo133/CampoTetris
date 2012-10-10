using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CampoTetris
{
    public partial class ScoreTableForm : Form
    {
        public ScoreTableForm()
        {
            InitializeComponent();
            PopulateScoreData();
        }

        private void ScoreTableForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
                PopulateScoreData();
        }

        private void PopulateScoreData()
        {
            int i = 0;
            foreach (string s in Properties.Settings.Default.HighScores)
            {
                string name = s.Split(',')[0];
                string score = s.Split(',')[1];
                switch (i)
                {
                    case 0:
                        lblName1.Text = name;
                        lblScore1.Text = score;
                        break;
                    case 1:
                        lblName2.Text = name;
                        lblScore2.Text = score;
                        break;
                    case 2:
                        lblName3.Text = name;
                        lblScore3.Text = score;
                        break;
                    case 3:
                        lblName4.Text = name;
                        lblScore4.Text = score;
                        break;
                    case 4:
                        lblName5.Text = name;
                        lblScore5.Text = score;
                        break;
                }
                i++;
            }
        }
    }
}