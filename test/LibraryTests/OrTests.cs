using NUnit.Framework;
using Ucu.Poo.LogicGates;

namespace Ucu.Poo.LogicGates.Tests
{
    // Tests para comprobar que la compuerta OR funciona bien
    [TestFixture]
    public class OrTests
    {
        // Comprueba true OR true
        [Test]
        public void TrueOrTrueReturnsTrue()
        {
            LogicValue input1 = new True();
            LogicValue input2 = new True();

            Or gate = new Or(input1, input2);

            bool result = gate.Output();

            Assert.That(result, Is.True);
        }

        // Comprueba true OR false
        [Test]
        public void TrueOrFalseReturnsTrue()
        {
            LogicValue input1 = new True();
            LogicValue input2 = new False();

            Or gate = new Or(input1, input2);

            bool result = gate.Output();

            Assert.That(result, Is.True);
        }

        // Comprueba false OR true
        [Test]
        public void FalseOrTrueReturnsTrue()
        {
            LogicValue input1 = new False();
            LogicValue input2 = new True();

            Or gate = new Or(input1, input2);

            bool result = gate.Output();

            Assert.That(result, Is.True);
        }

        // Comprueba false OR false
        [Test]
        public void FalseOrFalseReturnsFalse()
        {
            LogicValue input1 = new False();
            LogicValue input2 = new False();

            Or gate = new Or(input1, input2);

            bool result = gate.Output();

            Assert.That(result, Is.False);
        }
    }
}