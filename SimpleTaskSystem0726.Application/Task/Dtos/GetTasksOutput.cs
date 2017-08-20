using System.Collections.Generic;
using SimpleTaskSystem.Task.Dtos;

namespace SimpleTaskSystem.Tasks.Dtos
{
    public class GetTasksOutput
    {
        public List<TaskDto> Tasks { get; set; } 
    }
}