using TwitterClone.Domain.Entities;

public class Abstrction
{
    public void Run()
    {
        var notifications = new List<Notification>()
        {
            new LikeNotification(Guid.NewGuid()),
            new CommentNotification(Guid.NewGuid()),
            new FriendRequestNotification(Guid.NewGuid()),
            new MentionNotification(Guid.NewGuid()),
            new SystemNotification()
        };

        foreach (var notification in notifications)
        {
            Console.WriteLine(notification.GetMessage());
        }
    }

    public static void Main()
    {
        var abstraction = new Abstrction();
        abstraction.Run();
    }
}