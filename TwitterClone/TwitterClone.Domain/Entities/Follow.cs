
namespace TwitterClone.Domain.Entities
{
    public class Follow: BaseEntity
    {
    
        private Guid _followerId;
        private Guid _followeeId;
        private DateTime _followedAt;
        public Follow()
        {
        }

       
        public Guid FollowerId { 
            get { return _followerId; }
            set { _followerId = value; }
        }
        public Guid FolloweeId { 
            get { return _followeeId;  }
            set { _followeeId = value; }
        }
        public DateTime FollowedAt {
            get { return _followedAt; }
            set { _followedAt = value; }

        }
       
    }
}
