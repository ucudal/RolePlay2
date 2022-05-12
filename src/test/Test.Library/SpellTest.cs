using NUnit.Framework;
using RoleplayGame;
using System;


namespace Test.Library
{
    public class SpellTest 
    {
         [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackValueTest() //Verifico el ataque.
        {
            IItem item = new Spell();
            Assert.AreEqual(70,item.AttackValue);
             
        }
        [Test]
        public void DefenseValueTest() //Verifico la defensa.
        {
            IItem item = new Spell();
            Assert.AreEqual(70, item.DefenseValue);
        }
    }
}