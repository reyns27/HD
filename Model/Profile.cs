using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public int RolId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;
        public int IsActive { get; set; } = 1;
    }
}
