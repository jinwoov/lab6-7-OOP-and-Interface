using System;
using Xunit;
using lab6_7_OOP_and_Interface.Classes;

namespace AnimalTestingUnit
{
    public class UnitTest1
    {
        [Fact]
        public void TestingForBarkFromMammal()
        {
            Wolf wolf = new Wolf();
            string anySound = wolf.Bark();

            Assert.Equal("Rawr", anySound);
        }

        [Fact] //?
        public void DoesFishSleepWorldMystery()
        {
            Humuhumunukunukuapua_a tooLong = new Humuhumunukunukuapua_a();

            string finallySolved = tooLong.Sleeping();

            Assert.Equal("I dont sleep I keep my eyes wide open", finallySolved);
        }

        [Fact]
        public void DoesShepHaveFourLegs()
        {
            Sheep sheep = new Sheep();
            int leg = sheep.LegAmount;

            Assert.Equal(4, leg);
        }

        [Fact]
        public void WhatIsHabitatForLion()
        {
            Lion lion = new Lion();
            string where = lion.Habitat;
            string myGuess = "Land";

            Assert.Equal(myGuess, where);
        }

        [Fact]
        public void ForBruceTheWhiteSharkWhenHeSmellBloodInTheWater()
        {
            GreatWhiteShark bruce = new GreatWhiteShark();

            string beforeOhNo = bruce.Food;

            string ohNo = bruce.FishAreFriend();

            Assert.DoesNotMatch(beforeOhNo, ohNo);
            
        }
        
        [Fact]
        public void ShouldIkeepTheBlueGillsICaughtLastYear()
        {
            BlueGills blueGills = new BlueGills();

            bool beforeTransition = blueGills.CatchRelease();

            Assert.False(beforeTransition);
        }

        [Fact]
        public void IsBearDomesticatable()
        {
            Bear bear = new Bear();
            bool canIKeepTheCub = bear.Domesticatable;

            Assert.False(canIKeepTheCub);
        }

        [Fact]
        public void HowAboutPeterRabbitCanIKeepIt()
        {
            Rabbit peter = new Rabbit();

            bool please = peter.Domesticatable;

            Assert.True(please);
        }

        [Fact]
        public void CowCanEatWhatFood()
        {
            Cow cow = new Cow();

            Assert.Equal("Vegetation", cow.Food);
        }

        [Fact]
        public void WhatBloodTempDoesTigerHave()
        {
            Tiger tiger = new Tiger();

            string bloodType = tiger.BloodTemperature;

            Assert.Equal("Warm", bloodType);
        }
    }
}
