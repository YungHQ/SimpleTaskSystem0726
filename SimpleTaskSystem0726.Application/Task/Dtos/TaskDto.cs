using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using SimpleTaskSystem.Tasks;

namespace SimpleTaskSystem.Task.Dtos
{
    public class TaskDto : Entity<long>
    {
        public int? AssignedPersonId { get; set; }
        public string AssignedPersonName { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public byte State { get; set; }

        public override string ToString()
        {
            return $"[Task Id={Id},Description={Description},CreationTime={CreationTime}," +
                   $"AssignedPersonName={AssignedPersonName},State={(TaskState)State}]";
        }
    }
}
