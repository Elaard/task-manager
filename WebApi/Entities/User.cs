using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class User
    {
        [Key]
        public required string Id { get; set; }
        public ICollection<Participant> Participants { get; set; } = new List<Participant>();
    }
}
