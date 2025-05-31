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
        titleTextBox = new System.Windows.Forms.TextBox();
        DescriptionTextBox = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        saveButton = new System.Windows.Forms.Button();
        gobackBTN = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // titleTextBox
        // 
        titleTextBox.Location = new System.Drawing.Point(106, 139);
        titleTextBox.Name = "titleTextBox";
        titleTextBox.Size = new System.Drawing.Size(584, 27);
        titleTextBox.TabIndex = 0;
        // 
        // DescriptionTextBox
        // 
        DescriptionTextBox.Location = new System.Drawing.Point(106, 217);
        DescriptionTextBox.Multiline = true;
        DescriptionTextBox.Name = "DescriptionTextBox";
        DescriptionTextBox.Size = new System.Drawing.Size(584, 91);
        DescriptionTextBox.TabIndex = 1;
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
        saveButton.Click += saveButton_Click;
        // 
        // gobackBTN
        // 
        gobackBTN.Location = new System.Drawing.Point(525, 388);
        gobackBTN.Name = "gobackBTN";
        gobackBTN.Size = new System.Drawing.Size(165, 41);
        gobackBTN.TabIndex = 6;
        gobackBTN.Text = "SAVE";
        gobackBTN.UseVisualStyleBackColor = true;
        gobackBTN.Click += gobackBTN_Click;
        // 
        // AddTaskForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(gobackBTN);
        Controls.Add(saveButton);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(DescriptionTextBox);
        Controls.Add(titleTextBox);
        Text = "AddTaskForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button gobackBTN;

    private System.Windows.Forms.Button saveButton;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox titleTextBox;
    private System.Windows.Forms.TextBox DescriptionTextBox;

    #endregion
}