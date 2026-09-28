using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class SettingsForm : Form
    {
        private List<TaskItem> tasks;

        public SettingsForm(List<TaskItem> taskList)
        {
            InitializeComponent();
            tasks = taskList;
        }

        private void ClearTasks()
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete all tasks?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                tasks.Clear();
                MessageBox.Show("All tasks were deleted.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTasks();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}