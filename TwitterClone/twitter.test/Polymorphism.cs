using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.Domain.Entities;

namespace twitter.test
{
    public class Polymorphism
    {
        public void Run()
        {
            Tweet likeableTweet = new Tweet("This is another tweet!");

            Console.WriteLine(likeableTweet.CanBeLiked());

            
        }
    }
}
