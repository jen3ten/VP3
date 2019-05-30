using System;
using System.Collections.Generic;
using System.Text;
using Virtual_Pets_Amok;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class OrganicPetTests
    {
       
        [Fact]
        public void New_Robo_Pet_Energy_Level()
        {
            OrganicPet sut = new OrganicPet("", "");

            Assert.Equal(9, sut.Energy);
        }

        /*[Fact]
        public void Check_Name_Value()
        {
            OrganicPet sut = new OrganicPet("", "");

            sut.CreatePet();

            Assert.Equal("poot", sut.Name);
        }*/
    
    }
}
