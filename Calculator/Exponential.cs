namespace Calculator{
    public class Exponential: IBinaryOperator{
        public static float Eval(float a, float b){
            return (float)Math.Pow(a, b);
        }
    }
}