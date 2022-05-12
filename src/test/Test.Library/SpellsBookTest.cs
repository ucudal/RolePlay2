using NUnit.Framework;
using RoleplayGame;
using System;


namespace Test.Library
{
    public class SpellsBookTest 
    {
         [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackValueTest() //Verifico el ataque del SpellsBook con un Spell.
        {
            SpellsBook spellbook = new SpellsBook();
            spellbook.Spells = new Spell[]{ new Spell() };
            Assert.AreEqual(70,spellbook.AttackValue);
             
        }
        [Test]
        public void DefenseValueTest() //Verifico la defensa del SpellBook con un Spell.
        {
            SpellsBook spellbook = new SpellsBook();
            spellbook.Spells = new Spell[]{ new Spell() };
            Assert.AreEqual(70,spellbook.DefenseValue);
             
        }
    }
}