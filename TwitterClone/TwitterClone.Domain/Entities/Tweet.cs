
namespace TwitterClone.Domain.Entities
{
    public class Tweet: BaseEntity,ILikeable
    {
       
        private Guid _authorId;
        private string _content;
        
        public Tweet( string Content) 
        {
            _content = Content;

        }
        public Tweet(Guid authorId, string content)
        {
            AuthorId = authorId;
            Content = content;
        }

        public Guid AuthorId { 
            get { return _authorId; }
            set { _authorId = value; }
        } 
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public void AddContent(string content)
        {
            _content = content;
        }

        public void AddContent(Guid authorId, string content)
        {
            _authorId = authorId;
            _content = content;
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {AuthorId}, Content: {Content}";
        }

        public bool CanBeLiked()
        {
            return true;
        }





    }
}
