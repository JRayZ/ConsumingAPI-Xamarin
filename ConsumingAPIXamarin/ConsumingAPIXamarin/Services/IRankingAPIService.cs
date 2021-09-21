using System;
using System.Collections.Generic;
using System.Text;
using ConsumingAPIXamarin.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ConsumingAPIXamarin.Services
{
    public interface IRankingAPIService
    {
        Task<ObservableCollection<Ranking>> GetRankingAsync(string actid);
    }
}
