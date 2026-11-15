using GoalsCreaterAndTracker.Core;
using GoalsCreaterAndTracker.Features.AddGoal;
using System.ComponentModel;
using System.Windows.Input;

namespace GoalsCreaterAndTracker.Features.Dashboard
{
    internal class DashboardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand IOpenNewWindow => new RelayCommand(OpenNewWindow);

        private void OpenNewWindow()
        {
            NewGoalView newGoalView = new NewGoalView();
            newGoalView.Show();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
