using Npgsql;
using Task = System.Threading.Tasks.Task;

namespace TODO_APP.service;

public class TaskService
{
    private readonly string _connectionString;

    public TaskService(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    
    /***
     * Get all tasks
     */
    public List<models.Task> GetTasks()
    {
        var tasks = new List<models.Task>();
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM tasks", connection);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var task = new models.Task();
                    task.Id = reader.GetInt32(0);
                    task.Title = reader.GetString(1);
                    task.Desctiprion = reader.GetString(2);
                    task.isCompleted = reader.GetBoolean(3);
                    tasks.Add(task);
                }
            }
        }
        return tasks;
    }

    private void addTask(models.Task task)
    {
        using (var connection = new NpgsqlConnection(_connectionString)) 
        {
            connection.Open();
            var query = "Insert into tasks (title, description, isCompleted) values (@title, @description, @isCompleted)";
            var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", task.Title);
            cmd.Parameters.AddWithValue("@description", task.Desctiprion);
            cmd.Parameters.AddWithValue("@isCompleted", task.isCompleted);
            cmd.ExecuteNonQuery();
        }
    }

    /***
     * Get task Count
     */
    public int GetTaskCount()
    {
        var tasks = new List<models.Task>();
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM tasks", connection);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var task = new models.Task();
                    task.Id = reader.GetInt32(0);
                    task.Title = reader.GetString(1);
                    task.Desctiprion = reader.GetString(2);
                    task.isCompleted = reader.GetBoolean(3);
                    tasks.Add(task);
                }
            }
        }
        return tasks.Count;
    }
    public int GetCompletedTasks()
    {
        var tasks = new List<models.Task>();
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM tasks where is_completed = true", connection);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var task = new models.Task();
                    task.Id = reader.GetInt32(0);
                    task.Title = reader.GetString(1);
                    task.Desctiprion = reader.GetString(2);
                    task.isCompleted = reader.GetBoolean(3);
                    tasks.Add(task);
                }
            }
        }
        return tasks.Count;
    }
}