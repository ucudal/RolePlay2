using NUnit.Framework;
using RoleplayGame;
using System;


namespace Test.Library
{
    public class HelmetTest 
    {
         [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackValueTest() //Verifico el ataque.
        {
            IItem item = new Helmet();
            Assert.AreEqual(0,item.AttackValue);
             
        }
        [Test]
        public void DefenseValueTest() //Verifico la defensa.
        {
            IItem item = new Helmet();
            Assert.AreEqual(18, item.DefenseValue);
        }
        
    }
}