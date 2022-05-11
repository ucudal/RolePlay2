using System;
using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class KnightTest
    {
        [Test]
        public void KnightSheet()
        {
            Knight TestKnight = new Knight("Test");
            IItem sword = new Sword();
            IItem shield = new Shield();
            IItem armor = new Armor();
            Assert.AreEqual(TestKnight.Name,"Test");
        }
    }
}