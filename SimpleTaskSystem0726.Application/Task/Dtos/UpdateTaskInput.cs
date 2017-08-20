using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Runtime.Validation;
using SimpleTaskSystem.Tasks;

namespace SimpleTaskSystem.Task.Dtos
{
    public class UpdateTaskInput : ICustomValidate
    {
        [Range(1, long.MaxValue)]
        public long TaskId { get; set; }

        public int? AssignedPersonId { get; set; }

        public TaskState? State { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {
            if (AssignedPersonId == null && State == null)
            {
                context.Results.Add(
                    new ValidationResult(
                        "Both of AssignedPersonId and State can not be null in order to update a Task!",
                    new[] { "AssignedPersonId", "State" }));
            }
        }

        public override string ToString()
        {
            return $"[UpdateTaskInput > TaskId = {TaskId}, AssignedPersonId = {AssignedPersonId}, State = {State}]";
        }
    }

}
