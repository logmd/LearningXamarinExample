﻿using GuitarShop.Layouts;
using Xamarin.Forms;

namespace GuitarShop
{
    public partial class App: global::Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();

            // The root page of your application
            MainPage = new MainPage();
        }

        //protected override void OnStart()
        //{
        //    // Handle when your app starts
        //}

        //protected override void OnSleep()
        //{
        //    // Handle when your app sleeps
        //}

        //protected override void OnResume()
        //{
        //    // Handle when your app resumes
        //}
    }
}