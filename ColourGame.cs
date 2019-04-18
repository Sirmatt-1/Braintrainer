using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braintrainer
{
    public partial class Colour_Game : Form
    {
        public int timeLeft = 5;
        public int maxTimeAvailable = 5;
        public int userLives = 3;
        public int userScore = 0;
        public int scalableTimeLeft = 5;
        
        public Colour_Game()
        {
            InitializeComponent();
            lblTimeLeft.Text = timeLeft.ToString();
            newQuestion();
            timerClock.Enabled = true;
            lblUserLives.Text = userLives.ToString();
            btnClose.Hide();
            lblGameOver.Hide();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            
            Console.WriteLine(timeLeft);
            timeLeft--;
            lblTimeLeft.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                timeLeft = scalableTimeLeft;
                userLives--;
                lblUserLives.Text = userLives.ToString();
                newQuestion();
            }
            if (userLives == 0)
            {
                lblGameOver.Text = "Game over! You scored: " + userScore.ToString() + "\nBetter luck next time!";
                lblGameOver.Show();
                timerClock.Enabled = false;
                disableChoices();
            }
        }

        private void newQuestion()
        {
            // Arrays for colours used & 4 buttons for multi-choice answers.
            string[] Colours = { "Red", "Yellow", "Green", "Orange", "Purple", "Black" };
            Button[] answerChoices = { btnAnswerOption1, btnAnswerOption2, btnAnswerOption3, btnAnswerOption4 };

            // Generating random colour and option for multiple choice.
            Random randNumGen = new Random();
            int colourIndex = randNumGen.Next(Colours.Length);
            int questionIndex = randNumGen.Next(answerChoices.Length);
            String correctColour = Colours[colourIndex];

            //Setting the question to label and the correct answer to a button.
            lblQuestion.ForeColor = Color.FromName(correctColour);
            lblQuestion.Text = Colours[randNumGen.Next(Colours.Length)];
            answerChoices[questionIndex].Text = correctColour;
            answerChoices[questionIndex].Tag = "correct";

            /* Removing the colour and the button from the array.
            By removing the correct button it prevents a different, incorrect answer from being put in its place. */
            ArrayList choicesLeft = new ArrayList();
            choicesLeft.AddRange(answerChoices);
            choicesLeft.Remove(answerChoices[questionIndex]);

            // Removing the colour from the array to prevent duplicate choices for user.
            ArrayList coloursLeft = new ArrayList();
            coloursLeft.AddRange(Colours);
            coloursLeft.Remove(correctColour);

            // Converting the 2 arraylists made above back to arrays (personal preference).
            answerChoices = choicesLeft.ToArray(typeof(Button)) as Button[];
            Colours = coloursLeft.ToArray(typeof(string)) as string[];

            // For each of the remaining buttons assign a random colour left in the array.
            foreach(Button btn in answerChoices)
            {
                string nextColour = Colours[randNumGen.Next(Colours.Length)];
                btn.Text = nextColour;
                coloursLeft.Remove(nextColour);
                Colours = coloursLeft.ToArray(typeof(string)) as string[];
                btn.Tag = "false";

            }
            
        }

        private void answerClick(object sender, EventArgs e)
        {
            if (((Button)sender).Tag.ToString() == "correct")
            {
                userScore++;
                if (userScore == 10)
                {
                    scalableTimeLeft = 4;
                }
                else if (userScore == 20)
                {
                    scalableTimeLeft = 3;
                } else if (userScore == 30)
                {
                    scalableTimeLeft = 2;
                } else if (userScore == 100)
                {
                    scalableTimeLeft = 1;
                }

                timeLeft = scalableTimeLeft;
                lblUserScore.Text = userScore.ToString();
                newQuestion();

            } else
            {
                userLives--;
                lblUserLives.Text = userLives.ToString();
                timeLeft = scalableTimeLeft;
                lblTimeLeft.Text = timeLeft.ToString();
                newQuestion();
                if (userLives == 0)
                {

                    lblGameOver.Text = "Game over! You scored: " + userScore.ToString() + "\nBetter luck next time!";
                    lblGameOver.Show();
                    timerClock.Enabled = false;
                    disableChoices();
                }
            }
            
        }
        private void disableChoices()
        {
            Button[] answerChoices = { btnAnswerOption1, btnAnswerOption2, btnAnswerOption3, btnAnswerOption4 };
            foreach (Button btn in answerChoices)
            {
                btn.Enabled = false;
            }
            btnClose.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
