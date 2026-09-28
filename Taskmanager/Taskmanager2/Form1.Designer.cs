namespace TaskManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Label labelTaskCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new System.Windows.Forms.Label();
            labelTask = new System.Windows.Forms.Label();
            textBoxTask = new System.Windows.Forms.TextBox();
            buttonAdd = new System.Windows.Forms.Button();
            buttonRemove = new System.Windows.Forms.Button();
            buttonComplete = new System.Windows.Forms.Button();
            buttonSettings = new System.Windows.Forms.Button();
            listBoxTasks = new System.Windows.Forms.ListBox();
            labelTaskCount = new System.Windows.Forms.Label();

            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                20F,
                System.Drawing.FontStyle.Bold);
            labelTitle.Location = new System.Drawing.Point(30, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "Task Manager";

            labelTask.AutoSize = true;
            labelTask.Location = new System.Drawing.Point(30, 85);
            labelTask.Name = "labelTask";
            labelTask.Text = "New task:";

            textBoxTask.Location = new System.Drawing.Point(30, 110);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new System.Drawing.Size(350, 23);
            textBoxTask.KeyDown += textBoxTask_KeyDown;

            buttonAdd.Location = new System.Drawing.Point(400, 109);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(100, 25);
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;

            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new System.Drawing.Point(30, 155);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new System.Drawing.Size(470, 184);

            buttonComplete.Location = new System.Drawing.Point(30, 355);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new System.Drawing.Size(110, 30);
            buttonComplete.Text = "Complete";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;

            buttonRemove.Location = new System.Drawing.Point(150, 355);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new System.Drawing.Size(110, 30);
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;

            buttonSettings.Location = new System.Drawing.Point(390, 355);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new System.Drawing.Size(110, 30);
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;

            labelTaskCount.AutoSize = true;
            labelTaskCount.Location = new System.Drawing.Point(30, 405);
            labelTaskCount.Name = "labelTaskCount";
            labelTaskCount.Text = "Tasks: 0";

            AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            ClientSize = new System.Drawing.Size(540, 450);

            Controls.Add(labelTitle);
            Controls.Add(labelTask);
            Controls.Add(textBoxTask);
            Controls.Add(buttonAdd);
            Controls.Add(buttonRemove);
            Controls.Add(buttonComplete);
            Controls.Add(buttonSettings);
            Controls.Add(listBoxTasks);
            Controls.Add(labelTaskCount);

            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            MaximizeBox = false;
            Name = "Form1";
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Task Manager";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}