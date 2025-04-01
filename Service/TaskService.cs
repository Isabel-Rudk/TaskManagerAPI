using System;
using System.Collections.Generic;
using System.Linq;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Services
{
    public class TaskService
    {
        private readonly List<TaskItem> _tasks = new List<TaskItem>();

        
        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }

        
        public TaskItem GetTaskById(Guid id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

        
        public TaskItem CreateTask(TaskItem task)
        {
            task.Id = Guid.NewGuid(); 
            _tasks.Add(task);
            return task;
        }

        
        public bool UpdateTask(Guid id, TaskItem updatedTask)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return false;

            task.Name = updatedTask.Name;
            task.Description = updatedTask.Description;
            task.Priority = updatedTask.Priority;
            task.Deadline = updatedTask.Deadline;
            task.Status = updatedTask.Status;

            return true;
        }

        
        public bool DeleteTask(Guid id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return false;

            _tasks.Remove(task);
            return true;
        }
    }
}

