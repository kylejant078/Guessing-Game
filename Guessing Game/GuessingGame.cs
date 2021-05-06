using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class GuessingGame : Form
    {
        //Global variables
        int randomNumber;
        Random randGen = new Random();

        private void guessButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                int userGuess;
                userGuess = Convert.ToInt32(numberInput.Text);
                
                if (userGuess < 0)
                {
                    outputLabel.Text = "You must enter a positive number";
                    numberInput.Text = "";
                }
                else if (userGuess < randomNumber)
                {
                    outputLabel.Text = "Too Low";
                    numberInput.Text = "";
                }
                else if (userGuess > randomNumber)
                {
                    outputLabel.Text = "Too High";
                    numberInput.Text = "";
                }
                else
                {
                    outputLabel.Text = "You Got it!";
                }
            }
            catch
            {
                outputLabel.Text = "You must enter a whole number";
                numberInput.Text = "";
            }
            
        }

        public GuessingGame()
        {
            InitializeComponent();
            randomNumber = randGen.Next(1, 101);
        }
    }
}
