using NUnit.Framework;
using RoleplayGame;
using System;


namespace Test.Library
{
    public class AxeTest 
    {
         [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackValueTest() //Verifico el ataque.
        {
            IItem item = new Axe();
            Assert.AreEqual(25,item.AttackValue);
             
        }
        [Test]
        public void DefenseValueTest() //Verifico la defensa.
        {
            IItem item = new Axe();
            Assert.AreEqual(0, item.DefenseValue);
        }
    }
}