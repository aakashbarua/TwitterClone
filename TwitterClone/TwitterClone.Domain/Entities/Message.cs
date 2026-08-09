namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _userId;
        private string _messageType;
        private string _description;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private string _createdBy;
        private string _updatedBy;
        private bool _isRead;


        public Message(Guid userId, string type, string description, string createdBy, bool isRead)
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _userId = userId;
            _messageType = type;
            _description = description;
            _createdBy = createdBy;
            _isRead = isRead;
        }

        public Guid Id { get { return _id; } }
        public Guid UserId { get { return _userId; } }
        public string MessageType{ get { return _messageType; } }
        public string Description { get { return _description; } }
        public DateTime CreateAt { get { return _createdAt; } }
        public DateTime UpdatedAt { get { return _updatedAt; } }

        public string CreatedBy { get { return _createdBy; } }
        public string UpdatedBy { get { return _updatedBy; } }
        public bool IsRead { get { return _isRead; } }
    }
}
