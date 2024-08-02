using Calculator;

Prompts.PrintWelcomeMenu();

while (true){
    Prompts.PrintOptions();
    Console.WriteLine("Enter operation number: ");
    string? OptionChoice = Console.ReadLine();

    if(OptionChoice == "exit"){
        return;
    }

    Console.WriteLine("Enter number 1: ");
    string? Number1 = Console.ReadLine();
    string? Number2 = "0";

    if (!new[] { "5", "6", "7", "8", "9", "10", "11" }.Contains(OptionChoice)){
        Console.WriteLine("Enter number 2: ");
        Number2 = Console.ReadLine();
    }

    float Number1Converted = float.Parse(Number1);
    float Number2Converted = float.Parse(Number2);
    switch(OptionChoice){
        case "1":
            float Sum = Evaluator.Eval("+", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted} + {Number2Converted} = {Sum}");
            break;
        case "3":
            float Product = Evaluator.Eval("*", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted} * {Number2Converted} = {Product}");
            break;
        case "4":
            float division = Evaluator.Eval("/", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted} / {Number2Converted} = {division}");
            break;
        case "5":
            float cosine = Evaluator.Eval("CS", Number1Converted, Number2Converted);
            Console.WriteLine($" Cosine of {Number1Converted} = {cosine}");
            break;
        case "6":
            float sine = Evaluator.Eval("S", Number1Converted, Number2Converted);
            Console.WriteLine($" Sine of {Number1Converted} = {sine}");
            break;
        case "7":
            float tangent = Evaluator.Eval("T", Number1Converted, Number2Converted);
            Console.WriteLine($" Tangent of {Number1Converted} = {tangent}");
            break;
        case "8":
            float factorial = Evaluator.Eval("F", Number1Converted, Number2Converted);
            Console.WriteLine($" Factorial of {Number1Converted} = {factorial}");
            break;
        case "9":
            float squareRoot = Evaluator.Eval("SR", Number1Converted, Number2Converted);
            Console.WriteLine($" Square root of {Number1Converted} = {squareRoot}");
            break;
        case "10":
            float exponential = Evaluator.Eval("E", Number1Converted, Number2Converted);
            Console.WriteLine($" Exponential of {Number1Converted} = {exponential}");
            break;
        case "11":
            float Inverse = Evaluator.Eval("I", Number1Converted);
            Console.WriteLine($" Inverse of {Number1Converted} = {Inverse}");
            break;
        default:
            throw new Exception("unimplemented");
    }
}