using NUnit.Framework;
using Ucu.Poo.LogicGates;

namespace Ucu.Poo.LogicGates.Tests
{
    // Tests para comprobar que la compuerta NOT funciona bien
    [TestFixture]
    public class NotTests
    {
        // Comprueba NOT true
        [Test]
        public void NotTrueReturnsFalse()
        {
            // Creamos una entrada true
            LogicValue input = new True();

            // Creamos la compuerta NOT
            Not gate = new Not(input);

            // Evaluamos la salida
            bool result = gate.Output();

            // NOT true = false
            Assert.That(result, Is.False);
        }

        // Comprueba NOT false
        [Test]
        public void NotFalseReturnsTrue()
        {
            // Creamos una entrada false
            LogicValue input = new False();

            // Creamos la compuerta NOT
            Not gate = new Not(input);

            // Evaluamos la salida
            bool result = gate.Output();

            // NOT false = true
            Assert.That(result, Is.True);
        }
    }
}