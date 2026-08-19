namespace TwitterClone.Domain.Entities
{
    public class Message: BaseEntity
    {
       
        private Guid _senderId;
        private Guid _receiverId;
        private string _description;
        private bool _isRead;


        public Message()
        {
        }

    
        public Guid SenderId { 
            get { return _senderId; }
            set { _senderId = value; }
        }
       public Guid ReceiverId
        {
            get { return _receiverId; }
            set { _receiverId = value; }
        }
        public string Description { 
            get { return _description; }
            set { _description = value; }
        
        }
        
        public bool IsRead { 
            get { return _isRead; }
            set { _isRead = value; }
        }
    }
}
