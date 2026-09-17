namespace Ucu.Poo.LogicGates
{
    // Clase que representa la compuerta NOT
    public class Not : Gate
    {
        // Guarda la entrada
        private LogicValue input;

        // Constructor: recibe un valor logico
        public Not(LogicValue input)
        {
            // Guarda la entrada recibida
            this.input = input;
        }

        // Devuelve el resultado de la compuerta NOT
        public bool Output()
        {
            // NOT devuelve el valor contrario de la entrada
            return !this.input.Value;
        }
    }
}