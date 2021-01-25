# Prism Demonstration 

This project demonstrates:
- INotifyPropertyChanged(MVVM) and ICommand implementations;  
- Usage of Unity DI-container;
- IRegionMemberLifetime and INavigationAware implementations;
- Usage of Binding to property;    

IRegionMemberLifetime and INavigationAware interfaces  

Prism provides the IRegionMemberLifetime interface,   
which allows you to control the lifetime of views within regions   
by allowing you to specify whether deactivated views are to be removed from the region or simply marked as deactivated.

INavigationAware - this interface allows the view or view model to participate in a navigation operation

```csharp
public interface INavigationAware
{
    bool IsNavigationTarget(NavigationContext navigationContext);
    void OnNavigatedTo(NavigationContext navigationContext);
    void OnNavigatedFrom(NavigationContext navigationContext);
}
```

