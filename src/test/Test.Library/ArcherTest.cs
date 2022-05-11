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

        [Test]

        public void ArcherAttack()
        {
            Archer TestArcher = new Archer("Test");
            IItem bow = new Bow();
            IItem helmet = new Helmet();
            int attack = bow.AttackValue;
            int expected = 15;
            Assert.AreEqual(expected,attack);
        }

        [Test]

        public void KnightDefense()
        {
            Archer TestArcher = new Archer("Test");
            IItem bow = new Bow();
            IItem helmet = new Helmet();
            int defense = helmet.DefenseValue;
            int expected = 18;
            Assert.AreEqual(expected,defense);
        }

    }
}