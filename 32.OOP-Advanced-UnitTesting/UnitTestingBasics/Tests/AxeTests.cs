using System;

namespace Tests
{
    using NUnit.Framework;

    public class AxeTests
    {
        [Test]
        public void Axe_LooseDurability_AfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), 
                        "Axe Durability doesn't change after attack.");
        }

        [Test]
        public void BrokenAxe_CannotAttack()
        {
            Axe axe = new Axe(5, 1);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException
                        .With.Message.EqualTo("Axe is broken."));
        }
    }
}
