﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TimelinePulse.Classes;
using TimelinePulse.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TimelinePulse
{
    public partial class App : Application
    {
        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "timeLine.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            if (App.Database.GetUserAsync().Result.Count == 0)
            {
                MainPage = new CustomNavigationPage(new RegisterPage());

            }
            else
            {
                MainPage = new CustomNavigationPage(new TimelinePulseView());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
