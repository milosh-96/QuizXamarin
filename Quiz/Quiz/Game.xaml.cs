using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Models.Question> Questions = new ObservableCollection<Models.Question>() {
                new Models.Question("Sport","single","1","Koji tim je 2010. osvojio Tripletu?","Inter",new List<string>() {"Juventus","Milan","Napoli"})
            };
        
        int numberOfPoints = 0;
        public int NumberOfPoints { get => numberOfPoints; set => numberOfPoints = value;  }

        public Game()
        {
        
            InitializeComponent();
            QuestionsView.ItemsSource = Questions;


        }


        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Questions.Add(new Models.Question("Drama", "single", "1", "Serija", "da", new List<string>() { "aaa", "bbb", "ccc" }));
            this.NumberOfPoints += 1;

        }
    }
}