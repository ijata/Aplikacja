using Aplikacja.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand MenuViewCommand { get; set; }
        public RelayCommand ChildrenViewCommand { get; set; }
        public RelayCommand UserViewCommand { get; set; }
        public RelayCommand MessageViewCommand { get; set; }
        public RelayCommand PresenceViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }



        public HomeViewModel HomeVM { get; set; }
        public MenuViewModel MenuVM { get; set; }   
        public ChildrenViewModel ChildrenVM { get; set; }
        public UserViewModel UserVM { get; set; }
        public MessageViewModel MessageVM { get; set; }
        public PresenceViewModel PresenceVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }   

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }    
            set { _currentView = value;
                OnPropertyChanged();
            }   
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            MenuVM = new MenuViewModel();
            ChildrenVM = new ChildrenViewModel();   
            UserVM = new UserViewModel();
            MessageVM = new MessageViewModel();
            PresenceVM = new PresenceViewModel();
            SettingsVM = new SettingsViewModel();   
            
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVM;
            });

            MenuViewCommand = new RelayCommand(o =>
            {
                CurrentView = MenuVM;
            });

            ChildrenViewCommand = new RelayCommand(o =>
            {
                CurrentView = ChildrenVM;
            });

            UserViewCommand = new RelayCommand(o =>
            {
                CurrentView = UserVM;
            });
            MessageViewCommand = new RelayCommand(o =>
            {
                CurrentView = MessageVM;
            });
            PresenceViewCommand = new RelayCommand(o =>
            {
                CurrentView = PresenceVM;
            });
            SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVM;
            });
        }
    }
}
