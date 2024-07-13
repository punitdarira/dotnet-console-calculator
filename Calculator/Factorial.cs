namespace Calculator{
    public class Factorial{
        public static float Eval(float n){
            long result = 1;
            for (int i = 2; i <= n; i++){
                result *= i;
            }
            return (float)result;
        }
    }
}