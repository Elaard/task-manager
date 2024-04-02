using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Subtask
    {
        [Key]
        public required int Id { get; set; }
        public required int JobId { get; set; }
        public required Job Job { get; set; }
    }
}
