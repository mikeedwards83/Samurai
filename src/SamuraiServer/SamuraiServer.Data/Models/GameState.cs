using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace SamuraiServer.Data
{
    public class GameState
    {

        [BsonId]
        public string BsonId { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<GamePlayer> Players { get; set; }

        public int Turn { get; set; }

        public bool Started { get; set; }

        public Guid MapId { get; set; }

        public Dictionary<int, Guid> PlayerOrder { get; set; } 

        public GameState()
        {
            Players = new List<GamePlayer>();
        }
    }
}
