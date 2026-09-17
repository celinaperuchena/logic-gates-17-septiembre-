namespace Ucu.Poo.LogicGates
{
    // Clase que representa la puerta del garage
    public class GarageGate
    {
        // Guarda el boton A
        private LogicValue inputA;

        // Guarda el boton B
        private LogicValue inputB;

        // Guarda el boton C
        private LogicValue inputC;

        // Constructor: recibe los tres botones
        public GarageGate(
            LogicValue inputA,
            LogicValue inputB,
            LogicValue inputC)
        {
            // Guarda el boton A
            this.inputA = inputA;

            // Guarda el boton B
            this.inputB = inputB;

            // Guarda el boton C
            this.inputC = inputC;
        }

        // Devuelve true si la puerta debe abrirse
        public bool Output()
        {
            // NOT A
            Not notA = new Not(this.inputA);

            // Convertimos la salida de NOT A en un LogicValue
            GateOutput notAOutput = new GateOutput(notA);

            // NOT B
            Not notB = new Not(this.inputB);

            // Convertimos la salida de NOT B en un LogicValue
            GateOutput notBOutput = new GateOutput(notB);

            // Primera parte: NOT A AND NOT B
            And firstAnd = new And(notAOutput, notBOutput);

            // Convertimos su salida en un LogicValue
            GateOutput firstAndOutput = new GateOutput(firstAnd);

            // Primera condicion completa:
            // NOT A AND NOT B AND C
            And firstCondition = new And(firstAndOutput, this.inputC);

            // Segunda parte: A AND B
            And secondAnd = new And(this.inputA, this.inputB);

            // Convertimos su salida en un LogicValue
            GateOutput secondAndOutput = new GateOutput(secondAnd);

            // Segunda condicion completa:
            // A AND B AND C
            And secondCondition = new And(secondAndOutput, this.inputC);

            // Convertimos las dos condiciones en LogicValue
            GateOutput firstConditionOutput = new GateOutput(firstCondition);
            GateOutput secondConditionOutput = new GateOutput(secondCondition);

            // La puerta abre si se cumple una condicion O la otra
            Or result = new Or(
                firstConditionOutput,
                secondConditionOutput);

            // Devolvemos el resultado final
            return result.Output();
        }
    }
}