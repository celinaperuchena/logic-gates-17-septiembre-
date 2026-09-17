namespace Ucu.Poo.LogicGates
{
    // Clase que representa la compuerta AND
    public class And : Gate
    {
        // Guarda la primera entrada
        private LogicValue input1;

        // Guarda la segunda entrada
        private LogicValue input2;

        // Constructor: recibe dos valores logicos
        public And(LogicValue input1, LogicValue input2)
        {
            // Guarda la primera entrada
            this.input1 = input1;

            // Guarda la segunda entrada
            this.input2 = input2;
        }

        // Devuelve el resultado de la compuerta AND
        public bool Output()
        {
            // AND devuelve true solamente si las dos entradas son true
            return this.input1.Value && this.input2.Value;
        }
    }
}