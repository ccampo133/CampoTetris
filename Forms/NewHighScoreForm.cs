using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CampoTetris.Forms
{
    public partial class NewHighScoreForm : Form
    {
        public string playerName;
        public NewHighScoreForm()
        {
            InitializeComponent();
        }

        private void NewHighScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.playerName = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                this.Close();
        }
    }
}