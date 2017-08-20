using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Abp.EntityFramework;
using SimpleTaskSystem.Tasks;
using SimpleTaskSystem0726.EntityFramework;
using SimpleTaskSystem0726.EntityFramework.Repositories;

namespace SimpleTaskSystem.EntityFramework.Repositories
{
    public class TaskRepository : SimpleTaskSystem0726RepositoryBase<Task, long>, ITaskRepository
    {
        public List<Task> GetAllWithPeople(int? assignedPersonId, TaskState? state)
        {
            var query = GetAll();

            if (assignedPersonId.HasValue)
            {
                query = query.Where(task => task.AssignedPersonId == assignedPersonId.Value);
            }
            if (state.HasValue)
            {
                query = query.Where(task => task.State == state);
            }

            return query
                .OrderByDescending(task => task.CreationTime).Include(task => task.AssignedPerson)
                .ToList();
        }

        public TaskRepository(IDbContextProvider<SimpleTaskSystem0726DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
