
namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        private Guid _tweetId;
        private Guid _authorId;
        private string _content;

        public Retweet( string content)
        {
            _content = Content;

        }
        public Guid TweetId { get { return _tweetId; } }
        public Guid AuthorId { get { return _authorId; } }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        

    }
}
