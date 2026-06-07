using CommunityToolkit.Mvvm.Input;
using Practico_n10.Models;

namespace Practico_n10.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}