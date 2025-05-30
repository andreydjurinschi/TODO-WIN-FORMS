namespace TODO_APP.models;

/***
 * Task model
 */
public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Desctiprion { get; set; }
    public bool isCompleted { get; set; }
}