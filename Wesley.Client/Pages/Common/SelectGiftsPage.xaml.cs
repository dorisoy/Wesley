﻿using Wesley.Client.ViewModels;
using Microsoft.AppCenter.Crashes;
using System;
using Xamarin.Forms;
namespace Wesley.Client.Pages.Common
{

    public partial class SelectGiftsPage : BaseContentPage<SelectGiftsPageViewModel>
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Content == null)
            {
                Device.StartTimer(TimeSpan.FromSeconds(0), () =>
                {
                    try
                    {
                        InitializeComponent();
                    }
                    catch (Exception ex) { Crashes.TrackError(ex); }
                    return false;
                });
                return;
            }
        }
    }
}