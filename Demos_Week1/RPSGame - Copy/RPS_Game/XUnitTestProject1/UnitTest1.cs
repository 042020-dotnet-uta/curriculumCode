using Microsoft.EntityFrameworkCore;
using Xunit;
using RPS_Game.Models;
using System.Linq;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            //configure the inmemory DB. This is done in every test.
            var options = new DbContextOptionsBuilder<DbContextClass>()
                .UseInMemoryDatabase(databaseName: "CustomNameForThisTestsInMemoryDb")
                .Options;
            //Arrange
            //use the using() to arrange the Db.
            using (var context = new DbContextClass(options))
            {
                Player p1 = new Player
                {
                    Name = "Geralt",
                    PlayerId = 11,
                    Losses = 2,
                    Wins = 3
                };
                context.Add(p1);
                context.SaveChanges();
            }//end the context to make sure the correct player wAS SAVED TO THE DB


            //Act
            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new DbContextClass(options))
            {
                Assert.Equal(1, context.Players.Count());

                var p1Name = context.Players.Where(p => p.PlayerId == 11).FirstOrDefault();
                Assert.Equal("Geralt", p1Name.Name);
            }

            //Assert


        }
    }
}
