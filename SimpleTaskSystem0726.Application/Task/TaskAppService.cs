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
        //在构造函数中使用构造函数注入设置这些成员
        private readonly ITaskRepository _taskRepository;
        private readonly IRepository<Person> _personRepository;

        /// <summary>
        /// 在构造函数中，我们可以获取需要的类/接口。他们自动被依赖注入系统初始化。
        /// </summary>
        /// <param name="taskRepository"></param>
        /// <param name="personRepository"></param>
        public TaskAppService(ITaskRepository taskRepository, IRepository<Person> personRepository)
        {
            _taskRepository = taskRepository;
            _personRepository = personRepository;
        }

        public GetTasksOutput GetTasks(GetTasksInput input)
        {
            //调用task仓储的GetAllWithPeople方法
            var tasks = _taskRepository.GetAllWithPeople(input.AssignedPersonId, input.State);

            //使用AutoMapper自动将List<Task>转换为List<TaskDto>
            return new GetTasksOutput { Tasks = Mapper.Map<List<TaskDto>>(tasks) };
        }

        public void UpdateTask(UpdateTaskInput input)
        {
            //我们可以使用Logger，它在应用服务基类中定义
            Logger.Info("Updating a task for input:" + input);

            //使用仓储的标准方法Get通过给定的id重新获取task实体
            var task = _taskRepository.Get(input.TaskId);

            //更新重新获取的task实体的属性
            if (input.State.HasValue)
            {
                task.State = input.State.Value;
            }

            if (input.AssignedPersonId.HasValue)
            {
                task.AssignedPerson = _personRepository.Load(input.AssignedPersonId.Value);
            }

            //我们不需要调用仓储的Update方法。因为应用服务方法默认为一个工作单元。
            //当工作单元结束时（没有任何异常），ABP自动保存所有更改。
        }

        public void CreateTask(CreateTaskInput input)
        {
            //我们可以使用Logger，它在应用服务基类中定义
            Logger.Info("Creating a task for input:" + input);

            //使用给定的input的属性创建一个新的Task
            var task = new Tasks.Task {Description = input.Description};

            if (input.AssignedPersonId.HasValue)
            {
                task.AssignedPersonId = input.AssignedPersonId.Value;
            }

            //使用仓储标准Insert方法保存实体
            _taskRepository.Insert(task);
        }
    }
}
