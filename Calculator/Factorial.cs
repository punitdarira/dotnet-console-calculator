namespace Calculator{
    public class Factorial{
        public static float Eval(float n){
            if (n < 0) throw new ArgumentException("Factorial of negative number is undefined.");

            long result = 1;
            for (int i = 2; i <= n; i++){
                result *= i;
            }
            return (float)result;
        }
    }
}