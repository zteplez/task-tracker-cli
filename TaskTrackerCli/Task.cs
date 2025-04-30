public class Task
{
    enum Status { DONE, IN_PROGRESS, NOT_DONE }
    public int Id;
    public string? Name;
    public string? Description;
    Status currentStatus;
    DateTime createdAt;
    DateTime updatedAt;

    public Task(string name)
    {
        Id = 1;
        Name = name;
        Description = null;
        currentStatus = Status.NOT_DONE;
        createdAt = DateTime.Now;
    }
    
    public Task(string name, string description)
    {
        Id = 1;
        Name = name;
        Description = description;
        currentStatus = Status.NOT_DONE;
        createdAt = DateTime.Now;
    }
    public void PrintTask(){
        Console.WriteLine($"{Id} - {Name} - {currentStatus}");
        if(Description != null){
            Console.WriteLine($"--------> {Description}");
        }
    }
}