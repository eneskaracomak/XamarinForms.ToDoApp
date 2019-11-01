using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TimelinePulse.Classes;

namespace TimelinePulse.Services
{
    public class ItemService
    {
        private static ItemService _instance;

        public static ItemService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ItemService();

                return _instance;
            }

        }

        //public List<Classes.Item> GetTasks()
        //{

            

            //// NOTE: In this sample the focus is on the UI. This is a Fake service.
            //return new List<Classes.Item>
            //{
            //    new Classes.Item { Description = "Customer meeting", Category = "Hangouts", Status = "Warning", dateTime = "6pm", Color = Color.FromHex("#EEB611")
            //    //new Models.Task { Name = "Catch up with Brian", Category = "Mobile Project", Status = "Warning", Time = "5pm", Color = Color.FromHex("#EEB611"), Completed = false },
            //    //new Models.Task { Name = "Approve final design review", Category = "Mobile Project", Status = "Problem", Time = "4pm", Color = Color.FromHex("#5677CB"), Completed = false }, new Models.Task { Name = "Make new icons", Category = "Web App", Status = "Ready", Time = "3pm", Color = Color.FromHex("#51C6BF"), Completed = false },
            //    //new Models.Task { Name = "Design explorations", Category = "Company Website", Status = "Delayed", Time = "2pm", Color = Color.FromHex("#EE376C"), Completed = false },
            //    //new Models.Task { Name = "Lunch with Mary", Category = "Grill House", Status = "Ready", Time = "12pm", Color = Color.FromHex("#51C6BF"), Completed = false },
            //    //new Models.Task { Name = "Team meeting", Category = "Hangouts", Status = "Ready", Time = "10am", Color = Color.FromHex("#51C6BF"), People = new List<Models.Person> { new Models.Person { Photo = "TimelinePulse.Resources.face2.jpg" }, new Models.Person { Photo = "TimelinePulse.Resources.face3.jpg" }, new Models.Person { Photo = "TimelinePulse.Resources.face4.jpg" }, new Models.Person { Photo = "TimelinePulse.Resources.face5.jpg" } }, Completed = false }
            //};
        //}
    }
}

