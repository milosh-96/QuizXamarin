using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentView
    {
        private Models.Question question;
        public Question Question { get => question; set => question = value; }

        public Menu(Models.Question question)
        {
            this.Question = question;
            InitializeComponent();
        }


        private void StartGameButton_Clicked(object sender, EventArgs e)
        {
            this.Content = new Game(Question);
        }
    }
}