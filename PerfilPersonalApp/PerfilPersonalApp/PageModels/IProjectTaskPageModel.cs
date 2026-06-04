using CommunityToolkit.Mvvm.Input;
using PerfilPersonalApp.Models;

namespace PerfilPersonalApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}