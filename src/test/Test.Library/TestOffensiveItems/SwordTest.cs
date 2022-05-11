using NUnit.Framework;
using RoleplayGame;
using System;


namespace Test.Library
{
    public class SwordTest 
    {
         [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackValueTest() //Verifico el ataque.
        {
            IItem item = new Sword();
            Assert.AreEqual(20,item.AttackValue);
             
        }
        [Test]
        public void DefenseValueTest() //Verifico la defensa.
        {
            IItem item = new Sword();
            Assert.AreEqual(0, item.DefenseValue);
        }
    }
}