using System;

namespace TaskManagerAPI.Models
{
    public class TaskItem
    {
        public Guid Id { get; set; } 
        public required string Name { get; set; } 
        public required string Description { get; set; } 
        public required string Priority { get; set; } 
        public DateTime Deadline { get; set; } 
        public required string Status { get; set; } 
    }
}
