using System;
using System.Windows.Forms;

namespace Braintrainer
{
    public partial class Braintrainer : Form
    {
        public Braintrainer()
        {
            InitializeComponent();
        }

        private void instructionClick(object sender, EventArgs e)
        {
            
        }

        private void gameClick(object sender, EventArgs e)
        {
            
            Button gameType = sender as Button;
            if ((gameType.Tag).ToString() == "colour")
            {
                Colour_Game gameWindow = new Colour_Game();
                gameWindow.Show();
                
            } else
            {
                NumberGame gameWindow = new NumberGame();
                gameWindow.Show();
            }
        }
    }
}
