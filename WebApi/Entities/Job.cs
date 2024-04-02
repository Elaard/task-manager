using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Task")]
    public class Job
    {
        [Key]
        public required int Id { get; set; }
        public ICollection<Subtask> Subtasks { get; set; } = new List<Subtask>();
    }

}
