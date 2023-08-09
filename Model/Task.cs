using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Task
    {
        [Key]
        public int Id { get; set; } 
        public int ProjectId { get; set; }
        public string Description { get; set; } = string.Empty;
        public TaskDate TaskDate { get; set; } = new TaskDate();
        public int IsActived { get; set; } = 1;

    }
}
