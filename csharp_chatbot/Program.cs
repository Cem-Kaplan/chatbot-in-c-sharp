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

                if (current_input.ToLower() == "n")
                {
                    Console.WriteLine(1);
                }
                else if (current_input.ToLower() == "c")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("could'nt understand input");
                }
            }
        }
    }
}