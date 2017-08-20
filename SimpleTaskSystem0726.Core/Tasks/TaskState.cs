using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem.Tasks
{
    /// <summary>
    /// Possible state of a <see cref="Task"/>
    /// </summary>
    public enum TaskState : byte
    {
        Active = 1,

        Completed = 2
    }
}
