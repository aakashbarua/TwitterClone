using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed class CommentNotification : Notification
    {
        public Guid CommentByUserId {  get; set; }
        public CommentNotification(Guid CommentById): base("Comment") 
        {
            CommentByUserId = CommentById;
        }
        public void AddMessage(string message)
        {
            Message= message;
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}  ChildEntity =>  Notification Type : {Type} ,Message :{Message}, IsRead :{Isread},LikeBy:{LikeByUserId}";
        }
    }
}
