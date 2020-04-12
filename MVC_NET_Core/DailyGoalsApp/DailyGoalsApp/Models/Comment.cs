using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyGoalsApp.Models
{
    public class Comment
    {
        //Association attribute
        private User _user;

        //Foreign Key
        private string _userId;

        //Attributes
        private string _commentId;
        private string _commentMain;
        private DateTime _commentDate;
        private int _commentEmotion;

        //Properties
        public User User { get; set; }
        public string UserId { get; set; }
        public string CommentId { get; set; }
        public string CommentMain { get; set; }
        public DateTime CommentDate { get; set; }
        public int CommentEmotion { get; set; }

        //Constructor
        public Comment(User pUser, string pUserId, string pCommentId, string pCommentMain, DateTime pCommentDate, int pCommentEmotion)
        {
            User = pUser;
            UserId = pUser.UserId;
            CommentId = pCommentId;
            CommentMain = pCommentMain;
            CommentDate = pCommentDate;
            CommentEmotion = pCommentEmotion;
        }

        //Methods
        public override string ToString()
        {
            return ($"{this.CommentMain}");
        }
    }
}
