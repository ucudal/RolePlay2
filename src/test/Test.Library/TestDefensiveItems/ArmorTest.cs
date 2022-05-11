using NUnit.Framework;
using RoleplayGame;
using System;


namespace Test.Library
{
    public class ArmorTest 
    {
         [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackValueTest() //Verifico el ataque.
        {
            IItem item = new Armor();
            Assert.AreEqual(0,item.AttackValue);
             
        }
        [Test]
        public void DefenseValueTest() //Verifico la defensa.
        {
            IItem item = new Armor();
            Assert.AreEqual(25, item.DefenseValue);
        }
    }
}