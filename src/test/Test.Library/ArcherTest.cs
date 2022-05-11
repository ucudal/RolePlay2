using System;
using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    public class ArcherTest
    {
        [Test]

        public void ArcherSheet()  
        {
            Archer TestArcher = new Archer("Test");
            IItem bow = new Bow();
            IItem helmet = new Helmet();
            Assert.AreEqual(TestArcher.Name,"Test");
        }
    }
}