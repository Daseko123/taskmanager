using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using TaskManager;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private string fileName = "tasks.json";

        public Form1()
        {
            InitializeComponent();
            LoadTasks();
            UpdateTaskList();
        }

        private void AddTask()
        {
            string taskName = textBoxTask.Text.Trim();

            if (string.IsNullOrWhiteSpace(taskName))
            {
                MessageBox.Show("Enter a task first.");
                return;
            }

            TaskItem newTask = new TaskItem(taskName);
            tasks.Add(newTask);

            textBoxTask.Clear();

            UpdateTaskList();
            SaveTasks();
        }

        private void RemoveTask()
        {
            int selectedIndex = listBoxTasks.SelectedIndex;

            if (selectedIndex < 0)
            {
                MessageBox.Show("Select a task first.");
                return;
            }

            tasks.RemoveAt(selectedIndex);

            UpdateTaskList();
            SaveTasks();
        }

        private void CompleteTask()
        {
            int selectedIndex = listBoxTasks.SelectedIndex;

            if (selectedIndex < 0)
            {
                MessageBox.Show("Select a task first.");
                return;
            }

            tasks[selectedIndex].IsCompleted = true;

            UpdateTaskList();
            SaveTasks();
        }

        private void SaveTasks()
        {
            try
            {
                string json = JsonSerializer.Serialize(
                    tasks,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(fileName, json);
            }
            catch
            {
                MessageBox.Show("Could not save tasks.");
            }
        }

        private void LoadTasks()
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    tasks = new List<TaskItem>();
                    return;
                }

                string json = File.ReadAllText(fileName);

                List<TaskItem> loadedTasks =
                    JsonSerializer.Deserialize<List<TaskItem>>(json);

                if (loadedTasks != null)
                {
                    tasks = loadedTasks;
                }
            }
            catch
            {
                tasks = new List<TaskItem>();
                MessageBox.Show("Could not load tasks.");
            }
        }

        private void UpdateTaskList()
        {
            listBoxTasks.Items.Clear();

            for (int i = 0; i < tasks.Count; i++)
            {
                string status;

                if (tasks[i].IsCompleted)
                {
                    status = "Completed";
                }
                else
                {
                    status = "Not completed";
                }

                listBoxTasks.Items.Add(
                    tasks[i].Name + " - " + status);
            }

            labelTaskCount.Text = "Tasks: " + tasks.Count;
        }

        private void OpenSettings()
        {
            SettingsForm settingsForm = new SettingsForm(tasks);

            settingsForm.ShowDialog();

            UpdateTaskList();
            SaveTasks();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTask();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveTask();
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            CompleteTask();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void textBoxTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTask();
                e.SuppressKeyPress = true;
            }
        }
    }
}