using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed class LikeNotification :Notification
    {
        public Guid LikeByUserId { get; set; }
        public LikeNotification(Guid LikebyUserId) : base("Like")
        {
            LikeByUserId = LikebyUserId;

        }
        public void  AddMessage(string message) 
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord=base.DescribeRecord();
            return $"{baseRecord}  ChildEntity =>  Notification Type : {Type} ,Message :{Message}, IsRead :{Isread},LikeBy:{LikeByUserId}";
        }


    }
}
