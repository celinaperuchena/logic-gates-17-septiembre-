using NUnit.Framework;
using Ucu.Poo.LogicGates;

namespace Ucu.Poo.LogicGates.Tests
{
    // Tests para comprobar que la compuerta AND funciona bien
    [TestFixture]
    public class AndTests
    {
        // Comprueba true AND true
        [Test]
        public void TrueAndTrueReturnsTrue()
        {
            LogicValue input1 = new True();
            LogicValue input2 = new True();

            And gate = new And(input1, input2);

            bool result = gate.Output();

            Assert.That(result, Is.True);
        }

        // Comprueba true AND false
        [Test]
        public void TrueAndFalseReturnsFalse()
        {
            LogicValue input1 = new True();
            LogicValue input2 = new False();

            And gate = new And(input1, input2);

            bool result = gate.Output();

            Assert.That(result, Is.False);
        }

        // Comprueba false AND true
        [Test]
        public void FalseAndTrueReturnsFalse()
        {
            LogicValue input1 = new False();
            LogicValue input2 = new True();

            And gate = new And(input1, input2);

            bool result = gate.Output();

            Assert.That(result, Is.False);
        }

        // Comprueba false AND false
        [Test]
        public void FalseAndFalseReturnsFalse()
        {
            LogicValue input1 = new False();
            LogicValue input2 = new False();

            And gate = new And(input1, input2);

            bool result = gate.Output();

            Assert.That(result, Is.False);
        }

        // Comprueba que podemos conectar una compuerta con otra
        [Test]
        public void GatesCanBeConnected()
        {
            // Primera compuerta: NOT true = false
            Not notGate = new Not(new True());

            // Convertimos la salida de NOT en un LogicValue
            GateOutput notOutput = new GateOutput(notGate);

            // Usamos esa salida como entrada de AND
            And andGate = new And(notOutput, new True());

            // false AND true = false
            bool result = andGate.Output();

            Assert.That(result, Is.False);
        }
    }
}