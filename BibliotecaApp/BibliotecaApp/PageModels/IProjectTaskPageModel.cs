using BibliotecaApp.Models;
using CommunityToolkit.Mvvm.Input;

namespace BibliotecaApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}