using System.ComponentModel;

namespace TODO_APP;

partial class AddTaskForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        saveButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(106, 139);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(584, 27);
        textBox1.TabIndex = 0;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(106, 217);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(584, 91);
        textBox2.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(260, 39);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(294, 65);
        label1.TabIndex = 2;
        label1.Text = "ADD NEW TASK";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(106, 113);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(59, 26);
        label2.TabIndex = 3;
        label2.Text = "Title:";
        label2.Click += label2_Click_1;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        label3.Location = new System.Drawing.Point(106, 188);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(164, 26);
        label3.TabIndex = 4;
        label3.Text = "Description:";
        // 
        // saveButton
        // 
        saveButton.Location = new System.Drawing.Point(308, 335);
        saveButton.Name = "saveButton";
        saveButton.Size = new System.Drawing.Size(165, 41);
        saveButton.TabIndex = 5;
        saveButton.Text = "SAVE";
        saveButton.UseVisualStyleBackColor = true;
        // 
        // AddTaskForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(saveButton);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Text = "AddTaskForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button saveButton;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    #endregion
}