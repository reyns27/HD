using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int ProfileId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;
        public int IsActive { get; set; } = 1;

        public virtual List<Task> Tasks { get; set; } = new List<Task>();
    }
}
