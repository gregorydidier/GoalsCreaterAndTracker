using CommunityToolkit.Mvvm.ComponentModel;
using GoalsCreaterAndTracker.Features.AddGoal;
using GoalsCreaterAndTracker.Features.Dashboard;

namespace GoalsCreaterAndTracker.Features.MainWindow
{
    public partial class MainWindowViewModel: ObservableObject
    {
        [ObservableProperty]
        private ObservableObject _currentViewModel;

        public MainWindowViewModel()
        {
            CurrentViewModel = new DashboardViewModel(this);
        }

        public void NavigateToNewGoal()
        {
            CurrentViewModel = new NewGoalViewModel(this);
        }

        // Navigate to Edit Goal View

        public void NavigateToDashboard()
        {
            CurrentViewModel = new DashboardViewModel(this);
        }

        // Navigate to Completed Goals View

        // Navigate to Metrics View

        // Navigate to Settings View
    }
}
