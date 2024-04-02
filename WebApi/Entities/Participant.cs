using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Participant
    {
        [Key]
        public required int Id { get; set; }
        public required string UserId { get; set; }
        public required User User { get; set; }
        public required int ProjectId { get; set; }
        public required Project Project { get; set; }
    }
}
