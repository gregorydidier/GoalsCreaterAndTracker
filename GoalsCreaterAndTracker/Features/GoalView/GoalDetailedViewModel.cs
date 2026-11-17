using CommunityToolkit.Mvvm.ComponentModel;
using GoalsCreaterAndTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GoalsCreaterAndTracker.Features.GoalView
{
    public partial class GoalDetailedViewModel: ObservableObject
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

        [ObservableProperty]
        private ObservableCollection<Step> _steps = new ObservableCollection<Step>();

        public GoalDetailedViewModel(Goal goal)
        {
            _title = goal.Title;
            _description = goal.Description;
            _progress = goal.State;
            _priority = goal.Priority;
            _category = goal.Category;
            _dueDate = goal.DueDate;
            _steps = new ObservableCollection<Step>(goal.Steps);
        }
    }
}
