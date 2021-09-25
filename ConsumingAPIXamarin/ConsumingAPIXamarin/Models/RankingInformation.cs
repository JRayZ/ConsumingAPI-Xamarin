using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsumingAPIXamarin.Models
{
    public class RankingInformation
    {
        public string ActId { get; set; }
        public string shard { get; set; }
        public long totalPlayers { get; set; }

        [JsonPropertyName("players")]
        public List<Ranking> Players { get; set; }
    }
}
