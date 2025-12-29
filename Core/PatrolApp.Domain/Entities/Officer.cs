namespace PatrolApp.Domain.Entities
{
    public class Officer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}
