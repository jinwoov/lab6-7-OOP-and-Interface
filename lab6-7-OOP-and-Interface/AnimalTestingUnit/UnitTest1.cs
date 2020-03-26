using System;
using Xunit;
using lab6_7_OOP_and_Interface.Classes;

namespace AnimalTestingUnit
{
    public class UnitTest1
    {
        [Fact]
        public void IsBearDomesticatable()
        {
            Bear bear = new Bear();
            bool canIKeepTheCub = bear.Domesticatable;

            Assert.False(canIKeepTheCub);
        }

        [Fact]
        public void IsBearCampingDestroyerUnlikeTiger() 
        {
            Bear bear = new Bear();
            bool canIKeepTheCub = bear.CampingCrasher;

            Assert.True(canIKeepTheCub);
        }

        [Fact]
        public void WhatBloodTempDoesTigerHave() 
        {
            Tiger tiger = new Tiger();

            string bloodType = tiger.BloodTemperature;

            Assert.Equal("Warm", bloodType);
        }

        [Fact]
        public void CanTigerSleep() 
        {
            Tiger tiger = new Tiger();

            string outcome = tiger.Sleeping();

            Assert.Equal("Zzz to the dream land", outcome);
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
        public void DoesLionHaveFourLeg()
        {
            Lion lion = new Lion();
            bool result = false;
            if(lion.LegAmount == 4)
            {
                result = true;
            }

            Assert.True(result);
        }

        [Fact]
        public void TestingForBarkFromMammal() 
        {
            Wolf wolf = new Wolf();
            string anySound = wolf.Bark();

            Assert.Equal("Rawr", anySound);
        }

        [Fact]
        public void IsWolfPredatorOrPrey()
        {
            Wolf wolf = new Wolf();
            var answer = 5;
            if (wolf.PredatorPrey is "Predator")
            {
                answer -= 5;
            }

            Assert.Equal(0, answer);
        }

        [Fact]
        public void DoesSheepHaveFourLegs()
        {
            Sheep sheep = new Sheep();
            int leg = sheep.LegAmount;

            Assert.Equal(4, leg);
        }


        [Fact] //?
        public void DoesFishSleepWorldMystery()
        {
            Humuhumunukunukuapua_a tooLong = new Humuhumunukunukuapua_a();

            string finallySolved = tooLong.Sleeping();

            Assert.Equal("I dont sleep I keep my eyes wide open", finallySolved);
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
        public void FindingNemoQuoteCheckingItFromMarineClass()
        {
            ClownFish marlin = new ClownFish();

            string quote = marlin.FishAreFriend();

            Assert.Equal("Fishes are friend, Not food!", quote);
        }

        [Fact]
        public void IcanInstantiateSameGroupInHierchy()
        {
            Carnivore[] carnivore = new Carnivore[4];
            Carnivore wolf = new Wolf();
            Carnivore bear = new Bear();
            Carnivore simba = new Lion();
            Carnivore tiger = new Tiger();

            carnivore[0] = wolf;
            carnivore[1] = bear;
            carnivore[2] = simba;
            carnivore[3] = tiger;


            Assert.Equal("Rawr", carnivore[2].Bark());
        }

        [Fact]
        public void WhatTraitCanIUseFromAnimalFromFish()
        {
            Animal nemo = new ClownFish();

            string whatDoesNemoSayWhenHeEats = nemo.Eating();

            Assert.Equal("Hey I am eating here come back later", whatDoesNemoSayWhenHeEats);
        }

        [Fact]
        public void CanIUseMethodFromInterFace()
        {
            Lion mufasa = new Lion();

            string circleOfLife = mufasa.Attention();

            Assert.Equal("Circle of Life", circleOfLife);
        }

        [Fact]
        public void TestingInHeritance()
        {
            Humuhumunukunukuapua_a humu = new Humuhumunukunukuapua_a();

            string huh = humu.SwimFast();

            Assert.Equal("Theres food catch him", huh);
        }

        [Fact]
        public void TestingForPolymorphism()
        {
            ClownFish marlin = new ClownFish();

            string whereIsDory =  marlin.Swimming();

            Assert.DoesNotMatch("Just keep swimming", whereIsDory);
        }

        [Fact]
        public void TestingIfOneOfConcretAnimalIsAnimal()
        {
            bool whatDoesRabbitMakeWhenTheyJump = false;
            Rabbit peter = new Rabbit();

            if (peter is Animal)
            {
                whatDoesRabbitMakeWhenTheyJump = true;
            }

            Assert.True(whatDoesRabbitMakeWhenTheyJump);
        }

        [Fact]
        public void TestingIfSharkIsMammal()
        {
            bool isIt = false;
            GreatWhiteShark bruce = new GreatWhiteShark();

            if (bruce is Mammal)
            {
                isIt = true;
            }

            Assert.False(isIt);
        }


    }
}
