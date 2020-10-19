using QuickStudyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewCalendar : ContentPage
    {
        public NewCalendar()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)

        {

            var note = (Due)BindingContext;
            note.OnScheduleTime = DateTime.UtcNow;

            await QuickStudyApp.ViewModels.CalendarViewModel.DatabaseDue.SaveNoteAsync(note);

            await Navigation.PopAsync();

        }



        async void OnDeleteButtonClicked(object sender, EventArgs e)

        {

            var note = (Due)BindingContext;

            await QuickStudyApp.ViewModels.CalendarViewModel.DatabaseDue.DeleteNoteAsync(note);

            await Navigation.PopAsync();

        }
    }
}

