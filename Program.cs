namespace Assignment6._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var callQueue = new CallQueue();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Call Queue Menu ---");
                Console.WriteLine("1. Add Caller");
                Console.WriteLine("2. View Queue");
                Console.WriteLine("3. Answer Next Call (Dequeue)");
                Console.WriteLine("4. Peek Next Caller");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter caller name: ");
                        string name = Console.ReadLine() ?? string.Empty;
                        Console.Write("Enter phone number: ");
                        string phone = Console.ReadLine() ?? string.Empty;
                        callQueue.Enqueue(new Customer(phone, name));
                        Console.WriteLine("Caller added to the queue.");
                        break;

                    case "2":
                        if (callQueue.IsEmpty)
                        {
                            Console.WriteLine("No callers in the queue.");
                        }
                        else
                        {
                            Console.WriteLine("Current queue:");
                            foreach (var c in callQueue.GetSnapshot())
                            {
                                Console.WriteLine(c);
                            }
                        }
                        break;

                    case "3":
                        var answered = callQueue.Dequeue();
                        if (answered == null)
                            Console.WriteLine("No callers to answer.");
                        else
                            Console.WriteLine($"Answered call from: {answered}");
                        break;

                    case "4":
                        var next = callQueue.Peek();
                        if (next == null)
                            Console.WriteLine("No callers in the queue.");
                        else
                            Console.WriteLine($"Next caller: {next}");
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
