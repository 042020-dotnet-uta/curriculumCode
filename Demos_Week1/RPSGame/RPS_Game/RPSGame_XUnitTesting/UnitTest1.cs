using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RPS_Game;
using RPS_Game.Models;
using Xunit;

namespace RPSGame_XUnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void AddsPlayerToDb()
        {
            //Arrange - create an object to configure your inmemory DB.
            var options = new DbContextOptionsBuilder<RPS_DbContext>()
                .UseInMemoryDatabase(databaseName: "AddsPlayerToDb")
                .Options;

            //Act - send in the configure object to the DbContext constructor to be used in configuring the DbContext
            using (var db = new RPS_DbContext(options))
            {
                Player p = new Player
                {
                    PlayerId = 100,
                    Losses = 2,
                    Wins = 11,
                    Name = "spark"
                };

                db.Add(p);
                db.SaveChanges();
            }
            //Assert
            using (var db = new RPS_DbContext(options))
            {
                Assert.Equal(1, db.Players.Count());

                var p1Name = db.Players.Where(p => p.Wins == 11).FirstOrDefault();
                Assert.Equal("spark", p1Name.Name);
            }
        }

        [Fact]
        public void DoesInMemoryDbTranalateToBusinessLogicTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<RPS_DbContext>()
                .UseInMemoryDatabase(databaseName: "Test1")
                .Options;

            //ACT
            using (var db = new RPS_DbContext(options))
            {
                GamePlay testgame = new GamePlay();
                testgame.GetPlayersName();
            }

            //ASSERT
            //see if the inMemory Db is used by the 
            using (var db = new RPS_DbContext(options))
            {
                var p1Name = db.Players.Where(p => p.Name == "Spam").FirstOrDefault();
                Assert.Equal("spam", p1Name.Name);
            }





        }

        //[Fact]
        //public void Test3()
        //{
        //    //Arrange
        //    var options = new DbContextOptionsBuilder<RPS_DbContext>()
        //        .UseInMemoryDatabase(databaseName: "Test1")
        //        .Options;

        //}


    }
}
