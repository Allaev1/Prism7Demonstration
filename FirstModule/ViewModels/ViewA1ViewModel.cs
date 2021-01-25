using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstModuleProject.ViewModels
{
    public class ViewA1ViewModel : IRegionMemberLifetime
    {
        public bool KeepAlive => true;
    }
}
