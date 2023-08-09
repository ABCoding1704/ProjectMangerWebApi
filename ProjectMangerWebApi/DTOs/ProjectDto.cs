namespace ProjectMangerWebApi.Models
{
    public class ProjectDto
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; } = (DateTime.Now).AddDays(1);
    }
}
