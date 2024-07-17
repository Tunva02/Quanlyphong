using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Quanlyphong.Utilities;
using System.Windows.Input;
using Quanlyphong.Models;
using Quanlyphong.View;

namespace Quanlyphong.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand RoomCommand { get; set; }
        
        private void Room(object obj) => CurrentView = new uc_RoomVM();
        public NavigationVM()
        {
            RoomCommand = new RelayCommand(Room);

            CurrentView = new uc_RoomVM();
        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                return true;
            }

            return false;
        }

        private string title_Main;

        public string Title_Main { get => title_Main; set => SetProperty(ref title_Main, value); }
    }
}

