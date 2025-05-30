namespace TODO_APP;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        taskListView = new System.Windows.Forms.ListView();
        countLBL = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // taskListView
        // 
        taskListView.Location = new System.Drawing.Point(128, 108);
        taskListView.Name = "taskListView";
        taskListView.Size = new System.Drawing.Size(629, 349);
        taskListView.TabIndex = 0;
        taskListView.UseCompatibleStateImageBehavior = false;
        taskListView.View = System.Windows.Forms.View.Details;
        taskListView.Columns.Add("TaskName", 150, HorizontalAlignment.Center);
        taskListView.Columns.Add("Description", 300, HorizontalAlignment.Center);
        taskListView.Columns.Add("IsCompleted", 150, HorizontalAlignment.Center);
        // 
        // countLBL
        // 
        countLBL.Font = new System.Drawing.Font("Segoe UI", 15F);
        countLBL.Location = new System.Drawing.Point(377, 38);
        countLBL.Name = "countLBL";
        countLBL.Size = new System.Drawing.Size(155, 47);
        countLBL.TabIndex = 1;
        countLBL.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(895, 689);
        Controls.Add(countLBL);
        Controls.Add(taskListView);
        Location = new System.Drawing.Point(19, 19);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label countLBL;

    private System.Windows.Forms.ListView taskListView;

    #endregion
}