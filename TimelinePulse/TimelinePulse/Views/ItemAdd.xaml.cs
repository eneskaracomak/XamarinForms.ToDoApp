using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimelinePulse.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimelinePulse.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemAdd : ContentPage
    {
        public ItemAdd()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
        }

        public void OnButtonClicked(object sender, EventArgs e)
        {
            var day = dateTime.Date.Day;
            var month = dateTime.Date.Month;
            var year = dateTime.Date.Year;
            var timeSelected = timeSelect.Time;
            if (!string.IsNullOrWhiteSpace(nameEntry.Text))
            {
                string colorC = "#EE376C";
                if (pickerStatus.SelectedItem == "Yüksek Seviye")
                {
                     colorC = "#EE376C";
                }
                else if (pickerStatus.SelectedItem == "Orta Seviye")
                {
                     colorC = "#EE7631";

                }
                else
                {
                     colorC = "#90CC55";
                }

                var x = App.Database.SaveItemAsync(new Item
                {
                    Description = nameEntry.Text,
                    Status = pickerStatus.SelectedItem.ToString(),
                    dateTime = day+"/"+ month + "/" + year,
                    Category = pickerCategory.SelectedItem.ToString(),
                    Photo = "TimelinePulse.Resources.Task.png",
                    Color = colorC,
                    time = timeSelected.ToString()

                });
                if (x.Result == 1)
                {
                    Navigation.PushAsync(new TimelinePulseView());
                }
            }
        }
    }
}