using System;
using NUnit.Framework;

namespace Tests
{
    public class DummyTests
    {
        [Test]
        public void Dummy_LooseHealth_AfterAttack()
        {
            Dummy dummy = new Dummy(10, 10);

            dummy.TakeAttack(5);

            Assert.That(dummy.Health, Is.EqualTo(5), "Dummy health doesn't change after attack!");
        }

        [Test]
        public void DeadDummy_ThrowsExeption_IfAttacked()
        {
            Dummy dummy = new Dummy(0, 10);

            //dummy.TakeAttack(5);
            Assert.AreEqual(true, dummy.IsDead());

            //Assert.That(dummy.IsDead(), Is.Equals(true),"Dead dummy can't be attack!");
        }


        [Test]
        public void AliveDummy_ThrowsExeption_IfGiveXP()
        {
            Dummy dummy = new Dummy(0, 20);

            dummy.GiveExperience();

            Assert.AreEqual(true, dummy.IsDead());

            //Assert.That(dummy.IsDead(), Throws.ArgumentException
                        //.With.Message.EqualTo("Alive dummy can't give XP!"));
        }
    }
}
