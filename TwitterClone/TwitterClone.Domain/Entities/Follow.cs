
namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id; 
        private Guid _followerId;
        private Guid _followeeId;
        private DateTime _followedAt;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private string _createdBy;
        private string _updatedBy;
        public Follow(Guid followerId, Guid followeeId, DateTime followedAt,string createdBy)
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _createdBy = createdBy;
            _followerId = followerId;
            _followeeId = followeeId;
            _followedAt = followedAt;
        }

        public Guid Id{ get { return _id; } }
        public Guid FollowerId { get { return _followerId; } }
        public Guid FolloweeId { get { return _followeeId;  } }
        public DateTime FollowedAt { get { return _followedAt;  } }
        public DateTime CreatedAt { get { return _createdAt; } }
        public DateTime UpdatedAt { get { return _updatedAt; } }

        public string CreatedBy { get { return _createdBy; } }
        public string UpdatedBy { get { return _updatedBy; } }
    }
}
