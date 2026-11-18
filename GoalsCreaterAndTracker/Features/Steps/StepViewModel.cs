using CommunityToolkit.Mvvm.ComponentModel;
using GoalsCreaterAndTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoalsCreaterAndTracker.Features.Steps
{
    public partial class StepViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _description = string.Empty;
        [ObservableProperty]
        private bool _isCompleted = false;

        public StepViewModel(Step step)
        {
            _description = step.Description;
            _isCompleted = step.IsCompleted;
        }

    }
}
