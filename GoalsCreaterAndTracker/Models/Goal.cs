using System;
using System.Collections.Generic;
using System.Text;

namespace GoalsCreaterAndTracker.Models
{
    public class Goal
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsCompleted { get; set; }
        public TimeSpan Timer { get; set; }
        public GoalState State { get; set; }
        public GoalPriority Priority { get; set; }
        public GoalCategory Category { get; set; }
    }

    public enum GoalState
    {
        NotStarted,
        InProgress,
        Completed,
        Late,
        Abandoned
    }

    public enum GoalPriority
    {
        Low,
        Medium,
        High
    }

    public enum GoalCategory
    {
        Personal,
        Work,
        Projects,
        Health,
        Education,
        Finance,
        Other
    }
}
