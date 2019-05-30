using System;
using Virtual_Pets_Amok;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class PetTests
    {
        [Fact]
        public void Pet_Gets_Hurt_When_Playing_100()
        {
            Pet sut = new Pet("", "");
            sut.PlayPet();

            Assert.Equal(8, sut.Energy);
        }

    }
}
