using System;
using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DwarfTest
    {
        [Test]
        public void DwarfSheet()
        {
            Dwarf TestDwarf = new Dwarf("Test");
            IItem axe = new Axe();
            IItem helmet = new Helmet();
            Assert.AreEqual(TestDwarf.Name,"Test");
        }

        [Test]

        public void DwarfAttack()
        {
            Dwarf TestDwarf = new Dwarf("Test");
            IItem axe = new Axe();
            IItem helmet = new Helmet();
            int attack = axe.AttackValue;
            int expected = 25;
            Assert.AreEqual(expected,attack);
        }

        [Test]

        public void DwarfDefense()
        {
            Dwarf TestDwarf = new Dwarf("Test");
            IItem axe = new Axe();
            IItem helmet = new Helmet();
            int defense = helmet.DefenseValue;
            int expected = 18;
            Assert.AreEqual(expected,defense);
        }

        [Test]

        public void DwarfAttackedByArcher()
        {
            Dwarf TestDwarf = new Dwarf("Test");
            TestDwarf.Axe = new Axe();
            TestDwarf.Helmet = new Helmet();
            Archer TestArcher = new Archer("Test");
            TestArcher.Bow = new Bow();
            TestDwarf.RecieveAttack(TestArcher);
            int health = TestDwarf.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

        [Test]

        public void DwarfAttackedByKnight()
        {
            Knight TestKnight = new Knight("Test");
            TestKnight.Shield = new Shield();
            TestKnight.Armor = new Armor();
            TestKnight.Sword = new Sword();
            Dwarf TestDwarf = new Dwarf("Test");
            TestDwarf.Axe = new Axe();
            TestDwarf.Helmet = new Helmet();
            TestDwarf.RecieveAttack(TestKnight);
            int health = TestKnight.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

        [Test]
        public void DwarfAttakedByWizard()
        {
            Wizard wizard1 = new Wizard("Test");
            wizard1.Staff = new Staff();
            wizard1.SpellsBook = new SpellsBook();
            Dwarf TestDwarf = new Dwarf("Test");
            TestDwarf.Axe = new Axe();
            TestDwarf.Helmet = new Helmet();
            TestDwarf.RecieveAttack(wizard1);
            int health = TestDwarf.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

        [Test]

        public void CureDwarf()
        {
            Dwarf TestDwarf = new Dwarf("Test");
            TestDwarf.Axe = new Axe();
            Archer TestArcher = new Archer("Test");
            TestArcher.Bow = new Bow();
            TestDwarf.RecieveAttack(TestArcher);
            TestDwarf.Cure();
            int health = TestDwarf.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }
    }
}