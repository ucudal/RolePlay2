using NUnit.Framework;
using RoleplayGame;
using System;


namespace Test.Library
{
    public class Wizardtest 
    {
         [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackValueTest() //Verifico el ataque total del Wizard.
        {
            Wizard wizard = new Wizard("Pedro");
            SpellsBook spellbook = new SpellsBook();
            spellbook.Spells = new Spell[]{ new Spell() };
            Staff staff = new Staff();
            wizard.SpellsBook = spellbook;
            wizard.Staff = staff;

            Assert.AreEqual(spellbook.AttackValue + staff.AttackValue, wizard.AttackValue);
        }

        [Test]
        public void DefenseValueTest() //Verifico la defensa total del Wizard.
        {
            Wizard wizard = new Wizard("Pedro");
            SpellsBook spellbook = new SpellsBook();
            spellbook.Spells = new Spell[]{ new Spell() };
            Staff staff = new Staff();
            wizard.SpellsBook = spellbook;
            wizard.Staff = staff;

            Assert.AreEqual(spellbook.DefenseValue + staff.DefenseValue, wizard.DefenseValue);
        }

        [Test]
        public void WizardAttackedByArcher() //Verifico el ataque del Archer al Wizard.
        {
            Wizard wizard1 = new Wizard("Test");
            wizard1.Staff = new Staff();
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            wizard1.SpellsBook = book;
            Archer TestArcher = new Archer("Test");
            TestArcher.Bow = new Bow();
            wizard1.RecieveAttack(TestArcher);
            int health = wizard1.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

         [Test]
        public void WizardAttackedByDwarf() //Verifico el ataque del Dwarf al Wizard.
        {
            Wizard wizard1 = new Wizard("Test");
            wizard1.Staff = new Staff();
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            wizard1.SpellsBook = book;
            Dwarf TestWizard = new Dwarf("Test");
            TestWizard.Axe = new Axe();
            wizard1.RecieveAttack(TestWizard);
            int health = wizard1.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

        [Test]
        public void WizardAttackedByKnight() //Verifico el ataque del Knight al Wizard.
        {
            Wizard wizard1 = new Wizard("Test");
            wizard1.Staff = new Staff();
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            wizard1.SpellsBook = book;
            Knight TestKnight = new Knight("Test");
            TestKnight.Sword = new Sword();
            wizard1.RecieveAttack(TestKnight);
            int health = wizard1.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }
        [Test]
        public void CureWizard() //Curar al Wizard.
        {
            Wizard TestWizard = new Wizard("Test");
            TestWizard.Staff = new Staff();
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            TestWizard.SpellsBook = book;
            Archer TestArcher = new Archer("Test");
            TestArcher.Bow = new Bow();
            TestWizard.RecieveAttack(TestArcher);
            TestWizard.Cure();
            int health = TestWizard.Health;
            int expected = 100;
            Assert.AreEqual(expected,health);
        }

     }
}