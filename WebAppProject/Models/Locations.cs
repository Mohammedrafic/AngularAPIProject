namespace WebAppProject.Models
{
    public class Locations
    {
        public Guid LocationId { get; set; }

        public string? Lname { get; set; }

        public Guid? StateId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? UpdatedBy { get; set; }
    }
}
