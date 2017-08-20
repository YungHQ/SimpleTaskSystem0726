using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using SimpleTaskSystem.People;
using SimpleTaskSystem.SimpleTask;
using SimpleTaskSystem.Task.Dtos;
using SimpleTaskSystem.Tasks.Dtos;
using SimpleTaskSystem.Tasks;

namespace SimpleTaskSystem.Task
{
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IRepository<Person> _personRepository;

        public TaskAppService(ITaskRepository taskRepository, IRepository<Person> personRepository)
        {
            _taskRepository = taskRepository;
            _personRepository = personRepository;
        }

        public GetTasksOutput GetTasks(GetTasksInput input)
        {
            var tasks = _taskRepository.GetAllWithPeople(input.AssignedPersonId, input.State);

            return new GetTasksOutput { Tasks = Mapper.Map<List<TaskDto>>(tasks) };
        }

        public void UpdateTask(UpdateTaskInput input)
        {
            Logger.Info("Updating a task for input:" + input);

            var task = _taskRepository.Get(input.TaskId);

            if (input.State.HasValue)
            {
                task.State = input.State.Value;
            }

            if (input.AssignedPersonId.HasValue)
            {
                task.AssignedPerson = _personRepository.Load(input.AssignedPersonId.Value);
            }

        }

        public void CreateTask(CreateTaskInput input)
        {
            Logger.Info("Creating a task for input:" + input);

            var task = new Tasks.Task {Description = input.Description};

            if (input.AssignedPersonId.HasValue)
            {
                task.AssignedPersonId = input.AssignedPersonId.Value;
            }

            _taskRepository.Insert(task);
        }
    }
}
