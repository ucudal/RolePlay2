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

        public void ArcherDefense()
        {
            Archer TestArcher = new Archer("Test");
            IItem bow = new Bow();
            IItem helmet = new Helmet();
            int defense = helmet.DefenseValue;
            int expected = 18;
            Assert.AreEqual(expected,defense);
        }

        [Test]
        public void ArcherAttackedByDwarf()
        {
            Dwarf TestDwarf = new Dwarf("Test");
            TestDwarf.Axe = new Axe();
            TestDwarf.Helmet = new Helmet();
            Archer TestArcher = new Archer("Test");
            TestArcher.Bow = new Bow();
            TestArcher.Helmet = new Helmet();
            TestArcher.RecieveAttack(TestDwarf);
            int health = TestArcher.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

        [Test]

        public void ArcherAttackedByKnight()
        {
            Knight TestKnight = new Knight("Test");
            TestKnight.Shield = new Shield();
            TestKnight.Armor = new Armor();
            TestKnight.Sword = new Sword();
            Archer TestArcher = new Archer("Test");
            TestArcher.Bow = new Bow();
            TestArcher.Helmet = new Helmet();
            TestArcher.RecieveAttack(TestKnight);
            int health = TestKnight.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

        [Test]
        public void ArcherAttackedByWizard()
        {
            Wizard wizard1 = new Wizard("Test");
            wizard1.SpellsBook = new SpellsBook();
            wizard1.SpellsBook.Spells = new Spell[]{ new Spell() };
            Staff staff = new Staff();
            Archer TestArcher = new Archer("Test");
            TestArcher.Bow = new Bow();
            TestArcher.Helmet = new Helmet();
            TestArcher.RecieveAttack(wizard1);
            int health = TestArcher.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

        [Test]
        public void CureArcher()
        {
            Dwarf TestDwarf = new Dwarf("Test");
            TestDwarf.Axe = new Axe();
            TestDwarf.Helmet = new Helmet();
            Archer TestArcher = new Archer("Test");
            TestArcher.Bow = new Bow();
            TestArcher.Helmet = new Helmet();
            TestArcher.RecieveAttack(TestDwarf);
            TestArcher.Cure();
            int health = TestArcher.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

    }
}