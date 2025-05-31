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
        GetCompletedTasks();
    }

    private void LoadTasks()
    {
        ConfigureListView();
        var tasks = _taskService.GetTasks();
        foreach (var task in tasks)
        {
            var item = new ListViewItem(task.Title);
            item.SubItems.Add(task.Desctiprion);
            item.SubItems.Add(task.isCompleted ? "Yes" : "No");
            item.Tag = task.Id;
            taskListView.Items.Add(item);
        }
    }

    private void GetTaskCount()
    {
        ConfigureListView();
        int count =  _taskService.GetTaskCount();
        countLBL.Text = $"Task count: {count.ToString()}";
    }

    private void GetCompletedTasks()
    {
        ConfigureListView();
        int count = _taskService.GetCompletedTasks();
        completedTaasksLabel.Text = $"Completed tasks: {count.ToString()}";
    }
    
    private void ConfigureListView()
    {
        taskListView.Columns.Clear(); 
        taskListView.View = View.Details;
        taskListView.FullRowSelect = true;
        taskListView.GridLines = true;

        taskListView.Columns.Clear(); 
        taskListView.Columns.Add("Title", 200);
        taskListView.Columns.Add("Content", 300);
        taskListView.Columns.Add("Is completed", 100);
    }
    private void newTaskFormBTN_Click_1(object sender, EventArgs e)
    {
        var addTaskForm = new AddTaskForm();
        Hide();
        addTaskForm.ShowDialog();
    }

    private void editBTN_Click(object sender, EventArgs e)
    {
        if (taskListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please select a task to edit.");
            return;
        }

        var selected = taskListView.SelectedItems[0];
        var id = (int) selected.Tag!;
        var result = _taskService.CompleteTask(id);
        if (result > 0)
        {
            MessageBox.Show("Task completed successfully");
            taskListView.Clear();
            LoadTasks();
            return;
        }
        MessageBox.Show("Unrecognized error");
    }
}