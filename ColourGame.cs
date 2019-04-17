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
        public Colour_Game()
        {
            InitializeComponent();
            lblTimeLeft.Text = timeLeft.ToString();
            newQuestion();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(timeLeft);
            timeLeft--;
            if (timeLeft == 0)
            {
                timeLeft = 5;
                userLives--;
                newQuestion();
            } 
            lblTimeLeft.Text = timeLeft.ToString();
            
        }

        private void newQuestion()
        {
            string[] Colours = { "Red", "Yellow", "Green", "Orange", "Purple", "Black" };
            Button[] answerChoices = { btnAnswerOption1, btnAnswerOption2, btnAnswerOption3, btnAnswerOption4 };

            Random randNumGen = new Random();
            int colourIndex = randNumGen.Next(Colours.Length);
            int questionIndex = randNumGen.Next(answerChoices.Length);
            String correctColour = Colours[colourIndex];

            lblQuestion.ForeColor = Color.FromName(correctColour);
            lblQuestion.Text = Colours[randNumGen.Next(Colours.Length)];
            answerChoices[questionIndex].Text = correctColour;

            ArrayList choicesLeft = new ArrayList();
            choicesLeft.AddRange(answerChoices);
            choicesLeft.Remove(answerChoices[questionIndex]);

            ArrayList coloursLeft = new ArrayList();
            coloursLeft.AddRange(Colours);
            coloursLeft.Remove(correctColour);

            answerChoices = choicesLeft.ToArray(typeof(Button)) as Button[];
            Colours = coloursLeft.ToArray(typeof(string)) as string[];

            foreach(Button btn in answerChoices)
            {
                string nextColour = Colours[randNumGen.Next(Colours.Length)];
                btn.Text = nextColour;
                coloursLeft.Remove(nextColour);
                Colours = coloursLeft.ToArray(typeof(string)) as string[];

            }
            
        }
       
    }
}
