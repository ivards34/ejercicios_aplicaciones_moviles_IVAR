using CommunityToolkit.Mvvm.Input;
using TiendaApp.Models;

namespace TiendaApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}