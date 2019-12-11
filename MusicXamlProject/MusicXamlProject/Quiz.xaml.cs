using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicXamlProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz : ContentPage
    {
        public Quiz()
        {
            InitializeComponent();
        }

        void ButtonClicked(object sender, System.EventArgs e)
        {
            ImageButton c = (ImageButton)sender;
            string answer = c.ClassId;

            if (answer == "scotland")
            {
                DisplayAlert("Correct Answer", "1", "Continue");
            }
            else
            {
                DisplayAlert("Wrong Answer", "You Lose", "Game Over");

            }

        }


        void ButtonClicked2(object sender, System.EventArgs e)
        {
            ImageButton c = (ImageButton)sender;
            string answer = c.ClassId;

            if (answer == "harp")
            {
                DisplayAlert("Correct Answer", "2", "Continue");
            }
            else
            {
                DisplayAlert("Wrong Answer", "You Lose", "Game Over");

            }

        }

        void ButtonClicked3(object sender, System.EventArgs e)
        {
            ImageButton c = (ImageButton)sender;
            string answer = c.ClassId;

            if (answer == "piano")
            {
                DisplayAlert("Final Answer Correct", "Congratulations", "Well Done :)");
            }
            else
            {
                DisplayAlert("Wrong Answer", "You Lose", "Game Over");

            }

        }
    }
}