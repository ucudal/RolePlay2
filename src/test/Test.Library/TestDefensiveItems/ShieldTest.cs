using NUnit.Framework;
using RoleplayGame;
using System;


namespace Test.Library
{
    public class ShieldTest 
    {
         [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackValueTest() //Verifico el ataque.
        {
            IItem item = new Shield();
            Assert.AreEqual(0,item.AttackValue);
             
        }
        [Test]
        public void DefenseValueTest() //Verifico la defensa.
        {
            IItem item = new Shield();
            Assert.AreEqual(14, item.DefenseValue);
        }
    }
}