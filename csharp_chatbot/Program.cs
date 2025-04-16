namespace chatbot
{
    class Program
    {
        static void Main()
        {
            bool running = true;

            while(running)
            {
                string? current_input = Convert.ToString(Console.ReadLine());

                if (DictionaryClass.woerterbuch2.ContainsKey(current_input.ToLower()))
                {
                    // ich nutze 2 classes:
                    // 1. DictionaryClass (für antworten)
                    // 2. Bot (damit der nutzer weiß mit wem er schreibt)
                    Console.WriteLine(Bot.Answer(DictionaryClass.woerterbuch2[current_input.ToLower()]));
                    //Console.WriteLine(DictionaryClass.woerterbuch2[current_input.ToLower()]);
                }
                else if (current_input.ToLower() == "exit")
                {
                    Console.WriteLine("Programm wird beendet");
                    running = false;
                }
                else if (current_input.ToLower() == "berechne")
                {
                    Calculator calculator = new Calculator();

                    Console.WriteLine("Bitte 2 zahlen eingeben, dann entweder + / - oder *");

                    int num1 = Convert.ToInt16(Console.ReadLine());
                    int num2 = Convert.ToInt16(Console.ReadLine());
                    // TODO: hier muss noch ein exit button geschrieben werden.
                    while(true)
                    {
                        string? operator_1 = Console.ReadLine()?.Trim();
                        if (operator_1 == "+")
                        {
                            Console.WriteLine(calculator.Addition(num1, num2));
                            break;
                        }
                        else if (operator_1 == "-")
                        {
                            Console.WriteLine(calculator.Subtraction(num1, num2));
                            break;
                        }
                        else if (operator_1 == "*")
                        {
                            Console.WriteLine(calculator.Multiplication(num1, num2));
                            break;
                        }
                        else if (operator_1 == "/")
                        {
                            Console.WriteLine(calculator.Division(num1, num2));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Bitte ein richtigen operator eingeben");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nicht verstanden");
                }
            }
        }
    }
    public static class DictionaryClass
    {
        public static Dictionary<string, string> woerterbuch2 = new Dictionary<string, string>()
        {
            {"hallo","Hallo! wie kann ich behilflich sein"},
            {"wie gehts","Gut! Danke."},
        };
        
    }
    public class Calculator
    {
        public int Addition(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        public int Subtraction(int x, int y)
        {
            int sum = x - y;
            return sum;
        }
        public int Multiplication(int x, int y)
        {
            int sum = x * y;
            return sum;
        }
        public int Division(int x, int y)
        {
            int sum = x / y;
            return sum;
        }
    }   
    public static class Bot
    {
        public static string Answer(string answer)
        {
            return $"ChatBot: {answer}";
        }
    }
}