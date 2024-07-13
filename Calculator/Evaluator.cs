namespace Calculator{
    public class Evaluator{
        public static float Eval(string Operator, params float[] Operands){
            float result;
            switch(Operator){
                case "+":
                    result = Add.Eval(Operands[0], Operands[1]);
                    break;
                case "*":
                    result = Multiply.Eval(Operands[0], Operands[1]);
                    break;
                case "/":
                    result = Divide.Eval(Operands[0], Operands[1]);
                    break;
                case "CS":
                    result = Cosine.Eval(Operands[0]);
                    break;
                case "S":
                    result = Sine.Eval(Operands[0]);
                    break;
                case "T":
                    result = Tangent.Eval(Operands[0]);
                    break;
                case "F":
                    result = Factorial.Eval(Operands[0]);
                    break;
                case "SR":
                    result = SquareRoot.Eval(Operands[0]);
                    break;
                case "E":
                    result = Exponential.Eval(Operands[0], Operands[0]);
                    break;
                default:
                    throw new Exception("unimplemented");
            }
            return result;
        }
    }
}