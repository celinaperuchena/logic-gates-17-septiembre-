namespace Ucu.Poo.LogicGates
{
    // Representa el resultado de una compuerta como un valor logico
    public class GateOutput : LogicValue
    {
        // Guarda la compuerta de la que queremos obtener el resultado
        private Gate gate;

        // Constructor: recibe una compuerta
        public GateOutput(Gate gate)
        {
            // Guarda la compuerta recibida
            this.gate = gate;
        }

        // Devuelve el resultado de la compuerta como true o false
        public bool Value
        {
            get
            {
                return this.gate.Output();
            }
        }
    }
}