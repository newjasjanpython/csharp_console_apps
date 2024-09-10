using System;


class Program
{
    static void Main()
    {
        string[] formulas = [
            "a + b",
            "a * b",
            "a - b",
            "a / b",
            "a ^ b"
        ];

        for (int i = 1; i <= formulas.Length; i++)
        {
            Console.WriteLine($"{i}. {formulas[i-1]}");
        }

        int formulaNumber = 0;

        while (true)
        {
            formulaNumber = AskForNumber("Formula number");
            if (0 < formulaNumber && formulaNumber <= formulas.Length)
            {
                break;
            }
            else
            {
                Console.WriteLine("Enter valid formula number;");
            }
        }

        formulaNumber -= 1;

        int a = AskForNumber("a");
        int b = AskForNumber("b");

        if (formulas[formulaNumber] == "a + b")
        {
            Console.WriteLine($"{a} + {b} = {a + b}\n==========");
        }
        else if (formulas[formulaNumber] == "a - b")
        {
            Console.WriteLine($"{a} + {b} = {a - b}\n==========");
        }
        else if (formulas[formulaNumber] == "a * b")
        {
            Console.WriteLine($"{a} + {b} = {a * b}\n==========");
        }
        else if (formulas[formulaNumber] == "a / b")
        {
            Console.WriteLine($"{a} + {b} = {a / b}\n==========");
        }
        else if (formulas[formulaNumber] == "a ^ b")
        {
            Console.WriteLine($"{a} + {b} = {Math.Pow(a, b)}\n==========");
        }
    }

    static int AskForNumber(string QueryName)
    {
        Console.Write($"Enter number: {QueryName};> ");
        while (true)
        {
            string? intResult = Console.ReadLine();
            if (!int.TryParse(intResult, out int result))
            {
                Console.WriteLine($"Enter valid number: {QueryName};");
            }
            else
            {
                return result;
            }
        }
    }
}
