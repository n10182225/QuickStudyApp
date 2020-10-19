using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickStudyApp.ViewModels;
using QuickStudyApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views
{
    public partial class Schedule : ContentPage
    {
        public Schedule()
        {
            InitializeComponent();
            BindingContext = new ScheduleViewModel();
        }
        async void OnScheduleClicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new NewCalendar

            {

                BindingContext = new Due()

            });

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await QuickStudyApp.ViewModels.CalendarViewModel.DatabaseDue.GetNotesAsync();

        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)

        {

            if (e.SelectedItem != null)

            {

                await Navigation.PushAsync(new NewCalendar

                {

                    BindingContext = e.SelectedItem as Due

                });

            }

        }
    }
}