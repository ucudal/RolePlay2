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
    }
}