using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FirstModuleProject.ViewModels
{
    public class ViewAViewModel : BindableBase, IRegionMemberLifetime, INavigationAware
    {
        #region Declarations
        IRegionManager regionManager;
        string _indicator;
        #endregion

        #region IRegionMemberLifetime implementation 
        public bool KeepAlive => true;
        #endregion

        #region Commands
        public DelegateCommand GoToViewA1Command { get; }
        public DelegateCommand GoToViewA2Command { get; }
        public DelegateCommand ShowMessageCommand { get; }
        #endregion

        #region Constructors
        public ViewAViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            GoToViewA1Command = new DelegateCommand(GoToViewA1);
            GoToViewA2Command = new DelegateCommand(GoToViewA2);
            ShowMessageCommand = new DelegateCommand(ShowMessageExecute);
        }
        #endregion

        #region Utilities
        private void GoToViewA1()
        {
            regionManager.RequestNavigate("RegionA12", "ViewA1");
        }

        private void GoToViewA2()
        {
            regionManager.RequestNavigate("RegionA12", "ViewA2");
        }

        private void ShowMessageExecute()
        {
            Indicator = "You have pressed Press me button";
        }
        #endregion

        #region INavigationAware implementation 
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            MessageBox.Show("You have just navigated to ViewA");
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            MessageBox.Show("You have just navigated from ViewA");
        }
        #endregion

        #region Properties 
        public string Indicator
        {
            set { SetProperty(ref _indicator, value); }
            get { return _indicator; }
        }
        #endregion
    }
}
