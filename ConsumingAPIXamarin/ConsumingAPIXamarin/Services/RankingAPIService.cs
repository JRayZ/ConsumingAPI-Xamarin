using System;
using System.Collections.Generic;
using System.Text;
using Refit;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ConsumingAPIXamarin.Models;

namespace ConsumingAPIXamarin.Services
{
    public class RankingAPIService : IRankingAPIService
    {
        public const string ApiKey = "https://na.api.riotgames.com/val/ranked/v1/leaderboards/by-act/4cb622e1-4244-6da3-7276-8daaf1c01be2?size=20&startIndex=0&api_key=RGAPI-6a479643-0f56-4d91-a98c-97bf88a5d4c4";
        ISerializerService serializerService = new SerializerService();

        public async Task<ObservableCollection<Ranking>> GetRankingAync(string actId)
        {
            ObservableCollection<Ranking> ranking = null;
            var refitClient = RestService.For<IRankingAPI>
                ("https://na.api.riotgames.com/val/ranked/v1/leaderboards/by-act/4cb622e1-4244-6da3-7276-8daaf1c01be2?size=20&startIndex=0&api_key=RGAPI-6a479643-0f56-4d91-a98c-97bf88a5d4c4");
            var rankingResponse = await refitClient.GetRankingAync(actId, ApiKey);
            if (rankingResponse.IsSuccessStatusCode)
            {
                var jsonRanking = await rankingResponse.Content.ReadAsStringAsync();
                ranking = serializerService.Deserialize<ObservableCollection<Ranking>>(jsonRanking);
                ranking = new ObservableCollection<Ranking>(ranking.OrderByDescending(x => x.RankedRating));
            }

            return ranking;
        }

    }
}
