
namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
       
        private Guid _authorId;
        private string _content;
        
        public Tweet( string Content) 
        {
            _content = Content;

        }
        
        
        public Guid AuthorId { get { return _authorId; } } 
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

      
       
    }
}
