﻿using Calculator;

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
    Console.WriteLine("Enter number 2: ");
    string? Number2 = Console.ReadLine();

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
        default:
            throw new Exception("unimplemented");
    }
}