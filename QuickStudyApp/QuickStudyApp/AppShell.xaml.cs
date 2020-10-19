using System;
using System.Collections.Generic;
using QuickStudyApp.ViewModels;
using QuickStudyApp.Views;
using Xamarin.Forms;
using QuickStudyApp.Services;
using System.IO;

namespace QuickStudyApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ItemsPage), typeof(ItemsPage));
            Routing.RegisterRoute(nameof(Schedule), typeof(Schedule));
            Routing.RegisterRoute(nameof(AssignmentDue), typeof(AssignmentDue));
            Routing.RegisterRoute(nameof(NewAssignmentDueDate), typeof(NewAssignmentDueDate));
            Routing.RegisterRoute(nameof(NotesPage), typeof(NotesPage));
            Routing.RegisterRoute(nameof(NewCalendar), typeof(NewCalendar));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }

}
