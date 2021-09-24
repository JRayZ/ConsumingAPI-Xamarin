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
        public const string actId = "https://na.api.riotgames.com/val/ranked/v1/leaderboards/by-act/4cb622e1-4244-6da3-7276-8daaf1c01be2?size=20&startIndex=0";
        ISerializerService serializerService = new SerializerService();

        public async Task<RankingInformation> GetRankingAync(string ActId)
        {
            RankingInformation ranking = null;
            var refitClient = RestService.For<IRankingAPI>("https://na.api.riotgames.com/val/ranked/v1/leaderboards/by-act/4cb622e1-4244-6da3-7276-8daaf1c01be2?size=20&startIndex=0");
            var rankingResponse = await refitClient.GetRankingAync(ActId, actId);
            if (rankingResponse.IsSuccessStatusCode)
            {
                var jsonRanking = await rankingResponse.Content.ReadAsStringAsync();
                ranking = serializerService.Deserialize<RankingInformation>(jsonRanking);
            }

            return ranking;
        }
    }
}
