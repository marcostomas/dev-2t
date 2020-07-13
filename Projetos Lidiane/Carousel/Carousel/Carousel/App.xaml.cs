﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Carousel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainCarouselPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}