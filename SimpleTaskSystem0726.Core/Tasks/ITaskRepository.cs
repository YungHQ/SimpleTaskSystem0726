using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Repositories;

namespace SimpleTaskSystem.Tasks
{
    public interface  ITaskRepository:IRepository<Task,long>
    {
        List<Task> GetAllWithPeople(int? assignedPersonId, TaskState? state);
    }
}
