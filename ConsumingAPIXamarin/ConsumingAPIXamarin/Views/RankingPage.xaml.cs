using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumingAPIXamarin.Services;
using ConsumingAPIXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsumingAPIXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RankingPage : ContentPage
    {
        public RankingPage()
        {
            InitializeComponent();
            BindingContext = new RankingViewModel(new RankingAPIService(), new IAlertService());
        }
    }
}