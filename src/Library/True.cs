namespace Ucu.Poo.LogicGates
{
    // Clase que representa el valor logico true
    public class True : LogicValue
    {
        // Devuelve siempre true
        public bool Value
        {
            get
            {
                return true;
            }
        }
    }
}