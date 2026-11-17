using CommunityToolkit.Mvvm.ComponentModel;
using GoalsCreaterAndTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoalsCreaterAndTracker.Features.GoalView
{
    public partial class GoalSummaryViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = string.Empty;

        [ObservableProperty]
        private string _description = string.Empty;

        [ObservableProperty]
        private GoalState _progress;

        [ObservableProperty]
        private GoalPriority _priority;

        [ObservableProperty]
        private GoalCategory _category;

        [ObservableProperty]
        private DateTime _dueDate = DateTime.Today;

        public GoalSummaryViewModel(Goal goal)
        {
            _title = goal.Title;
            _description = goal.Description;
            _progress = goal.State;
            _priority = goal.Priority;
            _category = goal.Category;
            _dueDate = goal.DueDate;
        }
    }
}
