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
    class IRankingAPI
    {
        [Get("/{actId}?size=50&api_key={key}")]
        Task<HttpResponseMessage> GetRankingAsync(string actid, string key);
    }
}
