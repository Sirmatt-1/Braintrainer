namespace Braintrainer
{
    partial class Colour_Game
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
            this.btnAnswerOption3 = new System.Windows.Forms.Button();
            this.btnAnswerOption1 = new System.Windows.Forms.Button();
            this.btnAnswerOption2 = new System.Windows.Forms.Button();
            this.btnAnswerOption4 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserLives = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnswerOption3
            // 
            this.btnAnswerOption3.BackColor = System.Drawing.Color.White;
            this.btnAnswerOption3.FlatAppearance.BorderSize = 0;
            this.btnAnswerOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerOption3.Location = new System.Drawing.Point(12, 371);
            this.btnAnswerOption3.Name = "btnAnswerOption3";
            this.btnAnswerOption3.Size = new System.Drawing.Size(338, 67);
            this.btnAnswerOption3.TabIndex = 0;
            this.btnAnswerOption3.Text = "Colour 3";
            this.btnAnswerOption3.UseVisualStyleBackColor = false;
            this.btnAnswerOption3.Click += new System.EventHandler(this.answerClick);
            // 
            // btnAnswerOption1
            // 
            this.btnAnswerOption1.BackColor = System.Drawing.Color.White;
            this.btnAnswerOption1.FlatAppearance.BorderSize = 0;
            this.btnAnswerOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerOption1.Location = new System.Drawing.Point(12, 298);
            this.btnAnswerOption1.Name = "btnAnswerOption1";
            this.btnAnswerOption1.Size = new System.Drawing.Size(338, 67);
            this.btnAnswerOption1.TabIndex = 1;
            this.btnAnswerOption1.Text = "Colour 1";
            this.btnAnswerOption1.UseVisualStyleBackColor = false;
            this.btnAnswerOption1.Click += new System.EventHandler(this.answerClick);
            // 
            // btnAnswerOption2
            // 
            this.btnAnswerOption2.BackColor = System.Drawing.Color.White;
            this.btnAnswerOption2.FlatAppearance.BorderSize = 0;
            this.btnAnswerOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerOption2.Location = new System.Drawing.Point(450, 298);
            this.btnAnswerOption2.Name = "btnAnswerOption2";
            this.btnAnswerOption2.Size = new System.Drawing.Size(338, 67);
            this.btnAnswerOption2.TabIndex = 2;
            this.btnAnswerOption2.Text = "Colour 2";
            this.btnAnswerOption2.UseVisualStyleBackColor = false;
            this.btnAnswerOption2.Click += new System.EventHandler(this.answerClick);
            // 
            // btnAnswerOption4
            // 
            this.btnAnswerOption4.BackColor = System.Drawing.Color.White;
            this.btnAnswerOption4.FlatAppearance.BorderSize = 0;
            this.btnAnswerOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerOption4.Location = new System.Drawing.Point(450, 371);
            this.btnAnswerOption4.Name = "btnAnswerOption4";
            this.btnAnswerOption4.Size = new System.Drawing.Size(338, 67);
            this.btnAnswerOption4.TabIndex = 3;
            this.btnAnswerOption4.Text = "Colour 4";
            this.btnAnswerOption4.UseVisualStyleBackColor = false;
            this.btnAnswerOption4.Click += new System.EventHandler(this.answerClick);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(347, 181);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(118, 37);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Colour";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(176, 9);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(36, 37);
            this.lblTimeLeft.TabIndex = 5;
            this.lblTimeLeft.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lives:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Score:";
            // 
            // lblUserLives
            // 
            this.lblUserLives.AutoSize = true;
            this.lblUserLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLives.Location = new System.Drawing.Point(123, 46);
            this.lblUserLives.Name = "lblUserLives";
            this.lblUserLives.Size = new System.Drawing.Size(36, 37);
            this.lblUserLives.TabIndex = 9;
            this.lblUserLives.Text = "0";
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScore.Location = new System.Drawing.Point(133, 83);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(36, 37);
            this.lblUserScore.TabIndex = 10;
            this.lblUserScore.Text = "0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(218, 9);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(570, 29);
            this.lblGameOver.TabIndex = 11;
            this.lblGameOver.Text = "Game Over! You scored 0! Better luck next time!";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(354, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Colour_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.lblUserLives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswerOption4);
            this.Controls.Add(this.btnAnswerOption2);
            this.Controls.Add(this.btnAnswerOption1);
            this.Controls.Add(this.btnAnswerOption3);
            this.Name = "Colour_Game";
            this.Text = "Colour Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswerOption3;
        private System.Windows.Forms.Button btnAnswerOption1;
        private System.Windows.Forms.Button btnAnswerOption2;
        private System.Windows.Forms.Button btnAnswerOption4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserLives;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button btnClose;
    }
}