using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Principal;
using Xap.Models;

namespace Xap.ViewModels
{
    public class SettingsPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public SettingsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Settings";
        }

        private ObservableCollection<BranchDto> _branches = new ObservableCollection<BranchDto>(new List<BranchDto> { new BranchDto { BranchId = 1, AgencyId = 1, BranchName = "Branch One" } });
        public ObservableCollection<BranchDto> Branches
        {
            get { return _branches; }
            set
            {
                SetProperty(ref _branches, value);
            }
        }

        private ObservableCollection<RoomDto> _rooms = new ObservableCollection<RoomDto>(new List<RoomDto> { new RoomDto { BranchId = 1, RoomId = 1, RoomName = "Room One" } });
        public ObservableCollection<RoomDto> Rooms
        {
            get { return _rooms; }
            set
            {
                SetProperty(ref _rooms, value);
            }
        }

        private string _agencyName = "AGENCY NAME";
        public string AgencyName
        {
            get { return _agencyName; }
            set
            {
                SetProperty(ref _agencyName, value);
            }

        }
    }
}
