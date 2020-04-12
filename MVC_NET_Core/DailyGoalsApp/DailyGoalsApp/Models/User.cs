using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyGoalsApp.Models
{
    public class User
    {
        //Attributes
        private string _userId;
        private string _userName;
        private string _userMail;
        private int _userExperience;

        //Properties
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public int UserExperience { get; set; }

        //Constructor
        public User(string pUserId, string pUserName, string pUserMail, int pUserExperience)
        {
            UserId = pUserId;
            UserName = pUserName;
            UserMail = pUserMail;
            UserExperience = pUserExperience;
        }

        //Methods
        public override string ToString()
        {
            return ($"User: {UserName} - Exp: {UserExperience}");
        }
    }
}
