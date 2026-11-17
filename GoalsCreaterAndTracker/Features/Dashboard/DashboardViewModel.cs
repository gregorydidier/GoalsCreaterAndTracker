using CommunityToolkit.Mvvm.ComponentModel;
using GoalsCreaterAndTracker.Core;
using GoalsCreaterAndTracker.Features.AddGoal;
using GoalsCreaterAndTracker.Features.GoalView;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace GoalsCreaterAndTracker.Features.Dashboard
{
    internal class DashboardViewModel : ObservableObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand IOpenNewWindow => new RelayCommand(OpenNewWindow);
        public ObservableCollection<GoalViewModel> ChildViewModels { get; } = new();

        private GoalViewModel? _selectedChild;
        public GoalViewModel? SelectedChild
        {
            get => _selectedChild;
            set => SetProperty(ref _selectedChild, value);
        }

        private void OpenNewWindow()
        {
            NewGoalWindow newGoalWindow = new NewGoalWindow();
            newGoalWindow.Show();
        }
    }
}
