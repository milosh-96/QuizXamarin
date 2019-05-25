using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Game : ContentView
    {
       
        public Game(Models.Question question)
        {
           
            InitializeComponent();

            question.incorrect_answers.Add(question.correct_answer);

            question.incorrect_answers.OrderBy(a => Guid.NewGuid()).ToList();
            Question.Text = question.question;

            foreach(string ques in question.incorrect_answers)
            {
                var btn = new Button() {CommandParameter = question.correct_answer, Text = ques };
                btn.Clicked += Btn_Clicked;
                Answers.Children.Add(btn);
            }
        }

        void Btn_Clicked(object sender, EventArgs e)
        {
            Button selected = (Button)sender;
            if (selected.CommandParameter.ToString() == selected.Text)
            {
                selected.BackgroundColor = Color.Green;
                MainPage.ContentProperty = new Views.Menu();
            }
            else
            {
                selected.BackgroundColor = Color.Red;
            }
        }

    }
}