using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson;

namespace SamuraiServer.Data.Impl
{
    public class MongoDbGameStateRepository : IGameStateRepository
    {
        string _databaseName = "Code52Samurai";
        string _serverAddress = "mongodb://127.0.0.1:27017/";
        MongoDatabase _db;

        public MongoDbGameStateRepository()
        {
            MongoServer server = MongoServer.Create(_serverAddress);

            _db = server.GetDatabase(_databaseName);
        }

        // TODO: If we decide to launch with MongoDb then we need to be able to store our game state

        public IQueryable<GameState> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<GameState> FindBy(Expression<Func<GameState, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public GameState Get(Guid id)
        {
            var gameStates = _db.GetCollection<GameState>("gameState");

            var query = Query.EQ("Id", id);
            return gameStates.FindOne(query);
        }

        public void Add(GameState entity)
        {
            var gameStates = _db.GetCollection<GameState>("gameState");
            entity.BsonId = ObjectId.GenerateNewId().ToString();
            gameStates.Insert(entity);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Edit(GameState entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public GameState GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
