using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Game : ContentView
    {
        private List<Models.Question> questions = new List<Models.Question>()
        {
            new Models.Question("Test","test","test","Who's the voice actor for Thrall in the Warcraft game series?","Chris Metzen",new List<string>(){
                "Ben Affleck","Jason Derulo","Jim Carrey"
            })
        };

        public List<Models.Question> Questions { get => questions; set => questions = value; }
        public Game()
        {
           
            InitializeComponent();
            QuestionsView.ItemsSource = Questions;
        }
    }
}