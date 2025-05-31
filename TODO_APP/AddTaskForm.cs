using TODO_APP.service;
using Task = TODO_APP.models.Task;

namespace TODO_APP;

public partial class AddTaskForm : Form
{
    private TaskService _taskService; 
    public AddTaskForm()
    {
        string connectionString = "Host=localhost;Port=5433;Username=user;Password=pass;Database=todo_db";
        _taskService = new TaskService(connectionString);
        InitializeComponent();
    }


    private void saveButton_Click(object sender, EventArgs e)
    {
        string title = titleTextBox.Text;
        string description = DescriptionTextBox.Text;

        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
        {
            MessageBox.Show("Title and Description are required");
            titleTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            return; 
        }

        var newTask = new models.Task
        {
            Title = title,
            Desctiprion = description,
            isCompleted = false
        };

        int result = _taskService.AddTask(newTask);
        if (result > 0)
        {
            MessageBox.Show("Task added successfully");
            titleTextBox.Text = string.Empty;            
            DescriptionTextBox.Text = string.Empty;
        }
        else
        {
            MessageBox.Show("Task could not be added");
        }
    }


    private void gobackBTN_Click(object sender, EventArgs e)
    {
        var main = new Form1();
        Close();
        main.Show();
    }
}