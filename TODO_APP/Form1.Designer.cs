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
        completedTaasksLabel = new System.Windows.Forms.Label();
        newTaskFormBTN = new System.Windows.Forms.Button();
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
        // 
        // countLBL
        // 
        countLBL.Font = new System.Drawing.Font("Segoe UI", 8F);
        countLBL.Location = new System.Drawing.Point(128, 460);
        countLBL.Name = "countLBL";
        countLBL.Size = new System.Drawing.Size(73, 19);
        countLBL.TabIndex = 1;
        countLBL.Text = "label1";
        // 
        // completedTaasksLabel
        // 
        completedTaasksLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
        completedTaasksLabel.Location = new System.Drawing.Point(128, 490);
        completedTaasksLabel.Name = "completedTaasksLabel";
        completedTaasksLabel.Size = new System.Drawing.Size(500, 19);
        completedTaasksLabel.TabIndex = 2;
        completedTaasksLabel.Text = "label1";
        // 
        // newTaskFormBTN
        // 
        newTaskFormBTN.Location = new System.Drawing.Point(608, 473);
        newTaskFormBTN.Name = "newTaskFormBTN";
        newTaskFormBTN.Size = new System.Drawing.Size(149, 50);
        newTaskFormBTN.TabIndex = 3;
        newTaskFormBTN.Text = "Add new Task";
        newTaskFormBTN.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(895, 689);
        Controls.Add(newTaskFormBTN);
        Controls.Add(completedTaasksLabel);
        Controls.Add(countLBL);
        Controls.Add(taskListView);
        Location = new System.Drawing.Point(19, 19);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button newTaskFormBTN;

    private System.Windows.Forms.Label completedTaasksLabel;

    private System.Windows.Forms.Label countLBL;

    private System.Windows.Forms.ListView taskListView;

    #endregion
}