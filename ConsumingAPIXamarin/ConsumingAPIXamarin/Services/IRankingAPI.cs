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
        [Get("/{actId}?size=20&api_key={key}")]
        Task<HttpResponseMessage> GetRankingAync(string actid, string key);
    }
}
