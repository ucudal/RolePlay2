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
    }
}