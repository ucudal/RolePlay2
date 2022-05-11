using NUnit.Framework;
using RoleplayGame;
using System;


namespace Test.Library
{
    public class StaffTest 
    {
         [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackValueTest() //Verifico el ataque.
        {
            IItem item = new Staff();
            Assert.AreEqual(100,item.AttackValue);
             
        }
        [Test]
        public void DefenseValueTest() //Verifico la defensa.
        {
            IItem item = new Staff();
            Assert.AreEqual(100, item.DefenseValue);
        }
    }
}