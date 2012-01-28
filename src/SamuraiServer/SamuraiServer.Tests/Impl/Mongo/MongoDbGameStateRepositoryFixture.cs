using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SamuraiServer.Data.Impl;
using NUnit.Framework;
using SamuraiServer.Data;

namespace SamuraiServer.Tests.Impl.Mongo
{
    [TestFixture]
    public class MongoDbGameStateRepositoryFixture
    {
        MongoDbGameStateRepository _repo;

        [SetUp]        
        public void Test()
        {
          _repo = new MongoDbGameStateRepository();
        }

        #region Method - Add

        [Test]
        public void Add_AddGameToMongoRepo_NoExceptionsThrown()
        {
            //Assign
            GameState state = new GameState();
            state.Id = Guid.NewGuid();
            state.Name = "Test";

            //Act
            _repo.Add(state);
            var result = _repo.Get(state.Id);
            
            //Assert
            Assert.AreNotEqual(state, result);
            Assert.AreEqual(state.Id, result.Id);
            Assert.AreEqual(state.Name, result.Name);
        }

        #endregion
    }
}
