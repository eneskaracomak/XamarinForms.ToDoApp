using System;
using System.Collections.ObjectModel;
using TimelinePulse.Classes;
using TimelinePulse.Services;
using Xamarin.Forms;

namespace TimelinePulse.ViewModels
{
    public class TimelinePulseViewModel : BindableObject
    {
        private ObservableCollection<Classes.Item> _tasks;
        private ObservableCollection<Classes.User> _tasksUser;

        public TimelinePulseViewModel()
        {
            Tasks = new ObservableCollection<Item>();
            TasksUser = new ObservableCollection<User>();
            
            LoadData();
            LoadUserData();
        }

        public ObservableCollection<Classes.Item> Tasks
        {
            get { return _tasks; }
            set
            {
                _tasks = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Classes.User> TasksUser
        {
            get { return _tasksUser; }
            set
            {
                _tasksUser = value;
                OnPropertyChanged();
            }
        }
        public void LoadUserData()
        {
            var userData = App.Database.ToUserList();
            TasksUser.Clear();
            foreach (var item in userData)
            {
                TasksUser.Add(item);
            }
        }

        public void LoadData()
        {
            var tasks = App.Database.ToList();
           
            Tasks.Clear();
            var dateTime = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            foreach (var task in tasks)
            {
                if (dateTime == task.dateTime)
                {
                    Tasks.Add(task);
                }
            }
        }
        public void LoadDataDate(string date)
        {
            var tasks = App.Database.ToList();

            Tasks.Clear();
            foreach (var task in tasks)
            {
                if (date == task.dateTime)
                {
                    Tasks.Add(task);
                }
            }
        }
    }
}