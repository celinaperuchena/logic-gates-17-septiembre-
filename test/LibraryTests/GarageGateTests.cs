using NUnit.Framework;
using Ucu.Poo.LogicGates;

namespace Ucu.Poo.LogicGates.Tests
{
    // Tests para comprobar que la puerta del garage funciona bien
    [TestFixture]
    public class GarageGateTests
    {
        // A apagado, B apagado y C apagado
        [Test]
        public void FalseFalseFalseReturnsFalse()
        {
            LogicValue a = new False();
            LogicValue b = new False();
            LogicValue c = new False();

            GarageGate garage = new GarageGate(a, b, c);

            bool result = garage.Output();

            Assert.That(result, Is.False);
        }

        // A apagado, B apagado y C prendido
        // La puerta abre
        [Test]
        public void FalseFalseTrueReturnsTrue()
        {
            LogicValue a = new False();
            LogicValue b = new False();
            LogicValue c = new True();

            GarageGate garage = new GarageGate(a, b, c);

            bool result = garage.Output();

            Assert.That(result, Is.True);
        }

        // A apagado, B prendido y C apagado
        [Test]
        public void FalseTrueFalseReturnsFalse()
        {
            LogicValue a = new False();
            LogicValue b = new True();
            LogicValue c = new False();

            GarageGate garage = new GarageGate(a, b, c);

            bool result = garage.Output();

            Assert.That(result, Is.False);
        }

        // A apagado, B prendido y C prendido
        [Test]
        public void FalseTrueTrueReturnsFalse()
        {
            LogicValue a = new False();
            LogicValue b = new True();
            LogicValue c = new True();

            GarageGate garage = new GarageGate(a, b, c);

            bool result = garage.Output();

            Assert.That(result, Is.False);
        }

        // A prendido, B apagado y C apagado
        [Test]
        public void TrueFalseFalseReturnsFalse()
        {
            LogicValue a = new True();
            LogicValue b = new False();
            LogicValue c = new False();

            GarageGate garage = new GarageGate(a, b, c);

            bool result = garage.Output();

            Assert.That(result, Is.False);
        }

        // A prendido, B apagado y C prendido
        [Test]
        public void TrueFalseTrueReturnsFalse()
        {
            LogicValue a = new True();
            LogicValue b = new False();
            LogicValue c = new True();

            GarageGate garage = new GarageGate(a, b, c);

            bool result = garage.Output();

            Assert.That(result, Is.False);
        }

        // A prendido, B prendido y C apagado
        [Test]
        public void TrueTrueFalseReturnsFalse()
        {
            LogicValue a = new True();
            LogicValue b = new True();
            LogicValue c = new False();

            GarageGate garage = new GarageGate(a, b, c);

            bool result = garage.Output();

            Assert.That(result, Is.False);
        }

        // A, B y C prendidos
        // La puerta abre
        [Test]
        public void TrueTrueTrueReturnsTrue()
        {
            LogicValue a = new True();
            LogicValue b = new True();
            LogicValue c = new True();

            GarageGate garage = new GarageGate(a, b, c);

            bool result = garage.Output();

            Assert.That(result, Is.True);
        }
    }
}