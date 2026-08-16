
namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get;private set; }
        public DateTime CreatedAt { get;private set; }
        public DateTime? UpdatedAt { get;private set; }
       
        public Guid CreatedBy { get;private set; }
        public Guid? UpdatedBy { get;private set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }

        public virtual string DescribeRecord()
        {
            return $"BaseEntirt =>  Id : {Id} ,CreatedAt : {CreatedAt} , UpdatedAt : {UpdatedAt}, CreatedBy : {CreatedBy}, UpdatedBy : {UpdatedBy}";
        }

    }
}
