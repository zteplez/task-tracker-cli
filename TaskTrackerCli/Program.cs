using System;

class Program
{
    public static List<string> tasks = new List<string>();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello CLI!");

        if (args.Length == 0)
        {
            Console.WriteLine("Empty CLI command.");
            return;
        }
        else
        {
            //LogArgs(args);
            string firstCommand = args[0].ToLower();

            switch (firstCommand)
            {
                case "add":
                    HandleAddCommand(args);
                    break;
                case "update":
                    HandleUpdateCommand(args);
                    break;
                case "delete":
                    break;
                case "mark-in-progress":
                    break;
                case "mark-done":
                    break;
                case "list":
                    break;
                case "help":
                    break;
                default:
                    ShowHelp();
                    break;
            }
        }
    }
    public static void LogArgs(string[] args)
    {
        foreach (string arg in args)
        {
            Console.WriteLine($"Arg value -> {arg} \n");
        }
    }
    public static void ShowHelp()
    {
        Console.WriteLine("Usage:");
        Console.WriteLine("  add <task>          Add new task.");
        Console.WriteLine("  add <task> <description>          Add new task with description.");
        Console.WriteLine("  list                List all tasks.");
        Console.WriteLine("  remove <id>         Delete specified task with ID");
        Console.WriteLine("  -h, --help          Shows help.");
    }
    public static void HandleAddCommand(string[] args)
    {
        switch (args.Length)
        {
            case 2:
                tasks.Add(args[1]);
                Console.WriteLine($"Add {args[1]}.");
                break;
            case 3:
                tasks.Add(args[1]); // also pass description
                Console.WriteLine($"Add {args[1]}.");
                break;
            default:
                Console.WriteLine("Wrong use case, please check for --help.");
                break;
        }
    }
    public static void HandleUpdateCommand(string[] args)
    {
        if (args.Length < 3)
        { // Checks if task id and value passed or empty
            Console.WriteLine("Missing id or new task value ");
            return;
        }
        if (args.Length > 3)
        {
            Console.WriteLine("You should pass just id and new task value");
            return;
        }
        // Check all tasks id and compare the passaed value if you find the task object store here.
        // if you cant find task id then print a message that task doesnt exist.
        // assign a new value task object.

    }
}