
using System;
using FiveM_Launcher.Core;

namespace FiveM_Launcher.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand PlayViewCommand { get; set; }
        public RelayCommand SetViewCommand { get; set; }

        public PlayViewModel PlayVM { get; set; }
        public SettingsViewModel SetVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            PlayVM = new PlayViewModel();
            SetVM = new SettingsViewModel();
            CurrentView = PlayVM;

            PlayViewCommand = new RelayCommand(o =>
            {
                CurrentView = PlayVM;
            });

            SetViewCommand = new RelayCommand(o =>
            {
                CurrentView = SetVM;
            });

        }
    }
}
