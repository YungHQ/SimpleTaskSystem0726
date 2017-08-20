using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem.Task.Dtos
{
    public class CreateTaskInput
    {
        public int? AssignedPersonId { get; set; }
        [Required]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"[CreateTaskInput > AssignedPersonId = {AssignedPersonId}, Description = {Description}]";
        }
    }
}
