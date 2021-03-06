using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projects
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsPage : ContentPage
    {
        public string[] projects { get; set; }
        public ProjectsPage()
        {
            InitializeComponent();
            projects = new string[] { "Проект 1", "Проект 2", "Проект 3", "Проект 4", "Проект 5", "Проект 6", "Проект 7", "Проект 8", "Проект 9", "Проект 10", "Проект 11", "Проект 12", "Проект 13", "Проект 14", "Проект 15", "Проект 16", "Проект 17", "Проект 18" };
            this.BindingContext = this;
        }

        private async void projectsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                await Navigation.PushAsync(new ProjectPage(e.SelectedItem.ToString()));
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}