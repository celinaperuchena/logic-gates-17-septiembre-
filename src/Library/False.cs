namespace Ucu.Poo.LogicGates
{
    // Clase que representa el valor logico false
    public class False : LogicValue
    {
        // Devuelve siempre false
        public bool Value
        {
            get
            {
                return false;
            }
        }
    }
}