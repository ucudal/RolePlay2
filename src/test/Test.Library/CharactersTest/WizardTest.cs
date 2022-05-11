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
            Staff staff = new Staff();
            wizard.SpellsBook = spellbook;

            spellbook.Spells = new Spell[]{ new Spell() };

            Assert.AreEqual(spellbook.AttackValue + staff.AttackValue, wizard.AttackValue);
        }

        [Test]
        public void DefenseValueTest() //Verifico la defensa total del Wizard.
        {
            IItem spellbook = new SpellsBook();
            IItem staff = new Staff();

            Assert.AreEqual(170, spellbook.DefenseValue + staff.DefenseValue);
        }

        [Test]
        public void HealthTest() //Verifico la salud total del Wizard.
        {
            ICharacter wizard = new Wizard("Pedro");
    
            Assert.AreEqual(100, wizard.Health);
        }

        [Test]
        public void RecieveAttackFromKnightTest() //Verifico cuando el Wizard recibe un ataque, en este caso lo ataca un Knight (tiene un item sword 20 de daño).
        {
            ICharacter attacker = new Knight("James");
            ICharacter wizard = new Wizard("Pedro");
            wizard.RecieveAttack(attacker);
    
            Assert.AreEqual(80, wizard.Health);
        }

        [Test]
        public void RecieveAttackFromDwarfTest() //Verifico cuando el Wizard recibe un ataque, en este caso lo ataca un Dward (tiene un item axe 25 de daño).
        {
            ICharacter attacker = new Dwarf("Jane");
            ICharacter wizard = new Wizard("Pedro");
            wizard.RecieveAttack(attacker);
    
            Assert.AreEqual(75, wizard.Health);
        }

        [Test]
        public void RecieveAttackFromArcherTest() //Verifico cuando el Wizard recibe un ataque, en este caso lo ataca un Archer (tiene un item bow 15 de daño).
        {
            ICharacter attacker = new Archer("Freya");
            ICharacter wizard = new Wizard("Pedro");
            wizard.RecieveAttack(attacker);
    
            Assert.AreEqual(85, wizard.Health);
        }

        [Test]
        public void CureTest() //Verifico cuando el Wizard se cura.
        {
            ICharacter attacker = new Archer("Freya");
            ICharacter wizard = new Wizard("Pedro");
            wizard.RecieveAttack(attacker);

            wizard.Cure();
    
            Assert.AreEqual(100, wizard.Health);
        }
    }
}