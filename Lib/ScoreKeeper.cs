using System;
using System.Collections.Generic;
using System.Text;

namespace CampoTetris
{
    class ScoreKeeper
    {
        private static int n = 5;
        private HighScore[] scores = new HighScore[n];
        public HighScore lowest
        {
            get
            {
                return scores[n - 1];
            }
        }

        public ScoreKeeper()
        {
            GetScoresFromSettings();
        }

        // grab scores from the application settings
        private void GetScoresFromSettings()
        {
            for(int i = 0; i < n; i++)
            {
                string[] parts = Properties.Settings.Default.HighScores[i].Split(',');
                string player = parts[0];
                string score = parts[1];
                if (score != "---")
                    scores[i] = new HighScore(player, Convert.ToInt32(score));
                else
                    scores[i] = new HighScore(player, 0);
            }
            Array.Sort(scores);
        }

        public void AddToHighScores(string player, int score)
        {
            scores[n - 1].name = player;
            scores[n - 1].score = score;
            Array.Sort(scores);
            SaveScores();
        }

        public void SaveScores()
        {
            for (int i = 0; i < n; i++)
            {
                string name = scores[i].name;
                string score = scores[i].score.ToString();
                Properties.Settings.Default.HighScores[i] = name + "," + score;
            }
            Properties.Settings.Default.Save();
        }
    }

    class HighScore : IComparable<HighScore>
    {
        public string name;
        public int score;

        public HighScore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public int CompareTo(HighScore other)
        {
            if (this.score < other.score)
                return 1;
            else if (this.score > other.score)
                return -1;
            else 
                return 0;
        }
    }
}
