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
    public partial class Menu : ContentView
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void StartGameButton_Clicked(object sender, EventArgs e)
        {
            this.Content = new Game();
        }
    }
}