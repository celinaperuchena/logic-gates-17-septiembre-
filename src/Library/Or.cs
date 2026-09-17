namespace Ucu.Poo.LogicGates
{
    // Clase que representa la compuerta OR
    public class Or : Gate
    {
        // Guarda la primera entrada
        private LogicValue input1;

        // Guarda la segunda entrada
        private LogicValue input2;

        // Constructor: recibe dos valores logicos
        public Or(LogicValue input1, LogicValue input2)
        {
            // Guarda la primera entrada
            this.input1 = input1;

            // Guarda la segunda entrada
            this.input2 = input2;
        }

        // Devuelve el resultado de la compuerta OR
        public bool Output()
        {
            // OR devuelve true si por lo menos una entrada es true
            return this.input1.Value || this.input2.Value;
        }
    }
}