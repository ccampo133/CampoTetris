namespace CampoTetris
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblScoreText = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.lblMod = new System.Windows.Forms.Label();
            this.lblModifier = new System.Windows.Forms.Label();
            this.timerModifier = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblLevlName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblScoreText.Location = new System.Drawing.Point(253, 9);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(81, 24);
            this.lblScoreText.TabIndex = 0;
            this.lblScoreText.Text = "SCORE:";
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblScore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblScore.Location = new System.Drawing.Point(205, 38);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(124, 29);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerMain
            // 
            this.timerMain.Interval = 500;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMod.Location = new System.Drawing.Point(229, 67);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(105, 24);
            this.lblMod.TabIndex = 2;
            this.lblMod.Text = "MODIFIER:";
            // 
            // lblModifier
            // 
            this.lblModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblModifier.Location = new System.Drawing.Point(229, 96);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(100, 29);
            this.lblModifier.TabIndex = 3;
            this.lblModifier.Text = "0";
            this.lblModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerModifier
            // 
            this.timerModifier.Interval = 45000;
            this.timerModifier.Tick += new System.EventHandler(this.timerModifier_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Black;
            this.lblGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(72, 172);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(197, 77);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "GAME OVER! \r\nStart New Game?\r\n(Y/N)";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.BackColor = System.Drawing.Color.Transparent;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNext.Location = new System.Drawing.Point(201, 198);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(130, 24);
            this.lblNext.TabIndex = 5;
            this.lblNext.Text = "NEXT BLOCK";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.ForeColor = System.Drawing.Color.Lime;
            this.lblBonus.Location = new System.Drawing.Point(58, 9);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(91, 24);
            this.lblBonus.TabIndex = 6;
            this.lblBonus.Text = "BONUS!!!";
            this.lblBonus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBonus.Visible = false;
            // 
            // lblLevlName
            // 
            this.lblLevlName.AutoSize = true;
            this.lblLevlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevlName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLevlName.Location = new System.Drawing.Point(255, 125);
            this.lblLevlName.Name = "lblLevlName";
            this.lblLevlName.Size = new System.Drawing.Size(74, 24);
            this.lblLevlName.TabIndex = 7;
            this.lblLevlName.Text = "LEVEL:";
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLevel.Location = new System.Drawing.Point(231, 154);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(100, 29);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "0";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Black;
            this.lblPause.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.Color.Red;
            this.lblPause.Location = new System.Drawing.Point(12, 172);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(302, 52);
            this.lblPause.TabIndex = 9;
            this.lblPause.Text = "GAME PAUSED.\r\nPress SPACE to continue...";
            this.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPause.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(218, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 96);
            this.label1.TabIndex = 10;
            this.label1.Text = "CONTROLS:\r\nLEFT - LEFT ARROW\r\nRIGHT - RIGHT ARROW\r\nDOWN - DOWN ARROW\r\nROTATE - UP" +
                " ARROW\r\nDROP BLOCK - SPACE\r\nPAUSE - P or PAUSE\r\nHIGH SCORES - H";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(328, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblLevlName);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblModifier);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CampoTetris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label lblModifier;
        private System.Windows.Forms.Timer timerModifier;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblLevlName;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label label1;


    }
}

