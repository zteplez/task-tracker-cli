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
        //Implement created at and updated
    }
    
    public Task(string name, string Description)
    {
        Id = 1;
        Name = name;
        Description = null;
        currentStatus = Status.NOT_DONE;
        //Implement created at and updated
    }
}