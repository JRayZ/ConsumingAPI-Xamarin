using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ConsumingAPIXamarin.Models;
using ConsumingAPIXamarin.Services;


namespace ConsumingAPIXamarin.ViewModels
{
    class RankingViewModel : INotifyPropertyChanged
    {
        public RankingInformation Ranking { get; set; }
        public RankingInformation rankinginformation { get; set; }
        IRankingAPIService _rankingApiService { get; }
        IAlertService _alertService { get; }
        public bool IsBusy { get; set; }
        public ICommand GetCommand { get; }
        public bool IsNotBusy => !IsBusy;
        //const string ActId;

        public RankingViewModel(IRankingAPIService rankingAPIService, IAlertService alertService)
        {
            _rankingApiService = rankingAPIService;
            _alertService = alertService;
            rankinginformation = new RankingInformation();
            //GetCommand = new Command<RankingInformation>(LoadRanking);
        }

        //public async void LoadRanking(RankingInformation information)
        //{
            //IsBusy = true;
            //if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            //{

                //Ranking = await _rankingApiService.GetRankingAync();
            //}
            //else
            //{
                //await _alertService.DisplayAlertAsync("No internet connection", "No internet connection detected");
            //}

            //IsBusy = false;
        //}
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
