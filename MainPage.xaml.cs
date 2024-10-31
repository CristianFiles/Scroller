using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Scroller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnDoneClick(object sender, EventArgs e)
        {
            try
            {
                Prompter.stringArray = Regex.Split(TextBox.Text, @"(?<=[\.!\?])\s+").ToList();
                Shell.Current.GoToAsync("//Prompter");
            }
            catch (Exception)
            {
            // The user canceled or something went wrong
                    
            }
        }
    }

}
