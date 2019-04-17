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
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(347, 109);
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
            this.lblTimeLeft.Location = new System.Drawing.Point(382, 9);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(36, 37);
            this.lblTimeLeft.TabIndex = 5;
            this.lblTimeLeft.Text = "0";
            // 
            // Colour_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}