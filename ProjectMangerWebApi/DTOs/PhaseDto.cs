namespace ProjectMangerWebApi.Models
{
    public class PhaseDto
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; }

        public int ProjectId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
