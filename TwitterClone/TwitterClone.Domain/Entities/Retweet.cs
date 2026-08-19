
namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _id;
        private Guid _tweetId;
        private Guid _authorId;
        private string _content;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private string _createdBy;
        private string _updatedBy;
        public Retweet(Guid tweetId, Guid authorId, string content,string createdBy)
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _createdBy = createdBy;
            _tweetId = tweetId;
            _authorId = authorId;
            _content = content; 
        }
            

        public Guid Id {  get { return _id; } }
        public Guid TweetId { get { return _tweetId; } }
        public Guid AuthorId { get { return _authorId; } }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
        }
        public string CreatedBy
        {
            get { return _createdBy; }
        }
        public string UpdatedBy
        {
            get { return _updatedBy; }
        }

    }
}
