using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Refit;
using ConsumingAPIXamarin.Models;

namespace ConsumingAPIXamarin.Services
{
    public interface IRankingAPI
    {
        [Get("/val/ranked/v1/leaderboards/by-act/{actId}")]
        Task<HttpResponseMessage> GetRankingAync(string actId, string shard, long totalPlayers);
    }
}
