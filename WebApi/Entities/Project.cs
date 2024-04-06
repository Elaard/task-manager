using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Project
    {
        [Key]
        public required int Id { get; set; }
        public ICollection<Participant> Participants { get; set; } = new List<Participant>();
        public ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
