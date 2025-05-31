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
    
    /***
     * Update task
     */

    /*public int updateTask(int id, models.Task newTask)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            var query = "update tasks set title = @title, description = @description where id = @id)";
            var cmd = new NpgsqlCommand(query, connection);
            
            cmd.Parameters.AddWithValue("@title", newTask.Title);
            cmd.Parameters.AddWithValue("@description", newTask.Desctiprion);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery();
        }
    }*/

    public int CompleteTask(int Id)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            var query = "UPDATE tasks SET is_completed = true WHERE Id = @Id";
            var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("Id",Id);
            return cmd.ExecuteNonQuery();
        }
    }

    /***
     * Create Task
     */
    public int AddTask(models.Task task)
    {
        using (var connection = new NpgsqlConnection(_connectionString)) 
        {
            connection.Open();
            var query = "Insert into tasks (title, description, is_completed) values (@title, @description, @is_completed)";
            var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", task.Title);
            cmd.Parameters.AddWithValue("@description", task.Desctiprion);
            cmd.Parameters.AddWithValue("@is_completed", task.isCompleted);
            return cmd.ExecuteNonQuery();
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
    /**+
     * Get completed tasks
     */
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