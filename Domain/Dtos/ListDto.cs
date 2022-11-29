public enum Status
{
    ToDo,
    InProgress,
    Complete
}

public class ListDto
{
    public int id { get; set; }
    public string? TaskName { get; set; }
    public Status Status { get; set; }
}

public class GetListDto
{
    public int id { get; set; }
    public string? TaskName { get; set; }
    public string? StatusName
     {
        get { return Status.ToString();}  
     }
    public Status Status { get; set; }
}

