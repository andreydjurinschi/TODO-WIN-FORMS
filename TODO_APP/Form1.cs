using TODO_APP.service;

namespace TODO_APP;
using Npgsql;
public partial class Form1 : Form
{
    private TaskService _taskService;
    public Form1()
    {
        InitializeComponent();
        string connectionString = "Host=localhost;Port=5433;Username=user;Password=pass;Database=todo_db";

        _taskService = new TaskService(connectionString);
        LoadTasks();
        GetTaskCount();
    }

    private void LoadTasks()
    {
        var tasks = _taskService.GetTasks();
        taskListView.Items.Clear();
        foreach (var task in tasks)
        {
            var item = new ListViewItem(task.Title);
            item.SubItems.Add(task.Desctiprion);
            item.SubItems.Add(task.isCompleted ? "Yes" : "No");
            taskListView.Items.Add(item);
        }
    }

    private void GetTaskCount()
    {
        int count =  _taskService.GetTaskCount();
        countLBL.Text = $"({count.ToString()})";
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}