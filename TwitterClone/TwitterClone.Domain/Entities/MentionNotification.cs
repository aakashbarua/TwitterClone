using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public  class MentionNotification : Notification
    {
        public MentionNotification(Guid MentionBy) : base("Mention")
        {
            MentionByUserId = MentionBy;
        }
        public Guid MentionByUserId { get; set; }
        public override string DescribeRecord()
        {
                var baseRecord=base.DescribeRecord();
             return $"{baseRecord}  ChildEntity =>  Notification Type : {Type} ,Message :{Message}," +
                $" IsRead :{Isread},MentionBY:{MentionByUserId}";
        }

        public override string GetMessage()
        {
            return $"User : {MentionByUserId} Mention Your on a post";
        }

    
    }
}
