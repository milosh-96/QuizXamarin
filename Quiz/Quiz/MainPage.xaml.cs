using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quiz
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]



    public partial class MainPage : ContentPage
    {

        private ObservableCollection<Models.Question> questions = new ObservableCollection<Models.Question>()
        {
            new Models.Question("Test","test","test","Who's the voice actor for Thrall in the Warcraft game series?","Chris Metzen",new List<string>(){
                "Ben Affleck","Jason Derulo","Jim Carrey"
            }),
            new Models.Question("Test","test","test","\"Hello\" on Serbian?","Zdravo",new List<string>(){
                "Ola","Ciao","Bonjour"
            }),
            new Models.Question("Test","test","test","Whats color is cucumber?","Green",new List<string>() {"Red","Blue","Yelow"})
        };

        public ObservableCollection<Models.Question> Questions { get => questions; set => questions = value; }
        public MainPage()
        {
          
            InitializeComponent();
            this.Content = new Views.Menu(Questions[0]);
        }

    }
}
