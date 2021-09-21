using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsumingAPIXamarin.Models
{
    public class Ranking
    {

        [JsonPropertyName("gameName")]
        public string GameName { get; set; }

        [JsonPropertyName("leaderboardRank")]
        public int LeaderboardRank { get; set; }

        [JsonPropertyName("rankedRating")]
        public int RankedRating { get; set; }

        [JsonPropertyName("numberOfWins")]
        public int NumberOfWins { get; set; }

    }
}
