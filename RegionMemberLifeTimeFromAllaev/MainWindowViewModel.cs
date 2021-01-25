using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace RegionMemberLifeTimeFromAllaev
{
    public class MainWindowViewModel : BindableBase
    {
        IRegionManager regionManager;

        public DelegateCommand<string> NavigateCommand { get; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string viewToNavigate)
        {
            regionManager.RequestNavigate("ContentRegion", viewToNavigate);
        }
    }
}
