using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domen.Entities.States;

namespace TaskManager.Domen.Entities
{
    public  class Task
    {
        public Guid Id { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public DateTime DeadLineTime { get; set; }
        public TaskState TaskState { get; set; } = TaskState.Created;
        public DateTime CreatedDate { get; set; }
    }
}
