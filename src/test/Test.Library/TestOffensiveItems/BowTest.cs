using NUnit.Framework;
using RoleplayGame;
using System;


namespace Test.Library
{
    public class BowTest 
    {
         [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackValueTest() //Verifico el ataque.
        {
            IItem item = new Bow();
            Assert.AreEqual(15,item.AttackValue);
             
        }
        [Test]
        public void DefenseValueTest() //Verifico la defensa.
        {
            IItem item = new Bow();
            Assert.AreEqual(0, item.DefenseValue);
        }
    }
}