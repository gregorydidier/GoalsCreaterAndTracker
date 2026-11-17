using CommunityToolkit.Mvvm.ComponentModel;
using GoalsCreaterAndTracker.Core;
using GoalsCreaterAndTracker.Features.AddGoal;
using GoalsCreaterAndTracker.Features.GoalView;
using GoalsCreaterAndTracker.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace GoalsCreaterAndTracker.Features.Dashboard
{
    internal class DashboardViewModel : ObservableObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand IOpenNewWindow => new RelayCommand(OpenNewWindow);
        public ObservableCollection<GoalSummaryViewModel> GoalSummaries { get; } = new();

        private GoalSummaryViewModel? _selectedChild;
        public GoalSummaryViewModel? SelectedChild
        {
            get => _selectedChild;
            set => SetProperty(ref _selectedChild, value);
        }

        public DashboardViewModel()
        {
            LoadTestData();
        }

        private void OpenNewWindow()
        {
            NewGoalWindow newGoalWindow = new NewGoalWindow();
            newGoalWindow.Show();
        }

        private void LoadTestData()
        {
            var sampleGoals = new[]
            {
                new Goal
                {
                    Title = "Learn WPF MVVM",
                    Description = "Build a clean master-detail application using CommunityToolkit.",
                    State = GoalState.InProgress, // Replace with your actual enum values
                    Priority = GoalPriority.High,
                    Category = GoalCategory.Education,
                    DueDate = DateTime.Today.AddDays(7)
                },
                new Goal
                {
                    Title = "Run 5km",
                    Description = "Complete a 5km morning run without stopping.",
                    State = GoalState.NotStarted,
                    Priority = GoalPriority.Medium,
                    Category = GoalCategory.Health,
                    DueDate = DateTime.Today.AddDays(14)
                },
                new Goal
                {
                    Title = "Read Clean Code",
                    Description = "Finish chapters 1 through 5 and take notes.",
                    State = GoalState.Completed,
                    Priority = GoalPriority.Low,
                    Category = GoalCategory.Personal,
                    DueDate = DateTime.Today.AddDays(-2)
                }
            };

            foreach (var goal in sampleGoals)
            {
                GoalSummaries.Add(new GoalSummaryViewModel(goal));
            }
        }
    }
}
