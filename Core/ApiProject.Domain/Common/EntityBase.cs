namespace ApiProject.Domain.Common
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
