namespace Calculator{
    public class Add: IBinaryOperator{
        public static float Eval(float lhs, float rhs){
            return lhs + rhs;
        }
        public static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}