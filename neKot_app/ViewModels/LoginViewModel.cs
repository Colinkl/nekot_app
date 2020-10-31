﻿using neKot_app.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace neKot_app.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync($"..");
        }
    }
}
