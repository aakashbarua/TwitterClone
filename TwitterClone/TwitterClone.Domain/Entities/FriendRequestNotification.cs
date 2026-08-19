using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed  class FriendRequestNotification : Notification 
    { 
        public Guid RequestedByUserId {  get; set; }
        public FriendRequestNotification( Guid RequestedBy) : base("FriendRequestNotification")
        { 
            RequestedByUserId = RequestedBy;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}  ChildEntity =>  Notification Type : {Type} ," +
                $"Message :{Message}, IsRead :{Isread},FriendRequestBy:{RequestedByUserId}";
        }

        public override string GetMessage()
        {
            return $"You get Friend Request From Uder :{RequestedByUserId}";
        }
    
    }
}
