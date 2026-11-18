using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GoalsCreaterAndTracker.Features.MainWindow;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoalsCreaterAndTracker.Features.AddGoal
{
    public partial class NewGoalViewModel : ObservableObject
    {
        private readonly MainWindowViewModel _mainWindowViewModel;

        public NewGoalViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }

        [RelayCommand]
        private void OpenDashboardWindow()
        {
            _mainWindowViewModel.NavigateToDashboard();
        }
    }
}
