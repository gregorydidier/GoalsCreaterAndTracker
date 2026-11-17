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
    public partial class DashboardViewModel : ObservableObject, INotifyPropertyChanged
    {
        public ICommand IOpenNewWindow => new RelayCommand(OpenNewWindow);
        public ObservableCollection<GoalSummaryViewModel> GoalSummaries { get; } = new();
        private List<Goal> _goals = new();
        [ObservableProperty]
        private GoalSummaryViewModel? _selectedGoal;
        [ObservableProperty]
        private GoalDetailedViewModel? _selectedGoalDetails;

        partial void OnSelectedGoalChanged(GoalSummaryViewModel? value)
        {
            var matchedGoal = value != null
                ? _goals.FirstOrDefault(goal => goal.Id == value.Id)
                : null;

            SelectedGoalDetails = matchedGoal != null
                ? new GoalDetailedViewModel(matchedGoal)
                : null;
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
                            Id = 1,
                            Title = "Learn WPF MVVM",
                            Description = "Build a clean master-detail application using CommunityToolkit.",
                            State = GoalState.InProgress,
                            Priority = GoalPriority.High,
                            Category = GoalCategory.Education,
                            DueDate = DateTime.Today.AddDays(7),
                            Steps = new List<Step>()
                            {
                                new Step { Description = "Set up ViewModels with CommunityToolkit.Mvvm", IsCompleted = true },
                                new Step { Description = "Create GoalSummaryView and GoalDetailedView UserControls", IsCompleted = true },
                                new Step { Description = "Wire up Master-Detail selection and data bindings", IsCompleted = false },
                                new Step { Description = "Add task checklist functionality to GoalDetailedView", IsCompleted = false }
                            }
                        },
                        new Goal
                        {
                            Id = 2,
                            Title = "Run 5km",
                            Description = "Complete a 5km morning run without stopping.",
                            State = GoalState.NotStarted,
                            Priority = GoalPriority.Medium,
                            Category = GoalCategory.Health,
                            DueDate = DateTime.Today.AddDays(14),
                            Steps = new List<Step>()
                            {
                                new Step { Description = "Buy proper running shoes", IsCompleted = false },
                                new Step { Description = "Complete a 2km warmup jog", IsCompleted = false },
                                new Step { Description = "Run 3.5km without walking breaks", IsCompleted = false },
                                new Step { Description = "Complete the full 5km morning run", IsCompleted = false }
                            }
                        },
                        new Goal
                        {
                            Id = 3,
                            Title = "Read Clean Code",
                            Description = "Finish chapters 1 through 5 and take notes.",
                            State = GoalState.Completed,
                            Priority = GoalPriority.Low,
                            Category = GoalCategory.Personal,
                            DueDate = DateTime.Today.AddDays(-2),
                            Steps = new List<Step>()
                            {
                                new Step { Description = "Read Chapter 1: Clean Code", IsCompleted = true },
                                new Step { Description = "Read Chapter 2: Meaningful Names", IsCompleted = true },
                                new Step { Description = "Read Chapter 3: Functions", IsCompleted = true },
                                new Step { Description = "Summarise Chapters 4 and 5 notes", IsCompleted = true }
                            }
}

            };

            foreach (var goal in sampleGoals)
            {
                GoalSummaries.Add(new GoalSummaryViewModel(goal));
                _goals.Add(goal);
            }
        }
    }
}
