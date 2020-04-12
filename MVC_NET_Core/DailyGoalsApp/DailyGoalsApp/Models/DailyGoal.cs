using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyGoalsApp.Models
{
    public class DailyGoal
    {
        //Association attribute
        private User _user;

        //Foreign Key
        private string _userId;

        //Attributes
        private string _dailyGoalId;
        private DateTime _goalDate;
        private int _emotion;
        private List<string> _goals;

        //Properties
        public User User { get; set; }
        public string UserId { get; set; }
        public string DailyGoalId { get; set; }
        public DateTime GoalDate { get; set; }
        public int Emotion { get; set; }
        public List<string> Goals { get; set; }


        //Constructor
        public DailyGoal(User pUser, string pUserId, string pDailyGoalId, DateTime pGoalDate, int pEmotion, List<string> pGoals)
        {
            User = pUser;
            UserId = pUser.UserId;
            DailyGoalId = pDailyGoalId;
            GoalDate = pGoalDate;
            Emotion = pEmotion;
            Goals = pGoals;
        }

        //Methods
        public override string ToString()
        {
            string emotionName = "";

            switch (Emotion)
            {
                case 0:
                    emotionName = "Good";
                    break;
                case 1:
                    emotionName = "Bad";
                    break;
                case 2:
                    emotionName = "Neutral";
                    break;
            }

            return ($"Day: {GoalDate} - Goal's Count: {Goals.Count} - Day's emotion: {emotionName}");
        }
    }
}
