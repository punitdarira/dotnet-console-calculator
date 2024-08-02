namespace Calculator {
    public class Inverse {
        public static float Eval(float value) {
            if (value == 0) {
                throw new DivideByZeroException("Cannot find the inverse of zero.");
            }
            return 1 / value;
        }
    }
}
