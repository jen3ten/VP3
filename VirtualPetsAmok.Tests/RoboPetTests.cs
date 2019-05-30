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
            int finalHunger = sut.Energy;

            Assert.Equal(4, finalHunger);
        }

        [Fact]
        public void New_Robo_Pet_Energy_Level()
        {
            RoboPet sut = new RoboPet("", "");
            //sut.Oil = 7;

            int finalHunger = sut.Energy;

            Assert.Equal(9, finalHunger);
        }
    }
}
