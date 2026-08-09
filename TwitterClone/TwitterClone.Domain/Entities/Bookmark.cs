namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private string _createdBy;
        private string _updatedBy;



        public Guid UserId { get { return _userId; } }
        public Guid TweetId { get { return _tweetId; } }
        public Guid Id { get { return _id; } }
        public DateTime CreatedAt { get { return _createdAt; } }
        public DateTime UpdatedAt { get { return _updatedAt; } }

        public string CreatedBy { get { return _createdBy; } }
        public string UpdatedBy { get { return _updatedBy; } }


        public Bookmark(Guid userId, Guid tweetId,string createdBy)
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _userId = userId;
            _tweetId = tweetId;
            _createdBy = createdBy;
           
        }
    }
}
