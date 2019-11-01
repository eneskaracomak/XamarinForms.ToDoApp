using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimelinePulse.Classes;
using TimelinePulse.ViewModels;
using Xamarin.Forms;

namespace TimelinePulse.Views
{
    public partial class TimelinePulseView : ContentPage
	{
		public TimelinePulseView ()
		{
			InitializeComponent ();
            BindingContext = new TimelinePulseViewModel();
            //BindingContext = App.Database.ToList();
            var x  = DateTime.Now;
            lblDate.Text = x.Day.ToString();
            lblDateString.Text = x.DayOfWeek.ToString();
            lblMonthYear.Text = monthConverter(x.Month) +" " + x.Year.ToString();
            var itemS = App.Database.GetUserAsync().Result;
            foreach (var item in itemS)
            {
                lblName.Text = item.Name;
            }
		}

        private string monthConverter(int month)
        {
            string returnDeger = "";
            switch (month)
            {
                case 1: returnDeger = "Jenuary"; break;

                case 2: returnDeger = "February"; break;

                case 3: returnDeger = "March"; break;

                case 4: returnDeger = "April"; break;

                case 5: returnDeger = "May"; break;

                case 6: returnDeger = "June"; break;

                case 7: returnDeger = "July"; break;

                case 8: returnDeger = "August"; break;

                case 9: returnDeger = "September"; break;

                case 10: returnDeger = "October"; break;

                case 11: returnDeger = "Novomber"; break;

                case 12: returnDeger = "December"; break;

                default:
                    break;
            }
            return returnDeger;
        }
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ItemAdd());
        }



        private void DateSelected_DateSelected(object sender, DateChangedEventArgs e)
        {
            TimelinePulseViewModel timelinePulseView = new TimelinePulseViewModel();
            var date = dateSelected.Date.Day+"/"+ dateSelected.Date.Month + "/" + dateSelected.Date.Year.ToString();
            timelinePulseView.LoadDataDate(date);
            BindingContext =  timelinePulseView;
        }

        private void CircularImage_Touch(object sender, SkiaSharp.Views.Forms.SKTouchEventArgs e)
        {

        }


        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            List<Item> items = new List<Item>();
            items.Add((Item)e.Item);

            BackButtonPressed(items);
        }
        public async Task BackButtonPressed(List<Item> ıtem)
        {
            TimelinePulseViewModel timelinePulseView = new TimelinePulseViewModel();

            var action = await DisplayAlert("Durum", "Etkinlik Tamamlandı mı ?", "Evet", "Hayır");
            if (action)
            {
                foreach (var item in ıtem)
                {
                    Item ıtemS = new Item();
                    ıtemS.Id = item.Id;
                    App.Database.DeleteItemAsync(ıtemS);
                    BindingContext = timelinePulseView;
                }
              
            }
        }
    }
}