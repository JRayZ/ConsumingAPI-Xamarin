using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingAPIXamarin.Services
{
    class AlertService : IAlertService
    {
        public Task DisplayAlertAsync(string title, string description)
        {
            return App.Current.MainPage.DisplayAlert(title, description, "Ok");
        }
    }
}
