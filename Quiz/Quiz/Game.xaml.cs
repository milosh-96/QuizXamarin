using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Game : ContentPage
    {
        List<Models.Question> Questions = new List<Models.Question>() {
                new Models.Question("Sport","single","1","Koji tim je 2010. osvojio Tripletu?","Inter",new List<string>() {"Juventus","Milan","Napoli"})
            };
        public Game()
        {

            InitializeComponent();
           
            QuestionTitle.Text = "Question 1/10";
        }
    }
}