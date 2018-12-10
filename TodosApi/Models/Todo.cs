using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodosApi.Models
{
    public class Todo
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
    }
}
