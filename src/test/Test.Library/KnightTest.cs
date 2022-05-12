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
            TestKnight.Shield = new Shield();
            TestKnight.Armor = new Armor();
            IItem sword = new Sword();
            Archer TestArcher = new Archer("Test");
            TestArcher.Bow = new Bow();
            TestKnight.RecieveAttack(TestArcher);
            int health = TestKnight.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

        [Test]

        public void KnightAttackedByDwarf()
        {
            Knight TestKnight = new Knight("Test");
            TestKnight.Shield = new Shield();
            TestKnight.Armor = new Armor();
            IItem sword = new Sword();
            Dwarf TestDwarf = new Dwarf("Test");
            IItem axe = new Axe();
            IItem helmet = new Helmet();
            TestKnight.RecieveAttack(TestDwarf);
            int health = TestKnight.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

        [Test]
        public void KnightAttakedByWizard()
        {
            Wizard wizard1 = new Wizard("Test");
            wizard1.Staff = new Staff();
            wizard1.SpellsBook = new SpellsBook();
            Knight TestKnight = new Knight("Test");
            TestKnight.Sword = new Sword();
            TestKnight.RecieveAttack(wizard1);
            int health = TestKnight.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }


        [Test]

        public void CureKnight()
        {
            Knight TestKnight = new Knight("Test");
            TestKnight.Shield = new Shield();
            TestKnight.Armor = new Armor();
            IItem sword = new Sword();
            Archer TestArcher = new Archer("Test");
            TestArcher.Bow = new Bow();
            TestKnight.RecieveAttack(TestArcher);
            TestKnight.Cure();
            int health = TestKnight.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

    }

}