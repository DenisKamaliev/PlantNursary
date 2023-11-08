namespace PlantNursary.Entities.Common
{
    public abstract class BaseAuditableEntity
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

    }
}
