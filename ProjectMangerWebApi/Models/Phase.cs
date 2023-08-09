using System.ComponentModel.DataAnnotations;

namespace ProjectMangerWebApi.Models
{
    public class Phase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
