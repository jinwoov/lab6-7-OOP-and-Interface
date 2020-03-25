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


    }
}
