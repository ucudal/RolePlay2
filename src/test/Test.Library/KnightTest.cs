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

        [Test]

        public void KnightAttack()
        {
            Knight TestKnight = new Knight("Test");
            IItem sword = new Sword();
            IItem shield = new Shield();
            IItem armor = new Armor();
            int attack = sword.AttackValue;
            int expected = 20;
            Assert.AreEqual(expected,attack);
        }

        [Test]

        public void KnightDefense()
        {
            Knight TestKnight = new Knight("Test");
            IItem sword = new Sword();
            IItem shield = new Shield();
            IItem armor = new Armor();
            int defense = shield.DefenseValue + armor.DefenseValue;
            int expected = 39;
            Assert.AreEqual(expected,defense);
        }

        [Test]

        public void KnightAttackedByArcher()
        {
            Knight TestKnight = new Knight("Test");
            IItem sword = new Sword();
            IItem shield = new Shield();
            IItem armor = new Armor();
            Archer TestArcher = new Archer("Test");
            IItem bow = new Bow();
            TestArcher.Bow = new Bow();
            //IItem helmet = new Helmet();
            TestKnight.ReceiveAttack(TestArcher.AttackValue);

        }

        [Test]

        public void CureKnight()
        {
            Knight TestKnight = new Knight("Test");
            IItem sword = new Sword();
            IItem shield = new Shield();
            IItem armor = new Armor();
            TestKnight.Cure();
        }
    }
}