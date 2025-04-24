using System;

class Program
{
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
            LogArgs(args);
            string firstCommand = args[0].ToLower();

            switch (firstCommand)
            {
                case "add":
                    break;
                case "update":
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
        Console.WriteLine("  list                List all tasks.");
        Console.WriteLine("  remove <id>         Delete specified task with ID");
        Console.WriteLine("  -h, --help          Shows help.");
    }


}