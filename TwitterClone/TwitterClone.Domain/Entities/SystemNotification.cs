
namespace TwitterClone.Domain.Entities
{
    public sealed class SystemNotification : Notification
    {
        public SystemNotification() : base("System")
        { }

        public void AddMessage (string message)
        {
            Message = message;
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}  ChildEntity =>  Notification Type : {Type} ,Message :{Message}, IsRead :{Isread} ";
        }

        public override string GetMessage()
        {
            return $"System Notification";
        }
    }
}
