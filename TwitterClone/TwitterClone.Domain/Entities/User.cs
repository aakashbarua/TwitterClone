namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _firstname;
        private string _lastname;
        private string _email;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private string _createdBy;
        private string _updatedBy;
        

        public User(string firstname , string lastname ,string email,string createdBy) {
        
            _id= Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _firstname= firstname;  
            _lastname= lastname;
            _email= email;
            _createdBy= createdBy;

        
        }
        public Guid Id { 
            get { 
                return _id; 
            } 
        }

        public string Firstname
        {
            get {  return _firstname; }
            set { _firstname = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }

        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
           
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
            get { return _createdBy;}
        }
        public string UpdatedBy
        {
            get { return _updatedBy;}
        }
    }

}
