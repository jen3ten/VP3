using System;
using Virtual_Pets_Amok;
using Xunit;

namespace VirtualPetsAmok.Tests
{
   public class RoboPetTests
    {
        [Fact]
        public void Oil_Feed_Method()
        {
            RoboPet sut = new RoboPet("","");
            //sut.Oil = 7;
            
            sut.FeedPet();

            Assert.Equal(2, sut.Energy);
        }

        [Fact]
        public void New_Robo_Pet_Energy_Level()
        {
            RoboPet sut = new RoboPet("", "");
            //sut.Oil = 7;

            Assert.Equal(5, sut.Energy);
        }
    }
}
